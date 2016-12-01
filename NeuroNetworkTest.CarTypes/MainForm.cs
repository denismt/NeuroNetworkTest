using NeuroNetworkTest.CarTypes.Constants;
using NeuroNetworkTest.CarTypes.Controls;
using NeuroNetworkTest.CarTypes.Models;
using NeuroNetworkTest.NeuroNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace NeuroNetworkTest.CarTypes
{
    public partial class MainForm : Form
    {

        private Network _network;
        public MainForm()
        {
            InitializeComponent();
            _network= new Network(4, 3);
            this.ResultComboBox.Items.Add(new ComboBoxItem { Id = VehicleType.Car, Value = "Car" });
            this.ResultComboBox.Items.Add(new ComboBoxItem { Id = VehicleType.Passenger, Value = "Passenger's" });
            this.ResultComboBox.Items.Add(new ComboBoxItem { Id = VehicleType.Truck, Value = "Truck" });
            this.ResultComboBox.SelectedIndex = 0;
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            NormalizedVehicleParameters parameters = new NormalizedVehicleParameters(decimal.Parse(this.WeightTextBox.Text), decimal.Parse(this.PowerTextBox.Text), decimal.Parse(this.CapacityTextBox.Text), decimal.Parse(this.CarryingTextBox.Text));
            _network.Inputs[0] = parameters.Weight;
            _network.Inputs[1] = parameters.Power;
            _network.Inputs[2] = parameters.Capacity;
            _network.Inputs[3] = parameters.Carrying;
            _network.Train((int)((ComboBoxItem)ResultComboBox.SelectedItem).Id-1);
            double time = 200;
            ProcessOkLabel(TrainOkLabel,time);
            DrawMap();
            WeightTextBox.Clear();
            PowerTextBox.Clear();
            CapacityTextBox.Clear();
            CarryingTextBox.Clear();
        }

        public void ProcessOkLabel(Label label, double time)
        {
            label.Visible = label.Visible? false :true;
            System.Timers.Timer timer = new System.Timers.Timer(time);
            timer.SynchronizingObject = this;
            timer.Elapsed += delegate {
                timer.Stop();
                if (time > 25)
                {
                    time = time - 25;
                    ProcessOkLabel(label,time);
                }
            };
            timer.Start();
        }

        private void TrainWeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                //e.Handled = true;
        }

        private void TrainPowerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                //e.Handled = true;
        }

        private void TrainCapacityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                //e.Handled = true;
        }

        private void TrainCarruingTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                //e.Handled = true;
        }

        private void DrawMap()
        {
            Graphics graphics = MapPanel.CreateGraphics();
            graphics.Clear(MapPanel.BackColor);
            float x = 120;
            float y = 265 / (_network.Inputs.Length+1); 
            for (int i=0;i< _network.Inputs.Length;i++)
            {
                graphics.DrawEllipse(new Pen(Color.Blue,2), x-5, y-5,10,10);
                float x2 = 460;
                float y2 = 265 / (_network.Neurons.Length + 1);
                for (int j=0;j<_network.Neurons.Length;j++)
                {
                    float lineWeight = Convert.ToSingle(_network.Neurons[j].Weigts[i] * 4);
                    Color color = Color.LightGreen;
                    if (lineWeight <= 0.5)
                        color = Color.LightYellow;
                    else
                    if (lineWeight <= 1)
                        color = Color.Yellow;
                    else
                        if (lineWeight <= 1.5)
                        color = Color.LightGreen;
                    else
                        if (lineWeight <= 2)
                        color = Color.Green;
                    else
                        if (lineWeight <= 2.5)
                        color = Color.ForestGreen;
                    else
                        color = Color.Black;
                    graphics.DrawLine(new Pen(color, lineWeight), x+5, y, x2-10, y2);
                    graphics.DrawEllipse(new Pen(Color.Orange, 2), x2-10, y2-10, 20, 20);
                    y2 += 265 / (_network.Inputs.Length + 1);
                }
                y += 265 / (_network.Inputs.Length + 1);
            }
        }

        private void MapPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawMap();
        }

        private void DefineButton_Click(object sender, EventArgs e)
        {
            NormalizedVehicleParameters parameters = new NormalizedVehicleParameters(decimal.Parse(this.WeightTextBox.Text), decimal.Parse(this.PowerTextBox.Text), decimal.Parse(this.CapacityTextBox.Text), decimal.Parse(this.CarryingTextBox.Text));
            _network.Inputs[0] = parameters.Weight;
            _network.Inputs[1] = parameters.Power;
            _network.Inputs[2] = parameters.Capacity;
            _network.Inputs[3] = parameters.Carrying;
            VehicleType resultType = (VehicleType)_network.GetResult()+1;
            double time = 200;
            ProcessOkLabel(DefineOkLabel,time);
            DrawMap();
            ResultLabel.Text = resultType.ToString();
        }
    }
}
