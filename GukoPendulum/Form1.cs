using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GukoPendulum
{
    public partial class MainForm : Form
    {
        private const double G = 9.81;// Ускорение свободного падения
        private const double BaseLength = 1;// Длина по-умолчанию м
        private const double BaseMass = 0.2;// Масса по-умолчанию кг
        private const double BaseInitialVelocity = 0;// Начальная скорость падения по умолчанию м/с
        private const double BaseSpringConstant = 1000;// Коэфф жесткости по-умолчанию
        private const int BaseBallRadius = 20;
        private const int TopLimit = 0;
        private const double Sensitivity = 0.001; // Коэффициент чувствительности растягивания
        private const int UpdateInterval = 50; // Интервал обновления в миллисекундах

        private int time;
        private bool isStarted;
        private bool isStretching;
        private Point startPoint;
        private DateTime lastUpdateTime = DateTime.Now;
        private double springForce;
        private double dampingForce;

        private Pendulum pendulum;
        private Timer timer;

        private Material copper = new Material();
        private Material titan = new Material();
        private Material steel = new Material();

        Dictionary<string, Material> materials = new Dictionary<string, Material>();
        public MainForm()
        {
            InitializeComponent();
            InitializeUI();
        }
        private void InitializeUI()
        {
            InitializeTimer();
            InitializeChart();
            InitializePictureBox();
            InitializePendulum();
            InitializeNumeric();
            InitializeComboBox();
            InitializeMaterials();
        }
        private void InitializePendulum()
        {
            pendulum = new Pendulum()
            {
                RestLength = BaseLength,
                BallRadius = BaseBallRadius,
                Mass = BaseMass,
                InitialVelocity = BaseInitialVelocity,
                SpringConstant = BaseSpringConstant,
                NonlinearSpringFunction = (length) => BaseSpringConstant * length * length,
                Position = 1,
                MaxLoad = 5
            };
        }
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1;
            timer.Tick += Timer_Tick;
        }
        private void InitializePictureBox()
        {
            pendulumPictureBox.Invalidate();
            dampingForceLabel.Text = "Демпфирующая сила: " + Environment.NewLine + "--- Н";
        }
        private void InitializeChart()
        {
            chart.ChartAreas[0].AxisX.Minimum = 0;
            chart.ChartAreas[0].AxisY.Minimum = 0;
            chart.ChartAreas[0].AxisX.Title = "t";
            chart.ChartAreas[0].AxisY.Title = "V";
            chart.Series[0].Points.Add(0, 0);
        }
        private void InitializeNumeric()
        {
            numericUpDown1.Increment = 0.1M;
            numericUpDown1.Minimum = 0.1M;

            numericUpDown2.Increment = 0.01M;
            numericUpDown2.Minimum = 0.01M;
            numericUpDown2.Value = 0.2M;
        }
        private void InitializeComboBox()
        {
            comboBox.Items.Add("Медь");
            comboBox.Items.Add("Сталь");
            comboBox.Items.Add("Титан");

            comboBox.SelectedIndex = 0;
        }
        private void InitializeMaterials()
        {
            copper = new Material()
            {
                SpringConstant = 500,
                MaxLoad = 5
            };

            titan = new Material()
            {
                SpringConstant = 800,
                MaxLoad = 7
            };

            steel = new Material()
            {
                SpringConstant = 1200,
                MaxLoad = 10
            };

            materials.Add("Медь", copper);
            materials.Add("Титан", titan);
            materials.Add("Сталь", steel);
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            CalculateStretch();
            pendulumPictureBox.Invalidate();
            if(Math.Abs(pendulum.Velocity) > 0.1)
                UpdateChart();
            UpdateLabel();
        }
        private void CalculateStretch()
        {
            double timeStep = timer.Interval / 1000.0;

            if (pendulum.Mass * G >= pendulum.MaxLoad * G && pendulum.RestLength * 2 <= pendulum.Position)
            {
                SetStopBtn();
                MessageBox.Show("Пружина порвалась!");
                InitializePendulum();
                UpdateUI();
                return;
            }

            double displacement = pendulum.Position - pendulum.RestLength - pendulum.Length;
            springForce = -pendulum.SpringConstant * displacement;
            dampingForce = -pendulum.DampingCoefficient * pendulum.Velocity;
            pendulum.Acceleration = (springForce + dampingForce) / pendulum.Mass;

            pendulum.Velocity += pendulum.Acceleration * timeStep;
            pendulum.Position += pendulum.Velocity * timeStep;

            CheckCollisions();
        }
        private void CheckCollisions()
        {
            if (pendulum.Position < TopLimit)
            {
                pendulum.Position = TopLimit;
                pendulum.Velocity = -pendulum.Velocity * 0.9;
            }
        }
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int centerX = pendulumPictureBox.Width / 2;
            int centerY = pendulum.BallRadius;
            int pendulumY = centerY + (int)(pendulum.Position * 50);

            g.DrawLine(Pens.Blue, centerX - 20, 1, centerX + 20, 1);
            DrawPendulum(g, centerX, centerY, pendulumY);
            g.DrawRectangle(Pens.Black, 0, 0, pendulumPictureBox.Width - 1, pendulumPictureBox.Height - 1);
        }
        private void DrawPendulum(Graphics g, int centerX, int centerY, int pendulumY)
        {
            g.DrawLine(Pens.Black, centerX, 0, centerX, pendulumY);
            g.FillEllipse(Brushes.Black, centerX - pendulum.BallRadius, pendulumY - pendulum.BallRadius, 2 * pendulum.BallRadius, 2 * pendulum.BallRadius);
            g.FillEllipse(Brushes.Aqua, centerX - pendulum.BallRadius + 1, pendulumY - pendulum.BallRadius + 1, 2 * pendulum.BallRadius - 6, 2 * pendulum.BallRadius - 6);
        }
        private void DrawBrokenPendulum(Graphics g, int centerX, int centerY, int pendulumY) 
        {
            g.FillEllipse(Brushes.Black, centerX - pendulum.BallRadius, pendulumY - pendulum.BallRadius, 2 * pendulum.BallRadius, 2 * pendulum.BallRadius);
            g.FillEllipse(Brushes.Aqua, centerX - pendulum.BallRadius + 1, pendulumY - pendulum.BallRadius + 1, 2 * pendulum.BallRadius - 6, 2 * pendulum.BallRadius - 6);
        }
        private void UpdateChart()
        {
            chart.Series[0].Points.AddXY(time, Math.Abs(pendulum.Velocity));
        }
        private void UpdateLabel()
        {
            velocityLabel.Text = "Скорость: " + Math.Abs(Math.Round(pendulum.Velocity, 1)) + " м/с";
            lengthLabel.Text = "Растяжение: " + Math.Abs(Math.Round(pendulum.RestLength - pendulum.Position, 2)) + " м";
            dampingForceLabel.Text = "Демпфирующая сила: " + Environment.NewLine + Math.Abs(Math.Round(dampingForce, 1)) + " Н";
            springForceLabel.Text = "Сила сжатия: " + Environment.NewLine + Math.Abs(Math.Round(springForce, 1)) + " Н";
        }
        private void UpdateUI()
        {
            numericUpDown1.Value = (decimal)pendulum.RestLength;
            numericUpDown2.Value = (decimal)pendulum.Mass;
        }
        private void SetStartBtn()
        {
            startStopBtn.Text = "Стоп";
            timer.Start();
            isStarted = true;
        }
        private void SetStopBtn()
        {
            startStopBtn.Text = "Старт";
            timer.Stop();
            isStarted = false;
        }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isStretching = true;
                startPoint = e.Location;
            }
        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isStretching)
            {
                int deltaY = e.Y - startPoint.Y;
                pendulum.Position += deltaY * Sensitivity; // Изменение длины с учетом чувствительности

                // Проверка, прошло ли достаточно времени с момента последнего обновления
                if ((DateTime.Now - lastUpdateTime).TotalMilliseconds >= UpdateInterval)
                {
                    CalculateStretch();
                    pendulumPictureBox.Invalidate();
                    lastUpdateTime = DateTime.Now; // Обновление времени последнего обновления
                }
            }
        }
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (isStretching)
            {
                isStretching = false;
                int deltaY = e.Y - startPoint.Y;
                pendulum.Position += deltaY * Sensitivity; // Изменение длины с учетом чувствительности
                CalculateStretch();
                pendulumPictureBox.Invalidate();
            }
        }
        private void clearChartBtn_Click(object sender, EventArgs e)
        {
            chart.Series[0].Points.Clear();
            chart.Series[0].Points.Add(0, 0);
        }
        private void startStopBtn_Click(object sender, EventArgs e)
        {
            if (!isStarted)
                SetStartBtn();
            else
                SetStopBtn();
        }
        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;

            double value = Convert.ToDouble(numeric.Value);

            switch(numeric.Tag) 
            {
                case "0":
                    pendulum.RestLength = value;
                    break;
                case "1":
                    pendulum.Mass = value;
                    break;
            }
        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem != null)
            {
                string selectedMaterial = comboBox.SelectedItem.ToString();
                if (materials.ContainsKey(selectedMaterial))
                {
                    pendulum.SpringConstant = materials[selectedMaterial].SpringConstant;
                    pendulum.MaxLoad = materials[selectedMaterial].MaxLoad;

                    SpringConstantLabel.Text = "Коэфф жесткости пружины: " + materials[selectedMaterial].SpringConstant;
                    maxLoadLabel.Text = "Максимальная нагрузка пружины: " + materials[selectedMaterial].MaxLoad + "кг";
                }
            }
        }
        private void stopVelocityBtn_Click(object sender, EventArgs e)
        {
            pendulum.Position = pendulum.RestLength;
            pendulum.Velocity = 0;
        }
        private void stretchBtn_Click(object sender, EventArgs e)
        {
            pendulum.Position += Convert.ToDouble(numericUpDown3.Value);
            CalculateStretch();
            pendulumPictureBox.Invalidate();
        }
    }
}
