namespace ServerForm
{
    partial class Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.portTBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.OnlineBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.portTBox)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(606, 426);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(627, 12);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(161, 47);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Запустить";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // portTBox
            // 
            this.portTBox.Location = new System.Drawing.Point(669, 65);
            this.portTBox.Maximum = new decimal(new int[] {
            49151,
            0,
            0,
            0});
            this.portTBox.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.portTBox.Name = "portTBox";
            this.portTBox.Size = new System.Drawing.Size(120, 22);
            this.portTBox.TabIndex = 8;
            this.portTBox.Value = new decimal(new int[] {
            11208,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(624, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Порт: ";
            // 
            // OnlineBar
            // 
            this.OnlineBar.Location = new System.Drawing.Point(766, 93);
            this.OnlineBar.Maximum = 1;
            this.OnlineBar.Name = "OnlineBar";
            this.OnlineBar.Size = new System.Drawing.Size(23, 23);
            this.OnlineBar.Step = 1;
            this.OnlineBar.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(705, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Онлайн";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(627, 400);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(162, 38);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Сохранить лог";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.portTBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OnlineBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Server";
            this.Text = "Сервер";
            ((System.ComponentModel.ISupportInitialize)(this.portTBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.NumericUpDown portTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar OnlineBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

