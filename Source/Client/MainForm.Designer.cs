namespace Client
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SolveButton = new System.Windows.Forms.Button();
            this.t0TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.y0TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tfTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hTextBox = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.eqTextBox = new System.Windows.Forms.TextBox();
            this.errlabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортВWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запуститьСерверToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.серверToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SolveButton
            // 
            this.SolveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SolveButton.Location = new System.Drawing.Point(487, 639);
            this.SolveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SolveButton.Name = "SolveButton";
            this.SolveButton.Size = new System.Drawing.Size(223, 55);
            this.SolveButton.TabIndex = 0;
            this.SolveButton.Text = "Вычислить";
            this.SolveButton.UseVisualStyleBackColor = true;
            this.SolveButton.Click += new System.EventHandler(this.SolveButton_Click);
            // 
            // t0TextBox
            // 
            this.t0TextBox.Location = new System.Drawing.Point(250, 109);
            this.t0TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.t0TextBox.Name = "t0TextBox";
            this.t0TextBox.Size = new System.Drawing.Size(100, 22);
            this.t0TextBox.TabIndex = 1;
            this.t0TextBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = " Начальное условие x0 = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Начальное условие y0 = ";
            // 
            // y0TextBox
            // 
            this.y0TextBox.Location = new System.Drawing.Point(250, 135);
            this.y0TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.y0TextBox.Name = "y0TextBox";
            this.y0TextBox.Size = new System.Drawing.Size(100, 22);
            this.y0TextBox.TabIndex = 3;
            this.y0TextBox.Text = "0,5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Конечное время tf =";
            // 
            // tfTextBox
            // 
            this.tfTextBox.Location = new System.Drawing.Point(250, 187);
            this.tfTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tfTextBox.Name = "tfTextBox";
            this.tfTextBox.Size = new System.Drawing.Size(100, 22);
            this.tfTextBox.TabIndex = 7;
            this.tfTextBox.Text = "0,5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Шаг h = ";
            // 
            // hTextBox
            // 
            this.hTextBox.Location = new System.Drawing.Point(250, 161);
            this.hTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hTextBox.Name = "hTextBox";
            this.hTextBox.Size = new System.Drawing.Size(100, 22);
            this.hTextBox.TabIndex = 5;
            this.hTextBox.Text = "0,1";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.Location = new System.Drawing.Point(492, 601);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(172, 25);
            this.ResultLabel.TabIndex = 9;
            this.ResultLabel.Text = "Результат: Y = ";
            // 
            // mainChart
            // 
            this.mainChart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.mainChart.Legends.Add(legend1);
            this.mainChart.Location = new System.Drawing.Point(430, 71);
            this.mainChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainChart.Name = "mainChart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.DodgerBlue;
            series1.LabelBorderWidth = 5;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Blue;
            series1.MarkerBorderWidth = 2;
            series1.MarkerColor = System.Drawing.Color.Blue;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series1.Name = "График ДУ";
            this.mainChart.Series.Add(series1);
            this.mainChart.Size = new System.Drawing.Size(785, 528);
            this.mainChart.TabIndex = 10;
            this.mainChart.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.y});
            this.dataGridView1.Location = new System.Drawing.Point(16, 219);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(324, 473);
            this.dataGridView1.TabIndex = 11;
            // 
            // x
            // 
            this.x.HeaderText = "X";
            this.x.MinimumWidth = 6;
            this.x.Name = "x";
            this.x.Width = 125;
            // 
            // y
            // 
            this.y.HeaderText = "Y";
            this.y.MinimumWidth = 6;
            this.y.Name = "y";
            this.y.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Дифференциальное уравнение y\' = ";
            // 
            // eqTextBox
            // 
            this.eqTextBox.Location = new System.Drawing.Point(250, 82);
            this.eqTextBox.Name = "eqTextBox";
            this.eqTextBox.Size = new System.Drawing.Size(153, 22);
            this.eqTextBox.TabIndex = 13;
            this.eqTextBox.Text = "y - x * x + 1";
            // 
            // errlabel
            // 
            this.errlabel.AutoSize = true;
            this.errlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errlabel.ForeColor = System.Drawing.Color.Red;
            this.errlabel.Location = new System.Drawing.Point(858, 674);
            this.errlabel.Name = "errlabel";
            this.errlabel.Size = new System.Drawing.Size(283, 22);
            this.errlabel.TabIndex = 14;
            this.errlabel.Text = "Ошибка соединения с сервером";
            this.errlabel.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.экспортStripMenuItem1,
            this.опцииToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1227, 30);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьКакToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьКакToolStripMenuItem
            // 
            this.открытьКакToolStripMenuItem.Name = "открытьКакToolStripMenuItem";
            this.открытьКакToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.открытьКакToolStripMenuItem.Text = "Открыть";
            this.открытьКакToolStripMenuItem.Click += new System.EventHandler(this.открытьКакToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // экспортStripMenuItem1
            // 
            this.экспортStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.экспортВExcelToolStripMenuItem,
            this.экспортВWordToolStripMenuItem});
            this.экспортStripMenuItem1.Name = "экспортStripMenuItem1";
            this.экспортStripMenuItem1.Size = new System.Drawing.Size(79, 26);
            this.экспортStripMenuItem1.Text = "Экспорт";
            // 
            // экспортВExcelToolStripMenuItem
            // 
            this.экспортВExcelToolStripMenuItem.Name = "экспортВExcelToolStripMenuItem";
            this.экспортВExcelToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.экспортВExcelToolStripMenuItem.Text = "Экспорт в Excel";
            this.экспортВExcelToolStripMenuItem.Click += new System.EventHandler(this.экспортВExcelToolStripMenuItem_Click);
            // 
            // экспортВWordToolStripMenuItem
            // 
            this.экспортВWordToolStripMenuItem.Name = "экспортВWordToolStripMenuItem";
            this.экспортВWordToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.экспортВWordToolStripMenuItem.Text = "Экспорт в Word";
            this.экспортВWordToolStripMenuItem.Click += new System.EventHandler(this.экспортВWordToolStripMenuItem_Click);
            // 
            // опцииToolStripMenuItem
            // 
            this.опцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.запуститьСерверToolStripMenuItem});
            this.опцииToolStripMenuItem.Name = "опцииToolStripMenuItem";
            this.опцииToolStripMenuItem.Size = new System.Drawing.Size(70, 26);
            this.опцииToolStripMenuItem.Text = "Опции";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // запуститьСерверToolStripMenuItem
            // 
            this.запуститьСерверToolStripMenuItem.Name = "запуститьСерверToolStripMenuItem";
            this.запуститьСерверToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.запуститьСерверToolStripMenuItem.Text = "Запустить сервер";
            this.запуститьСерверToolStripMenuItem.Click += new System.EventHandler(this.запуститьСерверToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.обАвтореToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.оПрограммеToolStripMenuItem.Text = "О Программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.обАвтореToolStripMenuItem.Text = "Об Авторе";
            this.обАвтореToolStripMenuItem.Click += new System.EventHandler(this.обАвтореToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem1,
            this.wordToolStripMenuItem,
            this.excelToolStripMenuItem,
            this.серверToolStripMenuItem,
            this.настройкиToolStripMenuItem1,
            this.справкаToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 30);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1227, 30);
            this.menuStrip2.TabIndex = 17;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Image = global::Client.Properties.Resources.free_icon_open_file_48474431;
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(34, 26);
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem1
            // 
            this.сохранитьToolStripMenuItem1.Image = global::Client.Properties.Resources.free_icon_save_25502211;
            this.сохранитьToolStripMenuItem1.Name = "сохранитьToolStripMenuItem1";
            this.сохранитьToolStripMenuItem1.Size = new System.Drawing.Size(34, 26);
            this.сохранитьToolStripMenuItem1.Click += new System.EventHandler(this.сохранитьToolStripMenuItem1_Click);
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.Image = global::Client.Properties.Resources.free_icon_doc_file_format_37201412;
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(34, 26);
            this.wordToolStripMenuItem.Click += new System.EventHandler(this.wordToolStripMenuItem_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Image = global::Client.Properties.Resources.free_icon_microsoft_excel_file_82492381;
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(34, 26);
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // серверToolStripMenuItem
            // 
            this.серверToolStripMenuItem.Image = global::Client.Properties.Resources.free_icon_servers_6223971;
            this.серверToolStripMenuItem.Name = "серверToolStripMenuItem";
            this.серверToolStripMenuItem.Size = new System.Drawing.Size(34, 26);
            this.серверToolStripMenuItem.Click += new System.EventHandler(this.серверToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem1
            // 
            this.настройкиToolStripMenuItem1.Image = global::Client.Properties.Resources.free_icon_settings_1264721;
            this.настройкиToolStripMenuItem1.Name = "настройкиToolStripMenuItem1";
            this.настройкиToolStripMenuItem1.Size = new System.Drawing.Size(34, 26);
            this.настройкиToolStripMenuItem1.Click += new System.EventHandler(this.настройкиToolStripMenuItem1_Click);
            // 
            // справкаToolStripMenuItem1
            // 
            this.справкаToolStripMenuItem1.Image = global::Client.Properties.Resources.free_icon_credit_103489821;
            this.справкаToolStripMenuItem1.Name = "справкаToolStripMenuItem1";
            this.справкаToolStripMenuItem1.Size = new System.Drawing.Size(34, 26);
            this.справкаToolStripMenuItem1.Click += new System.EventHandler(this.справкаToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1227, 705);
            this.Controls.Add(this.errlabel);
            this.Controls.Add(this.eqTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mainChart);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tfTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.y0TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t0TextBox);
            this.Controls.Add(this.SolveButton);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MarePlotter";
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SolveButton;
        private System.Windows.Forms.TextBox t0TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox y0TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tfTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hTextBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox eqTextBox;
        private System.Windows.Forms.Label errlabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem опцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запуститьСерверToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem серверToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem экспортStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem экспортВExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортВWordToolStripMenuItem;
    }
}

