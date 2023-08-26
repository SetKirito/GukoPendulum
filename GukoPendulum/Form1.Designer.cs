namespace GukoPendulum
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pendulumPictureBox = new System.Windows.Forms.PictureBox();
            this.startStopBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dampingForceLabel = new System.Windows.Forms.Label();
            this.springForceLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.velocityLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maxLoadLabel = new System.Windows.Forms.Label();
            this.SpringConstantLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clearChartBtn = new System.Windows.Forms.Button();
            this.stopVelocityBtn = new System.Windows.Forms.Button();
            this.stretchBtn = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pendulumPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // pendulumPictureBox
            // 
            this.pendulumPictureBox.Location = new System.Drawing.Point(659, 12);
            this.pendulumPictureBox.Name = "pendulumPictureBox";
            this.pendulumPictureBox.Size = new System.Drawing.Size(129, 568);
            this.pendulumPictureBox.TabIndex = 0;
            this.pendulumPictureBox.TabStop = false;
            this.pendulumPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pendulumPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pendulumPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pendulumPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // startStopBtn
            // 
            this.startStopBtn.Location = new System.Drawing.Point(6, 264);
            this.startStopBtn.Name = "startStopBtn";
            this.startStopBtn.Size = new System.Drawing.Size(182, 51);
            this.startStopBtn.TabIndex = 1;
            this.startStopBtn.Text = "Старт";
            this.startStopBtn.UseVisualStyleBackColor = true;
            this.startStopBtn.Click += new System.EventHandler(this.startStopBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dampingForceLabel);
            this.groupBox1.Controls.Add(this.springForceLabel);
            this.groupBox1.Controls.Add(this.lengthLabel);
            this.groupBox1.Controls.Add(this.velocityLabel);
            this.groupBox1.Location = new System.Drawing.Point(466, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 241);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Текущие показатели";
            // 
            // dampingForceLabel
            // 
            this.dampingForceLabel.AutoSize = true;
            this.dampingForceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dampingForceLabel.Location = new System.Drawing.Point(6, 123);
            this.dampingForceLabel.Name = "dampingForceLabel";
            this.dampingForceLabel.Size = new System.Drawing.Size(175, 16);
            this.dampingForceLabel.TabIndex = 3;
            this.dampingForceLabel.Text = "Демпфирующая сила: --- Н";
            // 
            // springForceLabel
            // 
            this.springForceLabel.AutoSize = true;
            this.springForceLabel.Location = new System.Drawing.Point(6, 92);
            this.springForceLabel.Name = "springForceLabel";
            this.springForceLabel.Size = new System.Drawing.Size(120, 16);
            this.springForceLabel.TabIndex = 2;
            this.springForceLabel.Text = "Сила сжатия: --- Н";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(6, 62);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(116, 16);
            this.lengthLabel.TabIndex = 1;
            this.lengthLabel.Text = "Растяжение: --- м";
            // 
            // velocityLabel
            // 
            this.velocityLabel.AutoSize = true;
            this.velocityLabel.Location = new System.Drawing.Point(6, 33);
            this.velocityLabel.Name = "velocityLabel";
            this.velocityLabel.Size = new System.Drawing.Size(109, 16);
            this.velocityLabel.TabIndex = 0;
            this.velocityLabel.Text = "Скорость: --- м/с";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maxLoadLabel);
            this.groupBox2.Controls.Add(this.SpringConstantLabel);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Location = new System.Drawing.Point(345, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 321);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Хар-ки";
            // 
            // maxLoadLabel
            // 
            this.maxLoadLabel.AutoSize = true;
            this.maxLoadLabel.Location = new System.Drawing.Point(6, 207);
            this.maxLoadLabel.Name = "maxLoadLabel";
            this.maxLoadLabel.Size = new System.Drawing.Size(257, 16);
            this.maxLoadLabel.TabIndex = 8;
            this.maxLoadLabel.Text = "Максимальная нагрузка пружины: 5кг ";
            // 
            // SpringConstantLabel
            // 
            this.SpringConstantLabel.AutoSize = true;
            this.SpringConstantLabel.Location = new System.Drawing.Point(6, 177);
            this.SpringConstantLabel.Name = "SpringConstantLabel";
            this.SpringConstantLabel.Size = new System.Drawing.Size(212, 16);
            this.SpringConstantLabel.TabIndex = 7;
            this.SpringConstantLabel.Text = "Коэфф жесткости пружины: 500";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Диаметр проволоки пружины: 5мм";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(5, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Материал пружины";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(180, 110);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(122, 24);
            this.comboBox.TabIndex = 4;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Масса грузика кг";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Длина пружины м";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Location = new System.Drawing.Point(242, 49);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(60, 22);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.Tag = "1";
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Location = new System.Drawing.Point(242, 21);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 22);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Tag = "0";
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(12, 12);
            this.chart.Name = "chart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "V";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(448, 241);
            this.chart.TabIndex = 4;
            this.chart.Text = "chart";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDown3);
            this.groupBox3.Controls.Add(this.stretchBtn);
            this.groupBox3.Controls.Add(this.stopVelocityBtn);
            this.groupBox3.Controls.Add(this.clearChartBtn);
            this.groupBox3.Controls.Add(this.startStopBtn);
            this.groupBox3.Location = new System.Drawing.Point(12, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 321);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Панель управления";
            // 
            // clearChartBtn
            // 
            this.clearChartBtn.Location = new System.Drawing.Point(6, 207);
            this.clearChartBtn.Name = "clearChartBtn";
            this.clearChartBtn.Size = new System.Drawing.Size(182, 51);
            this.clearChartBtn.TabIndex = 2;
            this.clearChartBtn.Text = "Очистить график";
            this.clearChartBtn.UseVisualStyleBackColor = true;
            this.clearChartBtn.Click += new System.EventHandler(this.clearChartBtn_Click);
            // 
            // stopVelocityBtn
            // 
            this.stopVelocityBtn.Location = new System.Drawing.Point(6, 150);
            this.stopVelocityBtn.Name = "stopVelocityBtn";
            this.stopVelocityBtn.Size = new System.Drawing.Size(182, 51);
            this.stopVelocityBtn.TabIndex = 3;
            this.stopVelocityBtn.Text = "Остановить маятник";
            this.stopVelocityBtn.UseVisualStyleBackColor = true;
            this.stopVelocityBtn.Click += new System.EventHandler(this.stopVelocityBtn_Click);
            // 
            // stretchBtn
            // 
            this.stretchBtn.Location = new System.Drawing.Point(6, 96);
            this.stretchBtn.Name = "stretchBtn";
            this.stretchBtn.Size = new System.Drawing.Size(114, 48);
            this.stretchBtn.TabIndex = 4;
            this.stretchBtn.Text = "Растянуть на";
            this.stretchBtn.UseVisualStyleBackColor = true;
            this.stretchBtn.Click += new System.EventHandler(this.stretchBtn_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(126, 110);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(62, 22);
            this.numericUpDown3.TabIndex = 5;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 592);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pendulumPictureBox);
            this.Name = "MainForm";
            this.Text = "Маятник Гука";
            ((System.ComponentModel.ISupportInitialize)(this.pendulumPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pendulumPictureBox;
        private System.Windows.Forms.Button startStopBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label velocityLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearChartBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label springForceLabel;
        private System.Windows.Forms.Label dampingForceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SpringConstantLabel;
        private System.Windows.Forms.Label maxLoadLabel;
        private System.Windows.Forms.Button stopVelocityBtn;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Button stretchBtn;
    }
}

