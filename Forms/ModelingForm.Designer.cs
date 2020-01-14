using GasStationMs.App.Modeling;

namespace GasStationMs.App.Forms
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
            this.timerModeling = new System.Windows.Forms.Timer(this.components);
            this.panelModelingInformation = new System.Windows.Forms.Panel();
            this.labelLitres2 = new System.Windows.Forms.Label();
            this.labelLitres1 = new System.Windows.Forms.Label();
            this.labelCurrentFullnessValue = new System.Windows.Forms.Label();
            this.labelVolumeValue = new System.Windows.Forms.Label();
            this.labelFuelValue = new System.Windows.Forms.Label();
            this.labelCurrentFullness = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelFuel = new System.Windows.Forms.Label();
            this.labelFuelTank = new System.Windows.Forms.Label();
            this.labelLitersPerMinute = new System.Windows.Forms.Label();
            this.labelSpeedOfFillingValue = new System.Windows.Forms.Label();
            this.labelSpeedOfFilling = new System.Windows.Forms.Label();
            this.labelFuelDispenser = new System.Windows.Forms.Label();
            this.labelSelectedElement = new System.Windows.Forms.Label();
            this.labelRubles1 = new System.Windows.Forms.Label();
            this.labelRubles2 = new System.Windows.Forms.Label();
            this.labelCashCounterLimitValue = new System.Windows.Forms.Label();
            this.labelCashCounterSumValue = new System.Windows.Forms.Label();
            this.labelCashCounterLimit = new System.Windows.Forms.Label();
            this.labelCashCounterSum = new System.Windows.Forms.Label();
            this.labelCashCounter = new System.Windows.Forms.Label();
            this.labelModelState = new System.Windows.Forms.Label();
            this.textBoxSelectedItemInformation = new System.Windows.Forms.TextBox();
            this.panelPlayground = new System.Windows.Forms.Panel();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnter = new System.Windows.Forms.PictureBox();
            this.pictureBoxFuelTank1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFuelTank2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFuelDispenser2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.pictureBoxServiceArea = new System.Windows.Forms.PictureBox();
            this.pictureBoxFuelDispenser1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCashCounter = new System.Windows.Forms.PictureBox();
            this.panelTimeManagment = new System.Windows.Forms.Panel();
            this.pictureBoxPauseAndPlay = new System.Windows.Forms.PictureBox();
            this.labelTotalTimeValue = new System.Windows.Forms.Label();
            this.labelTotalTime = new System.Windows.Forms.Label();
            this.panelModelingInformation.SuspendLayout();
            this.panelPlayground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFuelTank1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFuelTank2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFuelDispenser2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxServiceArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFuelDispenser1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCashCounter)).BeginInit();
            this.panelTimeManagment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPauseAndPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // timerModeling
            // 
            this.timerModeling.Enabled = true;
            this.timerModeling.Interval = 20;
            this.timerModeling.Tick += new System.EventHandler(this.TimerModeling_Tick);
            // 
            // panelModelingInformation
            // 
            this.panelModelingInformation.BackColor = System.Drawing.SystemColors.Window;
            this.panelModelingInformation.Controls.Add(this.labelLitres2);
            this.panelModelingInformation.Controls.Add(this.labelLitres1);
            this.panelModelingInformation.Controls.Add(this.labelCurrentFullnessValue);
            this.panelModelingInformation.Controls.Add(this.labelVolumeValue);
            this.panelModelingInformation.Controls.Add(this.labelFuelValue);
            this.panelModelingInformation.Controls.Add(this.labelCurrentFullness);
            this.panelModelingInformation.Controls.Add(this.labelVolume);
            this.panelModelingInformation.Controls.Add(this.labelFuel);
            this.panelModelingInformation.Controls.Add(this.labelFuelTank);
            this.panelModelingInformation.Controls.Add(this.labelLitersPerMinute);
            this.panelModelingInformation.Controls.Add(this.labelSpeedOfFillingValue);
            this.panelModelingInformation.Controls.Add(this.labelSpeedOfFilling);
            this.panelModelingInformation.Controls.Add(this.labelFuelDispenser);
            this.panelModelingInformation.Controls.Add(this.labelSelectedElement);
            this.panelModelingInformation.Controls.Add(this.labelRubles1);
            this.panelModelingInformation.Controls.Add(this.labelRubles2);
            this.panelModelingInformation.Controls.Add(this.labelCashCounterLimitValue);
            this.panelModelingInformation.Controls.Add(this.labelCashCounterSumValue);
            this.panelModelingInformation.Controls.Add(this.labelCashCounterLimit);
            this.panelModelingInformation.Controls.Add(this.labelCashCounterSum);
            this.panelModelingInformation.Controls.Add(this.labelCashCounter);
            this.panelModelingInformation.Controls.Add(this.labelModelState);
            this.panelModelingInformation.Controls.Add(this.textBoxSelectedItemInformation);
            this.panelModelingInformation.Location = new System.Drawing.Point(1179, 2);
            this.panelModelingInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelModelingInformation.Name = "panelModelingInformation";
            this.panelModelingInformation.Size = new System.Drawing.Size(250, 1080);
            this.panelModelingInformation.TabIndex = 8;
            // 
            // labelLitres2
            // 
            this.labelLitres2.AutoSize = true;
            this.labelLitres2.Location = new System.Drawing.Point(156, 377);
            this.labelLitres2.Name = "labelLitres2";
            this.labelLitres2.Size = new System.Drawing.Size(20, 17);
            this.labelLitres2.TabIndex = 21;
            this.labelLitres2.Text = "л.";
            // 
            // labelLitres1
            // 
            this.labelLitres1.AutoSize = true;
            this.labelLitres1.Location = new System.Drawing.Point(154, 349);
            this.labelLitres1.Name = "labelLitres1";
            this.labelLitres1.Size = new System.Drawing.Size(20, 17);
            this.labelLitres1.TabIndex = 21;
            this.labelLitres1.Text = "л.";
            // 
            // labelCurrentFullnessValue
            // 
            this.labelCurrentFullnessValue.AutoSize = true;
            this.labelCurrentFullnessValue.Location = new System.Drawing.Point(103, 377);
            this.labelCurrentFullnessValue.Name = "labelCurrentFullnessValue";
            this.labelCurrentFullnessValue.Size = new System.Drawing.Size(56, 17);
            this.labelCurrentFullnessValue.TabIndex = 18;
            this.labelCurrentFullnessValue.Text = "100000";
            this.labelCurrentFullnessValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelVolumeValue
            // 
            this.labelVolumeValue.AutoSize = true;
            this.labelVolumeValue.Location = new System.Drawing.Point(103, 349);
            this.labelVolumeValue.Name = "labelVolumeValue";
            this.labelVolumeValue.Size = new System.Drawing.Size(56, 17);
            this.labelVolumeValue.TabIndex = 18;
            this.labelVolumeValue.Text = "100000";
            this.labelVolumeValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelFuelValue
            // 
            this.labelFuelValue.AutoSize = true;
            this.labelFuelValue.Location = new System.Drawing.Point(103, 318);
            this.labelFuelValue.Name = "labelFuelValue";
            this.labelFuelValue.Size = new System.Drawing.Size(131, 17);
            this.labelFuelValue.TabIndex = 19;
            this.labelFuelValue.Text = "АИ-92      42,3 руб.";
            // 
            // labelCurrentFullness
            // 
            this.labelCurrentFullness.AutoSize = true;
            this.labelCurrentFullness.Location = new System.Drawing.Point(30, 377);
            this.labelCurrentFullness.Name = "labelCurrentFullness";
            this.labelCurrentFullness.Size = new System.Drawing.Size(67, 17);
            this.labelCurrentFullness.TabIndex = 17;
            this.labelCurrentFullness.Text = "Остаток:";
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(30, 349);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(57, 17);
            this.labelVolume.TabIndex = 17;
            this.labelVolume.Text = "Объем:";
            // 
            // labelFuel
            // 
            this.labelFuel.AutoSize = true;
            this.labelFuel.Location = new System.Drawing.Point(30, 318);
            this.labelFuel.Name = "labelFuel";
            this.labelFuel.Size = new System.Drawing.Size(68, 17);
            this.labelFuel.TabIndex = 16;
            this.labelFuel.Text = "Топливо:";
            // 
            // labelFuelTank
            // 
            this.labelFuelTank.AutoSize = true;
            this.labelFuelTank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuelTank.Location = new System.Drawing.Point(23, 283);
            this.labelFuelTank.Name = "labelFuelTank";
            this.labelFuelTank.Size = new System.Drawing.Size(148, 20);
            this.labelFuelTank.TabIndex = 15;
            this.labelFuelTank.Text = "Топливный бак";
            // 
            // labelLitersPerMinute
            // 
            this.labelLitersPerMinute.AutoSize = true;
            this.labelLitersPerMinute.Location = new System.Drawing.Point(65, 245);
            this.labelLitersPerMinute.Name = "labelLitersPerMinute";
            this.labelLitersPerMinute.Size = new System.Drawing.Size(49, 17);
            this.labelLitersPerMinute.TabIndex = 13;
            this.labelLitersPerMinute.Text = "л/мин.";
            // 
            // labelSpeedOfFillingValue
            // 
            this.labelSpeedOfFillingValue.AutoSize = true;
            this.labelSpeedOfFillingValue.Location = new System.Drawing.Point(44, 245);
            this.labelSpeedOfFillingValue.Name = "labelSpeedOfFillingValue";
            this.labelSpeedOfFillingValue.Size = new System.Drawing.Size(24, 17);
            this.labelSpeedOfFillingValue.TabIndex = 12;
            this.labelSpeedOfFillingValue.Text = "75";
            this.labelSpeedOfFillingValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelSpeedOfFilling
            // 
            this.labelSpeedOfFilling.AutoSize = true;
            this.labelSpeedOfFilling.Location = new System.Drawing.Point(30, 217);
            this.labelSpeedOfFilling.Name = "labelSpeedOfFilling";
            this.labelSpeedOfFilling.Size = new System.Drawing.Size(183, 17);
            this.labelSpeedOfFilling.TabIndex = 9;
            this.labelSpeedOfFilling.Text = "Скорость подачи топлива:";
            // 
            // labelFuelDispenser
            // 
            this.labelFuelDispenser.AutoSize = true;
            this.labelFuelDispenser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuelDispenser.Location = new System.Drawing.Point(23, 186);
            this.labelFuelDispenser.Name = "labelFuelDispenser";
            this.labelFuelDispenser.Size = new System.Drawing.Size(44, 20);
            this.labelFuelDispenser.TabIndex = 8;
            this.labelFuelDispenser.Text = "ТРК";
            // 
            // labelSelectedElement
            // 
            this.labelSelectedElement.AutoSize = true;
            this.labelSelectedElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedElement.Location = new System.Drawing.Point(23, 706);
            this.labelSelectedElement.Name = "labelSelectedElement";
            this.labelSelectedElement.Size = new System.Drawing.Size(72, 17);
            this.labelSelectedElement.TabIndex = 7;
            this.labelSelectedElement.Text = "Элемент";
            // 
            // labelRubles1
            // 
            this.labelRubles1.AutoSize = true;
            this.labelRubles1.Location = new System.Drawing.Point(145, 115);
            this.labelRubles1.Name = "labelRubles1";
            this.labelRubles1.Size = new System.Drawing.Size(27, 13);
            this.labelRubles1.TabIndex = 6;
            this.labelRubles1.Text = "руб.";
            // 
            // labelRubles2
            // 
            this.labelRubles2.AutoSize = true;
            this.labelRubles2.Location = new System.Drawing.Point(144, 142);
            this.labelRubles2.Name = "labelRubles2";
            this.labelRubles2.Size = new System.Drawing.Size(27, 13);
            this.labelRubles2.TabIndex = 6;
            this.labelRubles2.Text = "руб.";
            // 
            // labelCashCounterLimitValue
            // 
            this.labelCashCounterLimitValue.AutoSize = true;
            this.labelCashCounterLimitValue.Location = new System.Drawing.Point(90, 142);
            this.labelCashCounterLimitValue.Name = "labelCashCounterLimitValue";
            this.labelCashCounterLimitValue.Size = new System.Drawing.Size(43, 13);
            this.labelCashCounterLimitValue.TabIndex = 5;
            this.labelCashCounterLimitValue.Text = "100000";
            this.labelCashCounterLimitValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelCashCounterSumValue
            // 
            this.labelCashCounterSumValue.AutoSize = true;
            this.labelCashCounterSumValue.Location = new System.Drawing.Point(90, 115);
            this.labelCashCounterSumValue.Name = "labelCashCounterSumValue";
            this.labelCashCounterSumValue.Size = new System.Drawing.Size(37, 13);
            this.labelCashCounterSumValue.TabIndex = 5;
            this.labelCashCounterSumValue.Text = "12354";
            this.labelCashCounterSumValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelCashCounterLimit
            // 
            this.labelCashCounterLimit.AutoSize = true;
            this.labelCashCounterLimit.Location = new System.Drawing.Point(30, 142);
            this.labelCashCounterLimit.Name = "labelCashCounterLimit";
            this.labelCashCounterLimit.Size = new System.Drawing.Size(43, 13);
            this.labelCashCounterLimit.TabIndex = 4;
            this.labelCashCounterLimit.Text = "Лимит:";
            // 
            // labelCashCounterSum
            // 
            this.labelCashCounterSum.AutoSize = true;
            this.labelCashCounterSum.Location = new System.Drawing.Point(30, 115);
            this.labelCashCounterSum.Name = "labelCashCounterSum";
            this.labelCashCounterSum.Size = new System.Drawing.Size(44, 13);
            this.labelCashCounterSum.TabIndex = 3;
            this.labelCashCounterSum.Text = "Сумма:";
            // 
            // labelCashCounter
            // 
            this.labelCashCounter.AutoSize = true;
            this.labelCashCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCashCounter.Location = new System.Drawing.Point(23, 84);
            this.labelCashCounter.Name = "labelCashCounter";
            this.labelCashCounter.Size = new System.Drawing.Size(52, 17);
            this.labelCashCounter.TabIndex = 2;
            this.labelCashCounter.Text = "Касса";
            // 
            // labelModelState
            // 
            this.labelModelState.AutoSize = true;
            this.labelModelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModelState.ForeColor = System.Drawing.Color.Green;
            this.labelModelState.Location = new System.Drawing.Point(20, 34);
            this.labelModelState.Name = "labelModelState";
            this.labelModelState.Size = new System.Drawing.Size(126, 29);
            this.labelModelState.TabIndex = 1;
            this.labelModelState.Text = "АКТИВНА";
            // 
            // textBoxSelectedItemInformation
            // 
            this.textBoxSelectedItemInformation.Location = new System.Drawing.Point(6, 737);
            this.textBoxSelectedItemInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSelectedItemInformation.Multiline = true;
            this.textBoxSelectedItemInformation.Name = "textBoxSelectedItemInformation";
            this.textBoxSelectedItemInformation.ReadOnly = true;
            this.textBoxSelectedItemInformation.Size = new System.Drawing.Size(241, 169);
            this.textBoxSelectedItemInformation.TabIndex = 0;
            // 
            // panelPlayground
            // 
            this.panelPlayground.Controls.Add(this.pictureBoxCar);
            this.panelPlayground.Controls.Add(this.pictureBoxEnter);
            this.panelPlayground.Controls.Add(this.pictureBoxFuelTank1);
            this.panelPlayground.Controls.Add(this.pictureBoxFuelTank2);
            this.panelPlayground.Controls.Add(this.pictureBoxFuelDispenser2);
            this.panelPlayground.Controls.Add(this.pictureBoxExit);
            this.panelPlayground.Controls.Add(this.pictureBoxServiceArea);
            this.panelPlayground.Controls.Add(this.pictureBoxFuelDispenser1);
            this.panelPlayground.Controls.Add(this.pictureBoxCashCounter);
            this.panelPlayground.Location = new System.Drawing.Point(3, 2);
            this.panelPlayground.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPlayground.Name = "panelPlayground";
            this.panelPlayground.Size = new System.Drawing.Size(1176, 936);
            this.panelPlayground.TabIndex = 10;
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.Image = global::GasStationMs.App.Properties.Resources.car_64x34__left;
            this.pictureBoxCar.Location = new System.Drawing.Point(691, 455);
            this.pictureBoxCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(64, 34);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxCar.TabIndex = 3;
            this.pictureBoxCar.TabStop = false;
            // 
            // pictureBoxEnter
            // 
            this.pictureBoxEnter.BackColor = System.Drawing.Color.LawnGreen;
            this.pictureBoxEnter.Location = new System.Drawing.Point(527, 438);
            this.pictureBoxEnter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxEnter.Name = "pictureBoxEnter";
            this.pictureBoxEnter.Size = new System.Drawing.Size(92, 25);
            this.pictureBoxEnter.TabIndex = 5;
            this.pictureBoxEnter.TabStop = false;
            this.pictureBoxEnter.Tag = "enter";
            // 
            // pictureBoxFuelTank1
            // 
            this.pictureBoxFuelTank1.BackColor = System.Drawing.Color.Wheat;
            this.pictureBoxFuelTank1.Image = global::GasStationMs.App.Properties.Resources.FuelTank;
            this.pictureBoxFuelTank1.Location = new System.Drawing.Point(656, 104);
            this.pictureBoxFuelTank1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxFuelTank1.Name = "pictureBoxFuelTank1";
            this.pictureBoxFuelTank1.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxFuelTank1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFuelTank1.TabIndex = 0;
            this.pictureBoxFuelTank1.TabStop = false;
            // 
            // pictureBoxFuelTank2
            // 
            this.pictureBoxFuelTank2.BackColor = System.Drawing.Color.Wheat;
            this.pictureBoxFuelTank2.Image = global::GasStationMs.App.Properties.Resources.FuelTank;
            this.pictureBoxFuelTank2.Location = new System.Drawing.Point(656, 201);
            this.pictureBoxFuelTank2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxFuelTank2.Name = "pictureBoxFuelTank2";
            this.pictureBoxFuelTank2.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxFuelTank2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFuelTank2.TabIndex = 1;
            this.pictureBoxFuelTank2.TabStop = false;
            // 
            // pictureBoxFuelDispenser2
            // 
            this.pictureBoxFuelDispenser2.Image = global::GasStationMs.App.Properties.Resources.dispenser70;
            this.pictureBoxFuelDispenser2.Location = new System.Drawing.Point(391, 363);
            this.pictureBoxFuelDispenser2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxFuelDispenser2.Name = "pictureBoxFuelDispenser2";
            this.pictureBoxFuelDispenser2.Size = new System.Drawing.Size(51, 50);
            this.pictureBoxFuelDispenser2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFuelDispenser2.TabIndex = 2;
            this.pictureBoxFuelDispenser2.TabStop = false;
            this.pictureBoxFuelDispenser2.Tag = "fuelDispenser";
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.BackColor = System.Drawing.Color.Coral;
            this.pictureBoxExit.Location = new System.Drawing.Point(111, 438);
            this.pictureBoxExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(92, 25);
            this.pictureBoxExit.TabIndex = 6;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Tag = "exit";
            // 
            // pictureBoxServiceArea
            // 
            this.pictureBoxServiceArea.BackColor = System.Drawing.Color.Wheat;
            this.pictureBoxServiceArea.Location = new System.Drawing.Point(572, 0);
            this.pictureBoxServiceArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxServiceArea.Name = "pictureBoxServiceArea";
            this.pictureBoxServiceArea.Size = new System.Drawing.Size(228, 363);
            this.pictureBoxServiceArea.TabIndex = 7;
            this.pictureBoxServiceArea.TabStop = false;
            // 
            // pictureBoxFuelDispenser1
            // 
            this.pictureBoxFuelDispenser1.Image = global::GasStationMs.App.Properties.Resources.dispenser70;
            this.pictureBoxFuelDispenser1.Location = new System.Drawing.Point(288, 201);
            this.pictureBoxFuelDispenser1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxFuelDispenser1.Name = "pictureBoxFuelDispenser1";
            this.pictureBoxFuelDispenser1.Size = new System.Drawing.Size(51, 50);
            this.pictureBoxFuelDispenser1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFuelDispenser1.TabIndex = 1;
            this.pictureBoxFuelDispenser1.TabStop = false;
            this.pictureBoxFuelDispenser1.Tag = "fuelDispenser";
            // 
            // pictureBoxCashCounter
            // 
            this.pictureBoxCashCounter.Image = global::GasStationMs.App.Properties.Resources.cashbox;
            this.pictureBoxCashCounter.Location = new System.Drawing.Point(111, 236);
            this.pictureBoxCashCounter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCashCounter.Name = "pictureBoxCashCounter";
            this.pictureBoxCashCounter.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxCashCounter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxCashCounter.TabIndex = 4;
            this.pictureBoxCashCounter.TabStop = false;
            // 
            // panelTimeManagment
            // 
            this.panelTimeManagment.BackColor = System.Drawing.SystemColors.Window;
            this.panelTimeManagment.Controls.Add(this.pictureBoxPauseAndPlay);
            this.panelTimeManagment.Controls.Add(this.labelTotalTimeValue);
            this.panelTimeManagment.Controls.Add(this.labelTotalTime);
            this.panelTimeManagment.Location = new System.Drawing.Point(3, 938);
            this.panelTimeManagment.Name = "panelTimeManagment";
            this.panelTimeManagment.Size = new System.Drawing.Size(1176, 100);
            this.panelTimeManagment.TabIndex = 1;
            // 
            // pictureBoxPauseAndPlay
            // 
            this.pictureBoxPauseAndPlay.Image = global::GasStationMs.App.Properties.Resources.Pause;
            this.pictureBoxPauseAndPlay.Location = new System.Drawing.Point(1082, 35);
            this.pictureBoxPauseAndPlay.Name = "pictureBoxPauseAndPlay";
            this.pictureBoxPauseAndPlay.Size = new System.Drawing.Size(58, 48);
            this.pictureBoxPauseAndPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPauseAndPlay.TabIndex = 2;
            this.pictureBoxPauseAndPlay.TabStop = false;
            // 
            // labelTotalTimeValue
            // 
            this.labelTotalTimeValue.AutoSize = true;
            this.labelTotalTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTimeValue.Location = new System.Drawing.Point(252, 43);
            this.labelTotalTimeValue.Name = "labelTotalTimeValue";
            this.labelTotalTimeValue.Size = new System.Drawing.Size(86, 24);
            this.labelTotalTimeValue.TabIndex = 1;
            this.labelTotalTimeValue.Text = "totalTime";
            // 
            // labelTotalTime
            // 
            this.labelTotalTime.AutoSize = true;
            this.labelTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTime.Location = new System.Drawing.Point(23, 39);
            this.labelTotalTime.Name = "labelTotalTime";
            this.labelTotalTime.Size = new System.Drawing.Size(168, 24);
            this.labelTotalTime.TabIndex = 0;
            this.labelTotalTime.Text = "Времени прошло:";
            // 
            // ModelingForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1430, 1033);
            this.Controls.Add(this.panelTimeManagment);
            this.Controls.Add(this.panelPlayground);
            this.Controls.Add(this.panelModelingInformation);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ModelingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modeling";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModelingForm_FormClosing);
            this.panelModelingInformation.ResumeLayout(false);
            this.panelModelingInformation.PerformLayout();
            this.panelPlayground.ResumeLayout(false);
            this.panelPlayground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFuelTank1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFuelTank2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFuelDispenser2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxServiceArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFuelDispenser1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCashCounter)).EndInit();
            this.panelTimeManagment.ResumeLayout(false);
            this.panelTimeManagment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPauseAndPlay)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panelModelingInformation;
        private System.Windows.Forms.Panel panelPlayground;
        private System.Windows.Forms.Panel panelTimeManagment;
        private System.Windows.Forms.Label labelTotalTime;
        private System.Windows.Forms.Label labelTotalTimeValue;
        private System.Windows.Forms.Label labelModelState;
        private System.Windows.Forms.TextBox textBoxSelectedItemInformation;
        private System.Windows.Forms.Label labelCashCounter;
        private System.Windows.Forms.Label labelCashCounterLimitValue;
        private System.Windows.Forms.Label labelCashCounterSumValue;
        private System.Windows.Forms.Label labelCashCounterLimit;
        private System.Windows.Forms.Label labelCashCounterSum;
        private System.Windows.Forms.Label labelRubles1;
        private System.Windows.Forms.Label labelRubles2;
        private System.Windows.Forms.Label labelSelectedElement;
        private System.Windows.Forms.PictureBox pictureBoxPauseAndPlay;
        private System.Windows.Forms.Label labelLitres1;
        private System.Windows.Forms.Label labelVolumeValue;
        private System.Windows.Forms.Label labelFuelValue;
        private System.Windows.Forms.Label labelCurrentFullness;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label labelFuel;
        private System.Windows.Forms.Label labelFuelTank;
        private System.Windows.Forms.Label labelLitersPerMinute;
        private System.Windows.Forms.Label labelSpeedOfFillingValue;
        private System.Windows.Forms.Label labelSpeedOfFilling;
        private System.Windows.Forms.Label labelFuelDispenser;
        private System.Windows.Forms.Label labelCurrentFullnessValue;
        private System.Windows.Forms.Label labelLitres2;
    }
}