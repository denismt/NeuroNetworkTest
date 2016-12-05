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
using System.Threading;

namespace NeuroNetworkTest.CarTypes
{
    public partial class MainForm : Form
    {
        private decimal[][] testArray = new decimal[][]
        {
            new decimal[] {0.645m,33m,4m,0.34m,0 },//oka
            new decimal[] {2.880m,152m,14m,1.5m,1 },//passenger's gazel
            new decimal[] {1.110m,88m,5m,0.475m,0 },//lada kalina
            new decimal[] {10.400m,260m,3m,6m,2 },//kamaz
            new decimal[] {2.880m,152m,1m,1.5m,2 },//truck gazel
            new decimal[] {9.895m,122m,30m,6.2m,1 },//PAZ
            new decimal[] {3.695m,136m,3m,3m,2 },//ZIL
            new decimal[] {2.170m,116m,5m,0.6m,0 },//UAZ patriot
            new decimal[] {27.895m,278m,150m,11m,1 },//LIAZ
            //new decimal[] {1.370m,285m,2m,0.34m,0},//porshe
            new decimal[] {1.050m,115m,4m,0.43m,0},//mini kuper
            new decimal[] {11m,220m,50m,4m,1 },//ikarus
            new decimal[] {19,220,2,11,2 }//MAZ
        };
        private int testIterator;
        private Network _network;
        public MainForm()
        {
            InitializeComponent();
            testIterator = 0;
            _network= new Network(4, 3);
            this.ResultComboBox.Items.Add(new ComboBoxItem { Id = VehicleType.Car, Value = "Car" });
            this.ResultComboBox.Items.Add(new ComboBoxItem { Id = VehicleType.Passenger, Value = "Passenger's" });
            this.ResultComboBox.Items.Add(new ComboBoxItem { Id = VehicleType.Truck, Value = "Truck" });
            this.ResultComboBox.SelectedIndex = 0;
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                //NormalizedVehicleParameters parameters = new NormalizedVehicleParameters(decimal.Parse(this.WeightTextBox.Text), decimal.Parse(this.PowerTextBox.Text), decimal.Parse(this.CapacityTextBox.Text), decimal.Parse(this.CarryingTextBox.Text));
                NormalizedVehicleParameters parameters = new NormalizedVehicleParameters(testArray[testIterator][0], testArray[testIterator][1], testArray[testIterator][2], testArray[testIterator][3]);
                _network.Inputs[0] = parameters.Weight;
                _network.Inputs[1] = parameters.Power;
                _network.Inputs[2] = parameters.Capacity;
                _network.Inputs[3] = parameters.Carrying;
                //_network.Train((int)((ComboBoxItem)ResultComboBox.SelectedItem).Id-1);
                _network.Train((int)testArray[testIterator][4]);
                testIterator++;
                if (testIterator == 12)
                    testIterator = 0;
                //double time = 200;
                //ProcessOkLabel(TrainOkLabel, time);
                Thread.Sleep(40);
                DrawMap();
                //WeightTextBox.Clear();
                //PowerTextBox.Clear();
                //CapacityTextBox.Clear();
                //CarryingTextBox.Clear();
            }
            //Clear result information
            //CarResultLabel.Font = new Font("Microsoft Sans Serif", 8.25f);
            //PassengerResultLabel.Font = new Font("Microsoft Sans Serif", 8.25f);
            //TruckResultLabel.Font = new Font("Microsoft Sans Serif", 8.25f);
            //CarResultLabel.Text = "";
            //PassengerResultLabel.Text = "";
            //TruckResultLabel.Text = "";
            //CarPercentLabel.Text = "";
            //PassengerPercentLabel.Text = "";
            //TruckPercentLabel.Text = "";
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
                    if (lineWeight <= 0.75)
                        color = Color.Yellow;
                    else
                    if (lineWeight <= 1.5)
                        color = Color.LightGreen;
                    else
                        if (lineWeight <= 2.25)
                        color = Color.Green;
                    else
                        if (lineWeight <= 3)
                        color = Color.ForestGreen;
                    else
                        if (lineWeight <= 3.75)
                        color = Color.DarkOliveGreen;
                    else
                        color = Color.DarkSlateGray;
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
            if (resultType == VehicleType.Car)
                CarResultLabel.Font = new Font("Microsoft Sans Serif", 8.25f,FontStyle.Bold);
            else
                CarResultLabel.Font = new Font("Microsoft Sans Serif", 8.25f);

            if (resultType == VehicleType.Passenger)
                PassengerResultLabel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
            else
                PassengerResultLabel.Font = new Font("Microsoft Sans Serif", 8.25f);

            if (resultType == VehicleType.Truck)
                TruckResultLabel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
            else
                TruckResultLabel.Font = new Font("Microsoft Sans Serif", 8.25f);
            CarResultLabel.Text = "Car";
            PassengerResultLabel.Text = "Passenger's";
            TruckResultLabel.Text = "Truck";
            CarPercentLabel.Text = string.Format("{0:00.00}%", _network.Neurons[0].ActivationLevel);
            PassengerPercentLabel.Text = string.Format("{0:00.00}%", _network.Neurons[1].ActivationLevel);
            TruckPercentLabel.Text = string.Format("{0:00.00}%", _network.Neurons[2].ActivationLevel);
            TestLabel1.Text= string.Format("{0:00.00}", _network.Neurons[0].Output);
            TestLabel2.Text = string.Format("{0:00.00}", _network.Neurons[1].Output);
            TestLabel3.Text = string.Format("{0:00.00}", _network.Neurons[2].Output);
        }
    }
}
