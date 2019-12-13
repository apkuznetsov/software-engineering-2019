namespace GasStationMs.App
{
    partial class ModelingForm
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxFuelTank2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFuelTank1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCashCounter = new System.Windows.Forms.PictureBox();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.pictureBoxFuelDispenser2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFuelDispenser1 = new System.Windows.Forms.PictureBox();
            this.timerModeling = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxEnter = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.pictureBoxServiceArea = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFuelTank2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFuelTank1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCashCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFuelDispenser2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFuelDispenser1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxServiceArea)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFuelTank2
            // 
            this.pictureBoxFuelTank2.BackColor = System.Drawing.Color.Wheat;
            this.pictureBoxFuelTank2.Image = global::GasStationMs.App.Properties.Resources.FuelTank;
            this.pictureBoxFuelTank2.Location = new System.Drawing.Point(703, 240);
            this.pictureBoxFuelTank2.Name = "pictureBoxFuelTank2";
            this.pictureBoxFuelTank2.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxFuelTank2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFuelTank2.TabIndex = 1;
            this.pictureBoxFuelTank2.TabStop = false;
            // 
            // pictureBoxFuelTank1
            // 
            this.pictureBoxFuelTank1.BackColor = System.Drawing.Color.Wheat;
            this.pictureBoxFuelTank1.Image = global::GasStationMs.App.Properties.Resources.FuelTank;
            this.pictureBoxFuelTank1.Location = new System.Drawing.Point(703, 54);
            this.pictureBoxFuelTank1.Name = "pictureBoxFuelTank1";
            this.pictureBoxFuelTank1.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxFuelTank1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFuelTank1.TabIndex = 0;
            this.pictureBoxFuelTank1.TabStop = false;
            // 
            // pictureBoxCashCounter
            // 
            this.pictureBoxCashCounter.Image = global::GasStationMs.App.Properties.Resources.cashbox;
            this.pictureBoxCashCounter.Location = new System.Drawing.Point(30, 30);
            this.pictureBoxCashCounter.Name = "pictureBoxCashCounter";
            this.pictureBoxCashCounter.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxCashCounter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxCashCounter.TabIndex = 4;
            this.pictureBoxCashCounter.TabStop = false;
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.Image = global::GasStationMs.App.Properties.Resources.car_64x34_;
            this.pictureBoxCar.Location = new System.Drawing.Point(703, 429);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(64, 34);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxCar.TabIndex = 3;
            this.pictureBoxCar.TabStop = false;
            // 
            // pictureBoxFuelDispenser2
            // 
            this.pictureBoxFuelDispenser2.Image = global::GasStationMs.App.Properties.Resources.dispenser70;
            this.pictureBoxFuelDispenser2.Location = new System.Drawing.Point(234, 230);
            this.pictureBoxFuelDispenser2.Name = "pictureBoxFuelDispenser2";
            this.pictureBoxFuelDispenser2.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxFuelDispenser2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFuelDispenser2.TabIndex = 2;
            this.pictureBoxFuelDispenser2.TabStop = false;
            this.pictureBoxFuelDispenser2.Tag = "fuelDispenser";
            // 
            // pictureBoxFuelDispenser1
            // 
            this.pictureBoxFuelDispenser1.Image = global::GasStationMs.App.Properties.Resources.dispenser70;
            this.pictureBoxFuelDispenser1.Location = new System.Drawing.Point(234, 30);
            this.pictureBoxFuelDispenser1.Name = "pictureBoxFuelDispenser1";
            this.pictureBoxFuelDispenser1.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxFuelDispenser1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFuelDispenser1.TabIndex = 1;
            this.pictureBoxFuelDispenser1.TabStop = false;
            this.pictureBoxFuelDispenser1.Tag = "fuelDispenser";
            // 
            // timerModeling
            // 
            this.timerModeling.Enabled = true;
            this.timerModeling.Interval = 20;
            this.timerModeling.Tick += new System.EventHandler(this.TimerModeling_Tick);
            // 
            // pictureBoxEnter
            // 
            this.pictureBoxEnter.BackColor = System.Drawing.Color.LawnGreen;
            this.pictureBoxEnter.Location = new System.Drawing.Point(410, 362);
            this.pictureBoxEnter.Name = "pictureBoxEnter";
            this.pictureBoxEnter.Size = new System.Drawing.Size(92, 24);
            this.pictureBoxEnter.TabIndex = 5;
            this.pictureBoxEnter.TabStop = false;
            this.pictureBoxEnter.Tag = "enter";
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.BackColor = System.Drawing.Color.Coral;
            this.pictureBoxExit.Location = new System.Drawing.Point(52, 362);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(92, 24);
            this.pictureBoxExit.TabIndex = 6;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Tag = "exit";
            // 
            // pictureBoxServiceArea
            // 
            this.pictureBoxServiceArea.BackColor = System.Drawing.Color.Wheat;
            this.pictureBoxServiceArea.Location = new System.Drawing.Point(573, 0);
            this.pictureBoxServiceArea.Name = "pictureBoxServiceArea";
            this.pictureBoxServiceArea.Size = new System.Drawing.Size(228, 363);
            this.pictureBoxServiceArea.TabIndex = 7;
            this.pictureBoxServiceArea.TabStop = false;
            // 
            // ModelingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.pictureBoxFuelTank2);
            this.Controls.Add(this.pictureBoxExit);
            this.Controls.Add(this.pictureBoxFuelTank1);
            this.Controls.Add(this.pictureBoxEnter);
            this.Controls.Add(this.pictureBoxCashCounter);
            this.Controls.Add(this.pictureBoxCar);
            this.Controls.Add(this.pictureBoxFuelDispenser2);
            this.Controls.Add(this.pictureBoxFuelDispenser1);
            this.Controls.Add(this.pictureBoxServiceArea);
            this.Name = "ModelingForm";
            this.Text = "Modeling";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFuelTank2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFuelTank1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCashCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFuelDispenser2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFuelDispenser1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxServiceArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxFuelDispenser1;
        private System.Windows.Forms.PictureBox pictureBoxFuelDispenser2;
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.PictureBox pictureBoxCashCounter;
        private System.Windows.Forms.PictureBox pictureBoxFuelTank2;
        private System.Windows.Forms.PictureBox pictureBoxFuelTank1;
        private System.Windows.Forms.Timer timerModeling;
        private System.Windows.Forms.PictureBox pictureBoxEnter;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.PictureBox pictureBoxServiceArea;
    }
}