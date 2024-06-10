namespace Client
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.evaluationGBox = new System.Windows.Forms.GroupBox();
            this.MatLabRButton = new System.Windows.Forms.RadioButton();
            this.ServerRButton = new System.Windows.Forms.RadioButton();
            this.DLLRButton = new System.Windows.Forms.RadioButton();
            this.serverGBox = new System.Windows.Forms.GroupBox();
            this.windowCheckBox = new System.Windows.Forms.CheckBox();
            this.ip2TBox = new System.Windows.Forms.NumericUpDown();
            this.ip1TBox = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.ip3TBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.ip4TBox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.streamTBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.portTBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.clientGBox = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.directoryTBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.evaluationGBox.SuspendLayout();
            this.serverGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ip2TBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip1TBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip3TBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip4TBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streamTBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portTBox)).BeginInit();
            this.clientGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // evaluationGBox
            // 
            this.evaluationGBox.Controls.Add(this.MatLabRButton);
            this.evaluationGBox.Controls.Add(this.ServerRButton);
            this.evaluationGBox.Controls.Add(this.DLLRButton);
            this.evaluationGBox.Location = new System.Drawing.Point(12, 12);
            this.evaluationGBox.Name = "evaluationGBox";
            this.evaluationGBox.Size = new System.Drawing.Size(269, 115);
            this.evaluationGBox.TabIndex = 0;
            this.evaluationGBox.TabStop = false;
            this.evaluationGBox.Text = "Для вычисления использовать:";
            // 
            // MatLabRButton
            // 
            this.MatLabRButton.AutoSize = true;
            this.MatLabRButton.Location = new System.Drawing.Point(7, 76);
            this.MatLabRButton.Name = "MatLabRButton";
            this.MatLabRButton.Size = new System.Drawing.Size(69, 20);
            this.MatLabRButton.TabIndex = 2;
            this.MatLabRButton.Text = "Matlab";
            this.MatLabRButton.UseVisualStyleBackColor = true;
            this.MatLabRButton.CheckedChanged += new System.EventHandler(this.MatLabRButton_CheckedChanged);
            // 
            // ServerRButton
            // 
            this.ServerRButton.AutoSize = true;
            this.ServerRButton.Checked = true;
            this.ServerRButton.Location = new System.Drawing.Point(7, 49);
            this.ServerRButton.Name = "ServerRButton";
            this.ServerRButton.Size = new System.Drawing.Size(161, 20);
            this.ServerRButton.TabIndex = 1;
            this.ServerRButton.TabStop = true;
            this.ServerRButton.Text = "Выделенный сервер";
            this.ServerRButton.UseVisualStyleBackColor = true;
            this.ServerRButton.CheckedChanged += new System.EventHandler(this.ServerRButton_CheckedChanged);
            // 
            // DLLRButton
            // 
            this.DLLRButton.AutoSize = true;
            this.DLLRButton.Location = new System.Drawing.Point(7, 22);
            this.DLLRButton.Name = "DLLRButton";
            this.DLLRButton.Size = new System.Drawing.Size(52, 20);
            this.DLLRButton.TabIndex = 0;
            this.DLLRButton.Text = "DLL";
            this.DLLRButton.UseVisualStyleBackColor = true;
            this.DLLRButton.CheckedChanged += new System.EventHandler(this.DLLRButton_CheckedChanged);
            // 
            // serverGBox
            // 
            this.serverGBox.Controls.Add(this.windowCheckBox);
            this.serverGBox.Location = new System.Drawing.Point(287, 12);
            this.serverGBox.Name = "serverGBox";
            this.serverGBox.Size = new System.Drawing.Size(510, 57);
            this.serverGBox.TabIndex = 2;
            this.serverGBox.TabStop = false;
            this.serverGBox.Text = "Настройки сервера";
            // 
            // windowCheckBox
            // 
            this.windowCheckBox.AutoSize = true;
            this.windowCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.windowCheckBox.Checked = true;
            this.windowCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.windowCheckBox.Location = new System.Drawing.Point(6, 23);
            this.windowCheckBox.Name = "windowCheckBox";
            this.windowCheckBox.Size = new System.Drawing.Size(132, 20);
            this.windowCheckBox.TabIndex = 14;
            this.windowCheckBox.Text = "Оконный режим";
            this.windowCheckBox.UseVisualStyleBackColor = true;
            // 
            // ip2TBox
            // 
            this.ip2TBox.Location = new System.Drawing.Point(310, 43);
            this.ip2TBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ip2TBox.Name = "ip2TBox";
            this.ip2TBox.Size = new System.Drawing.Size(58, 22);
            this.ip2TBox.TabIndex = 12;
            // 
            // ip1TBox
            // 
            this.ip1TBox.Location = new System.Drawing.Point(246, 43);
            this.ip1TBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ip1TBox.Name = "ip1TBox";
            this.ip1TBox.Size = new System.Drawing.Size(58, 22);
            this.ip1TBox.TabIndex = 10;
            this.ip1TBox.Value = new decimal(new int[] {
            127,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(300, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = ".";
            // 
            // ip3TBox
            // 
            this.ip3TBox.Location = new System.Drawing.Point(374, 43);
            this.ip3TBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ip3TBox.Name = "ip3TBox";
            this.ip3TBox.Size = new System.Drawing.Size(58, 22);
            this.ip3TBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(364, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = ".";
            // 
            // ip4TBox
            // 
            this.ip4TBox.Location = new System.Drawing.Point(438, 44);
            this.ip4TBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ip4TBox.Name = "ip4TBox";
            this.ip4TBox.Size = new System.Drawing.Size(58, 22);
            this.ip4TBox.TabIndex = 8;
            this.ip4TBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(428, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = ".";
            // 
            // streamTBox
            // 
            this.streamTBox.Location = new System.Drawing.Point(376, 72);
            this.streamTBox.Maximum = new decimal(new int[] {
            32768,
            0,
            0,
            0});
            this.streamTBox.Minimum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.streamTBox.Name = "streamTBox";
            this.streamTBox.Size = new System.Drawing.Size(120, 22);
            this.streamTBox.TabIndex = 6;
            this.streamTBox.Value = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP-Адрес";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размер потока получения данных: ";
            // 
            // portTBox
            // 
            this.portTBox.Location = new System.Drawing.Point(376, 16);
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
            this.portTBox.TabIndex = 7;
            this.portTBox.Value = new decimal(new int[] {
            11208,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Порт";
            // 
            // clientGBox
            // 
            this.clientGBox.Controls.Add(this.searchButton);
            this.clientGBox.Controls.Add(this.streamTBox);
            this.clientGBox.Controls.Add(this.ip2TBox);
            this.clientGBox.Controls.Add(this.label1);
            this.clientGBox.Controls.Add(this.ip1TBox);
            this.clientGBox.Controls.Add(this.label7);
            this.clientGBox.Controls.Add(this.directoryTBox);
            this.clientGBox.Controls.Add(this.portTBox);
            this.clientGBox.Controls.Add(this.label4);
            this.clientGBox.Controls.Add(this.ip3TBox);
            this.clientGBox.Controls.Add(this.label3);
            this.clientGBox.Controls.Add(this.label6);
            this.clientGBox.Controls.Add(this.ip4TBox);
            this.clientGBox.Controls.Add(this.label2);
            this.clientGBox.Controls.Add(this.label5);
            this.clientGBox.Location = new System.Drawing.Point(287, 75);
            this.clientGBox.Name = "clientGBox";
            this.clientGBox.Size = new System.Drawing.Size(510, 163);
            this.clientGBox.TabIndex = 9;
            this.clientGBox.TabStop = false;
            this.clientGBox.Text = "Настройки клиента";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(423, 127);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Обзор";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // directoryTBox
            // 
            this.directoryTBox.Enabled = false;
            this.directoryTBox.Location = new System.Drawing.Point(219, 99);
            this.directoryTBox.Name = "directoryTBox";
            this.directoryTBox.ReadOnly = true;
            this.directoryTBox.Size = new System.Drawing.Size(279, 22);
            this.directoryTBox.TabIndex = 1;
            this.directoryTBox.Text = "Не указан";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Стандартный путь сохранения";
            // 
            // AcceptButton
            // 
            this.AcceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptButton.Location = new System.Drawing.Point(591, 394);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(197, 44);
            this.AcceptButton.TabIndex = 10;
            this.AcceptButton.Text = "Применить";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.clientGBox);
            this.Controls.Add(this.serverGBox);
            this.Controls.Add(this.evaluationGBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Настройки";
            this.evaluationGBox.ResumeLayout(false);
            this.evaluationGBox.PerformLayout();
            this.serverGBox.ResumeLayout(false);
            this.serverGBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ip2TBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip1TBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip3TBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip4TBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streamTBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portTBox)).EndInit();
            this.clientGBox.ResumeLayout(false);
            this.clientGBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox evaluationGBox;
        private System.Windows.Forms.RadioButton MatLabRButton;
        private System.Windows.Forms.RadioButton ServerRButton;
        private System.Windows.Forms.RadioButton DLLRButton;
        private System.Windows.Forms.GroupBox serverGBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown streamTBox;
        private System.Windows.Forms.NumericUpDown portTBox;
        private System.Windows.Forms.GroupBox clientGBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox directoryTBox;
        private System.Windows.Forms.NumericUpDown ip4TBox;
        private System.Windows.Forms.NumericUpDown ip2TBox;
        private System.Windows.Forms.NumericUpDown ip1TBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown ip3TBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private new System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox windowCheckBox;
    }
}