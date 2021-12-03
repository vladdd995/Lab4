
namespace Lab4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.KeyLength = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labeKeyLength = new System.Windows.Forms.Label();
            this.button_fileSaveKey = new System.Windows.Forms.Button();
            this.button_fileOpenKey = new System.Windows.Forms.Button();
            this.button_GeneratorKey = new System.Windows.Forms.Button();
            this.textBox_fileKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_fileSave = new System.Windows.Forms.Button();
            this.button_fileOpen = new System.Windows.Forms.Button();
            this.textBox_fileSave = new System.Windows.Forms.TextBox();
            this.textBox_fileOpen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeyLength
            // 
            this.KeyLength.AutoSize = true;
            this.KeyLength.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.KeyLength.Location = new System.Drawing.Point(32, 296);
            this.KeyLength.Name = "KeyLength";
            this.KeyLength.Size = new System.Drawing.Size(0, 21);
            this.KeyLength.TabIndex = 11;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time.Location = new System.Drawing.Point(337, 275);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(81, 21);
            this.time.TabIndex = 10;
            this.time.Text = "00:00:000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Тривалість шифрування (хв, сек, мс)";
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.Location = new System.Drawing.Point(538, 270);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(104, 30);
            this.Start.TabIndex = 8;
            this.Start.Text = "Старт";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labeKeyLength);
            this.groupBox2.Controls.Add(this.button_fileSaveKey);
            this.groupBox2.Controls.Add(this.button_fileOpenKey);
            this.groupBox2.Controls.Add(this.button_GeneratorKey);
            this.groupBox2.Controls.Add(this.textBox_fileKey);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 106);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ключ";
            // 
            // labeKeyLength
            // 
            this.labeKeyLength.AutoSize = true;
            this.labeKeyLength.Location = new System.Drawing.Point(33, 69);
            this.labeKeyLength.Name = "labeKeyLength";
            this.labeKeyLength.Size = new System.Drawing.Size(0, 21);
            this.labeKeyLength.TabIndex = 5;
            // 
            // button_fileSaveKey
            // 
            this.button_fileSaveKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_fileSaveKey.Image = global::Lab4.Properties.Resources._2;
            this.button_fileSaveKey.Location = new System.Drawing.Point(502, 25);
            this.button_fileSaveKey.Name = "button_fileSaveKey";
            this.button_fileSaveKey.Size = new System.Drawing.Size(61, 52);
            this.button_fileSaveKey.TabIndex = 4;
            this.button_fileSaveKey.UseVisualStyleBackColor = true;
            this.button_fileSaveKey.Click += new System.EventHandler(this.OpenKey);
            // 
            // button_fileOpenKey
            // 
            this.button_fileOpenKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_fileOpenKey.Image = global::Lab4.Properties.Resources._3;
            this.button_fileOpenKey.Location = new System.Drawing.Point(569, 25);
            this.button_fileOpenKey.Name = "button_fileOpenKey";
            this.button_fileOpenKey.Size = new System.Drawing.Size(61, 52);
            this.button_fileOpenKey.TabIndex = 3;
            this.button_fileOpenKey.UseVisualStyleBackColor = true;
            this.button_fileOpenKey.Click += new System.EventHandler(this.SaveKey);
            // 
            // button_GeneratorKey
            // 
            this.button_GeneratorKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_GeneratorKey.Image = global::Lab4.Properties.Resources._13;
            this.button_GeneratorKey.Location = new System.Drawing.Point(329, 73);
            this.button_GeneratorKey.Name = "button_GeneratorKey";
            this.button_GeneratorKey.Size = new System.Drawing.Size(104, 30);
            this.button_GeneratorKey.TabIndex = 2;
            this.button_GeneratorKey.UseVisualStyleBackColor = true;
            this.button_GeneratorKey.Click += new System.EventHandler(this.GeneratorKey);
            // 
            // textBox_fileKey
            // 
            this.textBox_fileKey.Location = new System.Drawing.Point(170, 38);
            this.textBox_fileKey.Name = "textBox_fileKey";
            this.textBox_fileKey.Size = new System.Drawing.Size(326, 29);
            this.textBox_fileKey.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Файл з ключем:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_fileSave);
            this.groupBox1.Controls.Add(this.button_fileOpen);
            this.groupBox1.Controls.Add(this.textBox_fileSave);
            this.groupBox1.Controls.Add(this.textBox_fileOpen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 148);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Файли";
            // 
            // button_fileSave
            // 
            this.button_fileSave.Location = new System.Drawing.Point(588, 87);
            this.button_fileSave.Name = "button_fileSave";
            this.button_fileSave.Size = new System.Drawing.Size(40, 30);
            this.button_fileSave.TabIndex = 5;
            this.button_fileSave.Text = "...";
            this.button_fileSave.UseVisualStyleBackColor = true;
            this.button_fileSave.Click += new System.EventHandler(this.Sava_file);
            // 
            // button_fileOpen
            // 
            this.button_fileOpen.Location = new System.Drawing.Point(590, 31);
            this.button_fileOpen.Name = "button_fileOpen";
            this.button_fileOpen.Size = new System.Drawing.Size(40, 30);
            this.button_fileOpen.TabIndex = 4;
            this.button_fileOpen.Text = "...";
            this.button_fileOpen.UseVisualStyleBackColor = true;
            this.button_fileOpen.Click += new System.EventHandler(this.Open_file);
            // 
            // textBox_fileSave
            // 
            this.textBox_fileSave.Location = new System.Drawing.Point(168, 88);
            this.textBox_fileSave.Name = "textBox_fileSave";
            this.textBox_fileSave.Size = new System.Drawing.Size(414, 29);
            this.textBox_fileSave.TabIndex = 3;
            // 
            // textBox_fileOpen
            // 
            this.textBox_fileOpen.Location = new System.Drawing.Point(170, 32);
            this.textBox_fileOpen.Name = "textBox_fileOpen";
            this.textBox_fileOpen.Size = new System.Drawing.Size(414, 29);
            this.textBox_fileOpen.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Зберегти у файл:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Відкрити файл:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 332);
            this.Controls.Add(this.KeyLength);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шифратор файлу";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KeyLength;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labeKeyLength;
        private System.Windows.Forms.Button button_fileSaveKey;
        private System.Windows.Forms.Button button_fileOpenKey;
        private System.Windows.Forms.Button button_GeneratorKey;
        private System.Windows.Forms.TextBox textBox_fileKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_fileSave;
        private System.Windows.Forms.Button button_fileOpen;
        private System.Windows.Forms.TextBox textBox_fileSave;
        private System.Windows.Forms.TextBox textBox_fileOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

