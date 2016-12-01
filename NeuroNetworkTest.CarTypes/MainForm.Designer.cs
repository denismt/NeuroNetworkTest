namespace NeuroNetworkTest.CarTypes
{
    partial class MainForm
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
            this.DataBox = new System.Windows.Forms.GroupBox();
            this.ResultComboBox = new System.Windows.Forms.ComboBox();
            this.TrainOkLabel = new System.Windows.Forms.Label();
            this.TrainButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CarryingTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CapacityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PowerTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.GroupBox();
            this.MapBox = new System.Windows.Forms.GroupBox();
            this.MapPanel = new System.Windows.Forms.Panel();
            this.DefineButton = new System.Windows.Forms.Button();
            this.DefineOkLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.DataBox.SuspendLayout();
            this.ResultBox.SuspendLayout();
            this.MapBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataBox
            // 
            this.DataBox.Controls.Add(this.DefineOkLabel);
            this.DataBox.Controls.Add(this.DefineButton);
            this.DataBox.Controls.Add(this.ResultComboBox);
            this.DataBox.Controls.Add(this.TrainOkLabel);
            this.DataBox.Controls.Add(this.TrainButton);
            this.DataBox.Controls.Add(this.label5);
            this.DataBox.Controls.Add(this.CarryingTextBox);
            this.DataBox.Controls.Add(this.label4);
            this.DataBox.Controls.Add(this.CapacityTextBox);
            this.DataBox.Controls.Add(this.label3);
            this.DataBox.Controls.Add(this.PowerTextBox);
            this.DataBox.Controls.Add(this.label2);
            this.DataBox.Controls.Add(this.WeightTextBox);
            this.DataBox.Controls.Add(this.label1);
            this.DataBox.Location = new System.Drawing.Point(10, 315);
            this.DataBox.Name = "DataBox";
            this.DataBox.Size = new System.Drawing.Size(300, 330);
            this.DataBox.TabIndex = 0;
            this.DataBox.TabStop = false;
            this.DataBox.Text = "Train";
            // 
            // ResultComboBox
            // 
            this.ResultComboBox.FormattingEnabled = true;
            this.ResultComboBox.Location = new System.Drawing.Point(76, 189);
            this.ResultComboBox.Name = "ResultComboBox";
            this.ResultComboBox.Size = new System.Drawing.Size(193, 21);
            this.ResultComboBox.TabIndex = 12;
            // 
            // TrainOkLabel
            // 
            this.TrainOkLabel.AutoSize = true;
            this.TrainOkLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.TrainOkLabel.Location = new System.Drawing.Point(114, 230);
            this.TrainOkLabel.Name = "TrainOkLabel";
            this.TrainOkLabel.Size = new System.Drawing.Size(22, 13);
            this.TrainOkLabel.TabIndex = 11;
            this.TrainOkLabel.Text = "OK";
            this.TrainOkLabel.Visible = false;
            // 
            // TrainButton
            // 
            this.TrainButton.Location = new System.Drawing.Point(88, 246);
            this.TrainButton.Name = "TrainButton";
            this.TrainButton.Size = new System.Drawing.Size(75, 23);
            this.TrainButton.TabIndex = 10;
            this.TrainButton.Text = "Train";
            this.TrainButton.UseVisualStyleBackColor = true;
            this.TrainButton.Click += new System.EventHandler(this.TrainButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Result";
            // 
            // CarryingTextBox
            // 
            this.CarryingTextBox.Location = new System.Drawing.Point(76, 137);
            this.CarryingTextBox.Name = "CarryingTextBox";
            this.CarryingTextBox.Size = new System.Drawing.Size(193, 20);
            this.CarryingTextBox.TabIndex = 7;
            this.CarryingTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TrainCarruingTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Carrying";
            // 
            // CapacityTextBox
            // 
            this.CapacityTextBox.Location = new System.Drawing.Point(76, 102);
            this.CapacityTextBox.Name = "CapacityTextBox";
            this.CapacityTextBox.Size = new System.Drawing.Size(193, 20);
            this.CapacityTextBox.TabIndex = 5;
            this.CapacityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TrainCapacityTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Capacity";
            // 
            // PowerTextBox
            // 
            this.PowerTextBox.Location = new System.Drawing.Point(76, 65);
            this.PowerTextBox.Name = "PowerTextBox";
            this.PowerTextBox.Size = new System.Drawing.Size(193, 20);
            this.PowerTextBox.TabIndex = 3;
            this.PowerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TrainPowerTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Power";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(76, 30);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(193, 20);
            this.WeightTextBox.TabIndex = 1;
            this.WeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TrainWeightTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weight";
            // 
            // ResultBox
            // 
            this.ResultBox.Controls.Add(this.ResultLabel);
            this.ResultBox.Location = new System.Drawing.Point(320, 315);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(300, 330);
            this.ResultBox.TabIndex = 1;
            this.ResultBox.TabStop = false;
            this.ResultBox.Text = "Result";
            // 
            // MapBox
            // 
            this.MapBox.Controls.Add(this.MapPanel);
            this.MapBox.Location = new System.Drawing.Point(10, 6);
            this.MapBox.Name = "MapBox";
            this.MapBox.Size = new System.Drawing.Size(610, 300);
            this.MapBox.TabIndex = 2;
            this.MapBox.TabStop = false;
            this.MapBox.Text = "Map";
            // 
            // MapPanel
            // 
            this.MapPanel.Location = new System.Drawing.Point(10, 20);
            this.MapPanel.Name = "MapPanel";
            this.MapPanel.Size = new System.Drawing.Size(590, 265);
            this.MapPanel.TabIndex = 0;
            this.MapPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MapPanel_Paint);
            // 
            // DefineButton
            // 
            this.DefineButton.Location = new System.Drawing.Point(173, 246);
            this.DefineButton.Name = "DefineButton";
            this.DefineButton.Size = new System.Drawing.Size(75, 23);
            this.DefineButton.TabIndex = 13;
            this.DefineButton.Text = "Define";
            this.DefineButton.UseVisualStyleBackColor = true;
            this.DefineButton.Click += new System.EventHandler(this.DefineButton_Click);
            // 
            // DefineOkLabel
            // 
            this.DefineOkLabel.AutoSize = true;
            this.DefineOkLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.DefineOkLabel.Location = new System.Drawing.Point(199, 230);
            this.DefineOkLabel.Name = "DefineOkLabel";
            this.DefineOkLabel.Size = new System.Drawing.Size(22, 13);
            this.DefineOkLabel.TabIndex = 14;
            this.DefineOkLabel.Text = "OK";
            this.DefineOkLabel.Visible = false;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.Location = new System.Drawing.Point(35, 49);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 20);
            this.ResultLabel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 656);
            this.Controls.Add(this.MapBox);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.DataBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Types";
            this.DataBox.ResumeLayout(false);
            this.DataBox.PerformLayout();
            this.ResultBox.ResumeLayout(false);
            this.ResultBox.PerformLayout();
            this.MapBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DataBox;
        private System.Windows.Forms.GroupBox ResultBox;
        private System.Windows.Forms.Label TrainOkLabel;
        private System.Windows.Forms.Button TrainButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CarryingTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CapacityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PowerTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ResultComboBox;
        private System.Windows.Forms.GroupBox MapBox;
        private System.Windows.Forms.Panel MapPanel;
        private System.Windows.Forms.Button DefineButton;
        private System.Windows.Forms.Label DefineOkLabel;
        private System.Windows.Forms.Label ResultLabel;
    }
}

