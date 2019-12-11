namespace GasStationMs.App
{
    partial class Modeling
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
            this.panelServiceArea = new System.Windows.Forms.Panel();
            this.pictureBoxFuelTank2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFuelTank1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCashCounter = new System.Windows.Forms.PictureBox();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.pictureBoxFuelDispenser2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFuelDispenser1 = new System.Windows.Forms.PictureBox();
            this.timerModeling = new System.Windows.Forms.Timer(this.components);
            this.panelServiceArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFuelTank2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFuelTank1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCashCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFuelDispenser2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFuelDispenser1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelServiceArea
            // 
            this.panelServiceArea.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelServiceArea.Controls.Add(this.pictureBoxFuelTank2);
            this.panelServiceArea.Controls.Add(this.pictureBoxFuelTank1);
            this.panelServiceArea.Location = new System.Drawing.Point(556, 0);
            this.panelServiceArea.Name = "panelServiceArea";
            this.panelServiceArea.Size = new System.Drawing.Size(245, 359);
            this.panelServiceArea.TabIndex = 0;
            // 
            // pictureBoxFuelTank2
            // 
            this.pictureBoxFuelTank2.Image = global::GasStationMs.App.Properties.Resources.FuelTank;
            this.pictureBoxFuelTank2.Location = new System.Drawing.Point(147, 218);
            this.pictureBoxFuelTank2.Name = "pictureBoxFuelTank2";
            this.pictureBoxFuelTank2.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxFuelTank2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFuelTank2.TabIndex = 1;
            this.pictureBoxFuelTank2.TabStop = false;
            // 
            // pictureBoxFuelTank1
            // 
            this.pictureBoxFuelTank1.Image = global::GasStationMs.App.Properties.Resources.FuelTank;
            this.pictureBoxFuelTank1.Location = new System.Drawing.Point(147, 60);
            this.pictureBoxFuelTank1.Name = "pictureBoxFuelTank1";
            this.pictureBoxFuelTank1.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxFuelTank1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFuelTank1.TabIndex = 0;
            this.pictureBoxFuelTank1.TabStop = false;
            // 
            // pictureBoxCashCounter
            // 
            this.pictureBoxCashCounter.Image = global::GasStationMs.App.Properties.Resources.cashbox;
            this.pictureBoxCashCounter.Location = new System.Drawing.Point(35, 46);
            this.pictureBoxCashCounter.Name = "pictureBoxCashCounter";
            this.pictureBoxCashCounter.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxCashCounter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxCashCounter.TabIndex = 4;
            this.pictureBoxCashCounter.TabStop = false;
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.Image = global::GasStationMs.App.Properties.Resources.car_64x34_;
            this.pictureBoxCar.Location = new System.Drawing.Point(641, 429);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(64, 34);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxCar.TabIndex = 3;
            this.pictureBoxCar.TabStop = false;
            // 
            // pictureBoxFuelDispenser2
            // 
            this.pictureBoxFuelDispenser2.Image = global::GasStationMs.App.Properties.Resources.dispenser70;
            this.pictureBoxFuelDispenser2.Location = new System.Drawing.Point(234, 274);
            this.pictureBoxFuelDispenser2.Name = "pictureBoxFuelDispenser2";
            this.pictureBoxFuelDispenser2.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxFuelDispenser2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFuelDispenser2.TabIndex = 2;
            this.pictureBoxFuelDispenser2.TabStop = false;
            // 
            // pictureBoxFuelDispenser1
            // 
            this.pictureBoxFuelDispenser1.Image = global::GasStationMs.App.Properties.Resources.dispenser70;
            this.pictureBoxFuelDispenser1.Location = new System.Drawing.Point(234, 124);
            this.pictureBoxFuelDispenser1.Name = "pictureBoxFuelDispenser1";
            this.pictureBoxFuelDispenser1.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxFuelDispenser1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFuelDispenser1.TabIndex = 1;
            this.pictureBoxFuelDispenser1.TabStop = false;
            // 
            // timerModeling
            // 
            this.timerModeling.Enabled = true;
            this.timerModeling.Interval = 20;
            this.timerModeling.Tick += new System.EventHandler(this.TimerModeling_Tick);
            // 
            // Modeling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.pictureBoxCashCounter);
            this.Controls.Add(this.pictureBoxCar);
            this.Controls.Add(this.pictureBoxFuelDispenser2);
            this.Controls.Add(this.pictureBoxFuelDispenser1);
            this.Controls.Add(this.panelServiceArea);
            this.Name = "Modeling";
            this.Text = "Modeling";
            this.panelServiceArea.ResumeLayout(false);
            this.panelServiceArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFuelTank2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFuelTank1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCashCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFuelDispenser2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFuelDispenser1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelServiceArea;
        private System.Windows.Forms.PictureBox pictureBoxFuelDispenser1;
        private System.Windows.Forms.PictureBox pictureBoxFuelDispenser2;
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.PictureBox pictureBoxCashCounter;
        private System.Windows.Forms.PictureBox pictureBoxFuelTank2;
        private System.Windows.Forms.PictureBox pictureBoxFuelTank1;
        private System.Windows.Forms.Timer timerModeling;
    }
}