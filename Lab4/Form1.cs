using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(button_fileSaveKey, "Відкрити");
            toolTip1.SetToolTip(button_fileOpenKey, "Зберегти");
        }

        

        private void OpenKey(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileKeyPath = openFileDialog.FileName;
                    textBox_fileKey.Text = fileKeyPath;
                }
            }
        }
        private void SaveKey(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileKeyPath = saveFileDialog.FileName;
                textBox_fileKey.Text = fileKeyPath;
            }
        }

        private void Open_file(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileOpenpath = openFileDialog.FileName;
                    textBox_fileOpen.Text = fileOpenpath;
                }
            }
        }
        private void Sava_file(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileSavepath = saveFileDialog.FileName;
                textBox_fileSave.Text = fileSavepath;
            }
        }

        private void GeneratorKey(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Стоворити новий ключ?", "Увага", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;

                string fileOpenpath = textBox_fileOpen.Text;
                if (File.Exists(fileOpenpath))
                {
                    string fileKeypath = textBox_fileKey.Text;
                    string dirKeypath = Path.GetDirectoryName(fileKeypath);
                    if (Directory.Exists(dirKeypath))
                    {
                        long lengthOpenfile = new FileInfo(fileOpenpath).Length;

                        byte[] arrKey = new byte[lengthOpenfile];
                        RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
                        rngCsp.GetBytes(arrKey);

                        using (FileStream fs = File.Create(fileKeypath))
                        {
                            fs.Write(arrKey, 0, arrKey.Length);
                            fs.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Шлях до ключа не вказаний\nабо такий шлях не існує");
                        textBox_fileKey.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Вхідного файлу не існує");
                    button_fileOpen.Focus();
                }

                Cursor.Current = Cursors.Default;
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            string fileOpenpath = textBox_fileOpen.Text;
            string fileSavepath = textBox_fileSave.Text;
            string fileKeypath = textBox_fileKey.Text;
            if (File.Exists(fileOpenpath))
            {
                string dirSavepath = Path.GetDirectoryName(fileSavepath);
                if (Directory.Exists(dirSavepath))
                {
                    if (File.Exists(fileKeypath))
                    {
                        long lengthOpenfile = new FileInfo(fileOpenpath).Length;
                        long lengthKeyfile = new FileInfo(fileKeypath).Length;
                        if (lengthOpenfile == lengthKeyfile)
                        {
                            Stopwatch stopwatch = new Stopwatch();
                            stopwatch.Start();

                            byte[] arrCipher = myCipherXOR(fileOpenpath, fileKeypath);
                            mySaveToFileOUT(arrCipher, fileSavepath);

                            stopwatch.Stop();

                            time.Text = stopwatch.Elapsed.ToString(@"mm\:ss\.fff");
                            long size = Encoding.UTF8.GetBytes(fileKeypath).Length;
                            labeKeyLength.Text = ("Розмір ключа:\n" + size.ToString() + " байт");

                            FileInfo fileWithKey = new FileInfo(fileSavepath);
                            long size1 = fileWithKey.Length;
                            KeyLength.Text = ("Розмір файлу з ключем: " + size1.ToString() + " байт");
                        }
                        else
                        {
                            MessageBox.Show("Розмір файлу ключа не співпадає\nз розміром вхідного файлу");
                            button_fileOpenKey.Focus();
                        }
                    }
                    else
                    {
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();

                        byte[] arrCipher = myCipherXORText(fileOpenpath, fileKeypath);
                        mySaveToFileOUT(arrCipher, fileSavepath);

                        stopwatch.Stop();

                        time.Text = stopwatch.Elapsed.ToString(@"mm\:ss\.fff");

                        long size = Encoding.UTF8.GetBytes(fileKeypath).Length;
                        labeKeyLength.Text = ("Розмір ключа:\n" + size.ToString() + " байт");

                        FileInfo fileWithKey = new FileInfo(fileSavepath);
                        long size1 = fileWithKey.Length;
                        KeyLength.Text = ("Розмір файлу з ключем: " + size1.ToString() + " байт");
                    }
                }
                else
                {
                    MessageBox.Show("Шлях до вихідного файлу не вказаний\nабо такий шлях не існує");
                    textBox_fileSave.Focus();
                }
            }
            else
            {
                MessageBox.Show("Вхідного файлу не існує");
                button_fileOpen.Focus();
            }

            Cursor.Current = Cursors.Default;
        }

        private byte[] myCipherXOR(string fileOpenpath, string fileKeypath)
        {
            byte[] arrOpen = File.ReadAllBytes(fileOpenpath);
            byte[] arrKey = File.ReadAllBytes(fileKeypath);
            int lenOpen = arrOpen.Length;
            byte[] arrCipher = new byte[lenOpen];

            for (int i = 0; i < lenOpen; i++)
            {
                arrCipher[i] = (byte)(arrOpen[i] ^ arrKey[i]);
            }
            return arrCipher;
        }

        private byte[] myCipherXORText(string fileOpenpath, string fileKeypath)
        {
            byte[] arrOpen = File.ReadAllBytes(fileOpenpath);
            byte[] arrKey = Encoding.UTF8.GetBytes(fileKeypath);
            int lenOpen = arrOpen.Length;
            int lenKey = arrKey.Length;
            byte[] arrCipher = new byte[lenOpen];

            for (int i = 0; i < lenOpen; i++)
            {
                byte p = arrOpen[i];
                byte k = arrKey[i % lenKey];
                byte c = (byte)(p ^ k);

                arrCipher[i] = c;
            }
            return arrCipher;
        }

        private void mySaveToFileOUT(byte[] arrCipher, string fileSavepath)
        {
            using (FileStream fs = File.Create(fileSavepath))
            {
                fs.Write(arrCipher, 0, arrCipher.Length);
                fs.Close();
            }
        }
    }
}
