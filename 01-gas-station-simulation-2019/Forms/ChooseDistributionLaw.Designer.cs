namespace GasStationMs.App
{
    partial class ChooseDistributionLaw
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
            this.rbDeterminedFlow = new System.Windows.Forms.RadioButton();
            this.rbRandomFlow = new System.Windows.Forms.RadioButton();
            this.cbChooseDistributionLaw = new System.Windows.Forms.ComboBox();
            this.labelProbabilityOfStoppingAtGasStation = new System.Windows.Forms.Label();
            this.nudProbabilityOfStoppingAtGasStation = new System.Windows.Forms.NumericUpDown();
            this.btnToModelingForm = new System.Windows.Forms.Button();
            this.nudNormalDistrVariance = new System.Windows.Forms.NumericUpDown();
            this.nudNormalDistrExpectedValue = new System.Windows.Forms.NumericUpDown();
            this.labelNormalDistrVariance = new System.Windows.Forms.Label();
            this.labelNormalDistrExpectedValue = new System.Windows.Forms.Label();
            this.labelDeterminedFlowParams = new System.Windows.Forms.Label();
            this.nudDeterminedFlow = new System.Windows.Forms.NumericUpDown();
            this.gbSelectFlow = new System.Windows.Forms.GroupBox();
            this.gbDeterminedFlowParams = new System.Windows.Forms.GroupBox();
            this.gbRandomFlowParams1 = new System.Windows.Forms.GroupBox();
            this.labelChooseDistrLaw = new System.Windows.Forms.Label();
            this.gbRandomFlowParams2 = new System.Windows.Forms.GroupBox();
            this.gbExponentialDistrParams = new System.Windows.Forms.GroupBox();
            this.nudExponentialDistrLambda = new System.Windows.Forms.NumericUpDown();
            this.labelExponentialDistrLambda = new System.Windows.Forms.Label();
            this.gbNormalDistrParams = new System.Windows.Forms.GroupBox();
            this.gbUniformDistrParams = new System.Windows.Forms.GroupBox();
            this.nudUniformDistParamB = new System.Windows.Forms.NumericUpDown();
            this.labelUniformDistParamB = new System.Windows.Forms.Label();
            this.nudUniformDistParamA = new System.Windows.Forms.NumericUpDown();
            this.labelUniformDistParamA = new System.Windows.Forms.Label();
            this.gbProbabilityOfStoppingAtGasStation = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudProbabilityOfStoppingAtGasStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNormalDistrVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNormalDistrExpectedValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeterminedFlow)).BeginInit();
            this.gbSelectFlow.SuspendLayout();
            this.gbDeterminedFlowParams.SuspendLayout();
            this.gbRandomFlowParams1.SuspendLayout();
            this.gbRandomFlowParams2.SuspendLayout();
            this.gbExponentialDistrParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExponentialDistrLambda)).BeginInit();
            this.gbNormalDistrParams.SuspendLayout();
            this.gbUniformDistrParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUniformDistParamB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUniformDistParamA)).BeginInit();
            this.gbProbabilityOfStoppingAtGasStation.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbDeterminedFlow
            // 
            this.rbDeterminedFlow.AutoSize = true;
            this.rbDeterminedFlow.Checked = true;
            this.rbDeterminedFlow.Location = new System.Drawing.Point(6, 15);
            this.rbDeterminedFlow.Name = "rbDeterminedFlow";
            this.rbDeterminedFlow.Size = new System.Drawing.Size(165, 17);
            this.rbDeterminedFlow.TabIndex = 0;
            this.rbDeterminedFlow.TabStop = true;
            this.rbDeterminedFlow.Text = "Детерминированный поток";
            this.rbDeterminedFlow.UseVisualStyleBackColor = true;
            // 
            // rbRandomFlow
            // 
            this.rbRandomFlow.AutoSize = true;
            this.rbRandomFlow.Location = new System.Drawing.Point(6, 97);
            this.rbRandomFlow.Name = "rbRandomFlow";
            this.rbRandomFlow.Size = new System.Drawing.Size(112, 17);
            this.rbRandomFlow.TabIndex = 1;
            this.rbRandomFlow.Text = "Случайный поток";
            this.rbRandomFlow.UseVisualStyleBackColor = true;
            this.rbRandomFlow.CheckedChanged += new System.EventHandler(this.rbRandomFlow_CheckedChanged);
            // 
            // cbChooseDistributionLaw
            // 
            this.cbChooseDistributionLaw.CausesValidation = false;
            this.cbChooseDistributionLaw.FormattingEnabled = true;
            this.cbChooseDistributionLaw.Items.AddRange(new object[] {
            "Равномерный",
            "Нормальный",
            "Показательный"});
            this.cbChooseDistributionLaw.Location = new System.Drawing.Point(235, 25);
            this.cbChooseDistributionLaw.Name = "cbChooseDistributionLaw";
            this.cbChooseDistributionLaw.Size = new System.Drawing.Size(124, 21);
            this.cbChooseDistributionLaw.TabIndex = 6;
            this.cbChooseDistributionLaw.Visible = false;
            this.cbChooseDistributionLaw.SelectedIndexChanged += new System.EventHandler(this.cbChooseDistributionLaw_SelectedIndexChanged);
            // 
            // labelProbabilityOfStoppingAtGasStation
            // 
            this.labelProbabilityOfStoppingAtGasStation.AutoSize = true;
            this.labelProbabilityOfStoppingAtGasStation.Location = new System.Drawing.Point(6, 16);
            this.labelProbabilityOfStoppingAtGasStation.Name = "labelProbabilityOfStoppingAtGasStation";
            this.labelProbabilityOfStoppingAtGasStation.Size = new System.Drawing.Size(214, 13);
            this.labelProbabilityOfStoppingAtGasStation.TabIndex = 7;
            this.labelProbabilityOfStoppingAtGasStation.Text = "Вероятность заезда автомобиля на АЗС";
            // 
            // nudProbabilityOfStoppingAtGasStation
            // 
            this.nudProbabilityOfStoppingAtGasStation.DecimalPlaces = 1;
            this.nudProbabilityOfStoppingAtGasStation.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudProbabilityOfStoppingAtGasStation.Location = new System.Drawing.Point(226, 14);
            this.nudProbabilityOfStoppingAtGasStation.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProbabilityOfStoppingAtGasStation.Name = "nudProbabilityOfStoppingAtGasStation";
            this.nudProbabilityOfStoppingAtGasStation.Size = new System.Drawing.Size(39, 20);
            this.nudProbabilityOfStoppingAtGasStation.TabIndex = 8;
            // 
            // btnToModelingForm
            // 
            this.btnToModelingForm.Location = new System.Drawing.Point(12, 326);
            this.btnToModelingForm.Name = "btnToModelingForm";
            this.btnToModelingForm.Size = new System.Drawing.Size(624, 33);
            this.btnToModelingForm.TabIndex = 9;
            this.btnToModelingForm.Text = "Смоделировать";
            this.btnToModelingForm.UseVisualStyleBackColor = true;
            this.btnToModelingForm.Click += new System.EventHandler(this.btnOpenModeling_Click);
            // 
            // nudNormalDistrVariance
            // 
            this.nudNormalDistrVariance.DecimalPlaces = 1;
            this.nudNormalDistrVariance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudNormalDistrVariance.Location = new System.Drawing.Point(144, 37);
            this.nudNormalDistrVariance.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudNormalDistrVariance.Name = "nudNormalDistrVariance";
            this.nudNormalDistrVariance.Size = new System.Drawing.Size(46, 20);
            this.nudNormalDistrVariance.TabIndex = 11;
            this.nudNormalDistrVariance.Visible = false;
            // 
            // nudNormalDistrExpectedValue
            // 
            this.nudNormalDistrExpectedValue.DecimalPlaces = 1;
            this.nudNormalDistrExpectedValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudNormalDistrExpectedValue.Location = new System.Drawing.Point(144, 72);
            this.nudNormalDistrExpectedValue.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudNormalDistrExpectedValue.Name = "nudNormalDistrExpectedValue";
            this.nudNormalDistrExpectedValue.Size = new System.Drawing.Size(46, 20);
            this.nudNormalDistrExpectedValue.TabIndex = 12;
            this.nudNormalDistrExpectedValue.Visible = false;
            // 
            // labelNormalDistrVariance
            // 
            this.labelNormalDistrVariance.AutoSize = true;
            this.labelNormalDistrVariance.Location = new System.Drawing.Point(6, 39);
            this.labelNormalDistrVariance.Name = "labelNormalDistrVariance";
            this.labelNormalDistrVariance.Size = new System.Drawing.Size(64, 13);
            this.labelNormalDistrVariance.TabIndex = 13;
            this.labelNormalDistrVariance.Text = "Дисперсия";
            this.labelNormalDistrVariance.Visible = false;
            // 
            // labelNormalDistrExpectedValue
            // 
            this.labelNormalDistrExpectedValue.AutoSize = true;
            this.labelNormalDistrExpectedValue.Location = new System.Drawing.Point(6, 74);
            this.labelNormalDistrExpectedValue.Name = "labelNormalDistrExpectedValue";
            this.labelNormalDistrExpectedValue.Size = new System.Drawing.Size(83, 13);
            this.labelNormalDistrExpectedValue.TabIndex = 15;
            this.labelNormalDistrExpectedValue.Text = "Мат. ожидание";
            this.labelNormalDistrExpectedValue.Visible = false;
            // 
            // labelDeterminedFlowParams
            // 
            this.labelDeterminedFlowParams.AutoSize = true;
            this.labelDeterminedFlowParams.Location = new System.Drawing.Point(6, 28);
            this.labelDeterminedFlowParams.Name = "labelDeterminedFlowParams";
            this.labelDeterminedFlowParams.Size = new System.Drawing.Size(223, 13);
            this.labelDeterminedFlowParams.TabIndex = 16;
            this.labelDeterminedFlowParams.Text = "Время между появлением автомобилей, с";
            // 
            // nudDeterminedFlow
            // 
            this.nudDeterminedFlow.DecimalPlaces = 1;
            this.nudDeterminedFlow.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudDeterminedFlow.Location = new System.Drawing.Point(235, 26);
            this.nudDeterminedFlow.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDeterminedFlow.Name = "nudDeterminedFlow";
            this.nudDeterminedFlow.Size = new System.Drawing.Size(46, 20);
            this.nudDeterminedFlow.TabIndex = 17;
            // 
            // gbSelectFlow
            // 
            this.gbSelectFlow.Controls.Add(this.rbDeterminedFlow);
            this.gbSelectFlow.Controls.Add(this.rbRandomFlow);
            this.gbSelectFlow.Location = new System.Drawing.Point(12, 12);
            this.gbSelectFlow.Name = "gbSelectFlow";
            this.gbSelectFlow.Size = new System.Drawing.Size(200, 129);
            this.gbSelectFlow.TabIndex = 22;
            this.gbSelectFlow.TabStop = false;
            // 
            // gbDeterminedFlowParams
            // 
            this.gbDeterminedFlowParams.Controls.Add(this.nudDeterminedFlow);
            this.gbDeterminedFlowParams.Controls.Add(this.labelDeterminedFlowParams);
            this.gbDeterminedFlowParams.Location = new System.Drawing.Point(218, 12);
            this.gbDeterminedFlowParams.Name = "gbDeterminedFlowParams";
            this.gbDeterminedFlowParams.Size = new System.Drawing.Size(418, 61);
            this.gbDeterminedFlowParams.TabIndex = 23;
            this.gbDeterminedFlowParams.TabStop = false;
            this.gbDeterminedFlowParams.Text = "Параметры детерминированного потока";
            // 
            // gbRandomFlowParams1
            // 
            this.gbRandomFlowParams1.Controls.Add(this.labelChooseDistrLaw);
            this.gbRandomFlowParams1.Controls.Add(this.cbChooseDistributionLaw);
            this.gbRandomFlowParams1.Location = new System.Drawing.Point(218, 80);
            this.gbRandomFlowParams1.Name = "gbRandomFlowParams1";
            this.gbRandomFlowParams1.Size = new System.Drawing.Size(418, 61);
            this.gbRandomFlowParams1.TabIndex = 24;
            this.gbRandomFlowParams1.TabStop = false;
            this.gbRandomFlowParams1.Text = "Параметры №1 случайного потока";
            // 
            // labelChooseDistrLaw
            // 
            this.labelChooseDistrLaw.AutoSize = true;
            this.labelChooseDistrLaw.Location = new System.Drawing.Point(6, 28);
            this.labelChooseDistrLaw.Name = "labelChooseDistrLaw";
            this.labelChooseDistrLaw.Size = new System.Drawing.Size(171, 13);
            this.labelChooseDistrLaw.TabIndex = 16;
            this.labelChooseDistrLaw.Text = "Выберите закон распределения";
            this.labelChooseDistrLaw.Visible = false;
            // 
            // gbRandomFlowParams2
            // 
            this.gbRandomFlowParams2.Controls.Add(this.gbExponentialDistrParams);
            this.gbRandomFlowParams2.Controls.Add(this.gbNormalDistrParams);
            this.gbRandomFlowParams2.Controls.Add(this.gbUniformDistrParams);
            this.gbRandomFlowParams2.Location = new System.Drawing.Point(12, 147);
            this.gbRandomFlowParams2.Name = "gbRandomFlowParams2";
            this.gbRandomFlowParams2.Size = new System.Drawing.Size(624, 131);
            this.gbRandomFlowParams2.TabIndex = 25;
            this.gbRandomFlowParams2.TabStop = false;
            this.gbRandomFlowParams2.Text = "Параметры №2 случайного потока ";
            // 
            // gbExponentialDistrParams
            // 
            this.gbExponentialDistrParams.Controls.Add(this.nudExponentialDistrLambda);
            this.gbExponentialDistrParams.Controls.Add(this.labelExponentialDistrLambda);
            this.gbExponentialDistrParams.Location = new System.Drawing.Point(420, 19);
            this.gbExponentialDistrParams.Name = "gbExponentialDistrParams";
            this.gbExponentialDistrParams.Size = new System.Drawing.Size(199, 107);
            this.gbExponentialDistrParams.TabIndex = 26;
            this.gbExponentialDistrParams.TabStop = false;
            this.gbExponentialDistrParams.Text = "Параметры показательного распределения";
            // 
            // nudExponentialDistrLambda
            // 
            this.nudExponentialDistrLambda.DecimalPlaces = 1;
            this.nudExponentialDistrLambda.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudExponentialDistrLambda.Location = new System.Drawing.Point(147, 37);
            this.nudExponentialDistrLambda.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudExponentialDistrLambda.Name = "nudExponentialDistrLambda";
            this.nudExponentialDistrLambda.Size = new System.Drawing.Size(46, 20);
            this.nudExponentialDistrLambda.TabIndex = 10;
            this.nudExponentialDistrLambda.Visible = false;
            // 
            // labelExponentialDistrLambda
            // 
            this.labelExponentialDistrLambda.AutoSize = true;
            this.labelExponentialDistrLambda.Location = new System.Drawing.Point(6, 39);
            this.labelExponentialDistrLambda.Name = "labelExponentialDistrLambda";
            this.labelExponentialDistrLambda.Size = new System.Drawing.Size(85, 13);
            this.labelExponentialDistrLambda.TabIndex = 14;
            this.labelExponentialDistrLambda.Text = "Интенсивность";
            this.labelExponentialDistrLambda.Visible = false;
            // 
            // gbNormalDistrParams
            // 
            this.gbNormalDistrParams.Controls.Add(this.labelNormalDistrExpectedValue);
            this.gbNormalDistrParams.Controls.Add(this.labelNormalDistrVariance);
            this.gbNormalDistrParams.Controls.Add(this.nudNormalDistrExpectedValue);
            this.gbNormalDistrParams.Controls.Add(this.nudNormalDistrVariance);
            this.gbNormalDistrParams.Location = new System.Drawing.Point(215, 19);
            this.gbNormalDistrParams.Name = "gbNormalDistrParams";
            this.gbNormalDistrParams.Size = new System.Drawing.Size(199, 107);
            this.gbNormalDistrParams.TabIndex = 21;
            this.gbNormalDistrParams.TabStop = false;
            this.gbNormalDistrParams.Text = "Параметры нормального распределения";
            // 
            // gbUniformDistrParams
            // 
            this.gbUniformDistrParams.Controls.Add(this.nudUniformDistParamB);
            this.gbUniformDistrParams.Controls.Add(this.labelUniformDistParamB);
            this.gbUniformDistrParams.Controls.Add(this.nudUniformDistParamA);
            this.gbUniformDistrParams.Controls.Add(this.labelUniformDistParamA);
            this.gbUniformDistrParams.Location = new System.Drawing.Point(6, 19);
            this.gbUniformDistrParams.Name = "gbUniformDistrParams";
            this.gbUniformDistrParams.Size = new System.Drawing.Size(200, 107);
            this.gbUniformDistrParams.TabIndex = 20;
            this.gbUniformDistrParams.TabStop = false;
            this.gbUniformDistrParams.Text = "Параметры равномерного распределения";
            // 
            // nudUniformDistParamB
            // 
            this.nudUniformDistParamB.DecimalPlaces = 1;
            this.nudUniformDistParamB.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudUniformDistParamB.Location = new System.Drawing.Point(144, 73);
            this.nudUniformDistParamB.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudUniformDistParamB.Name = "nudUniformDistParamB";
            this.nudUniformDistParamB.Size = new System.Drawing.Size(46, 20);
            this.nudUniformDistParamB.TabIndex = 20;
            this.nudUniformDistParamB.Visible = false;
            // 
            // labelUniformDistParamB
            // 
            this.labelUniformDistParamB.AutoSize = true;
            this.labelUniformDistParamB.Location = new System.Drawing.Point(6, 75);
            this.labelUniformDistParamB.Name = "labelUniformDistParamB";
            this.labelUniformDistParamB.Size = new System.Drawing.Size(101, 13);
            this.labelUniformDistParamB.TabIndex = 19;
            this.labelUniformDistParamB.Text = "Правая граница, с";
            this.labelUniformDistParamB.Visible = false;
            // 
            // nudUniformDistParamA
            // 
            this.nudUniformDistParamA.DecimalPlaces = 1;
            this.nudUniformDistParamA.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudUniformDistParamA.Location = new System.Drawing.Point(144, 38);
            this.nudUniformDistParamA.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudUniformDistParamA.Name = "nudUniformDistParamA";
            this.nudUniformDistParamA.Size = new System.Drawing.Size(46, 20);
            this.nudUniformDistParamA.TabIndex = 18;
            this.nudUniformDistParamA.Visible = false;
            // 
            // labelUniformDistParamA
            // 
            this.labelUniformDistParamA.AutoSize = true;
            this.labelUniformDistParamA.Location = new System.Drawing.Point(6, 40);
            this.labelUniformDistParamA.Name = "labelUniformDistParamA";
            this.labelUniformDistParamA.Size = new System.Drawing.Size(95, 13);
            this.labelUniformDistParamA.TabIndex = 17;
            this.labelUniformDistParamA.Text = "Левая граница, с";
            this.labelUniformDistParamA.Visible = false;
            // 
            // gbProbabilityOfStoppingAtGasStation
            // 
            this.gbProbabilityOfStoppingAtGasStation.Controls.Add(this.labelProbabilityOfStoppingAtGasStation);
            this.gbProbabilityOfStoppingAtGasStation.Controls.Add(this.nudProbabilityOfStoppingAtGasStation);
            this.gbProbabilityOfStoppingAtGasStation.Location = new System.Drawing.Point(12, 279);
            this.gbProbabilityOfStoppingAtGasStation.Name = "gbProbabilityOfStoppingAtGasStation";
            this.gbProbabilityOfStoppingAtGasStation.Size = new System.Drawing.Size(624, 41);
            this.gbProbabilityOfStoppingAtGasStation.TabIndex = 26;
            this.gbProbabilityOfStoppingAtGasStation.TabStop = false;
            // 
            // ChooseDistributionLaw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 370);
            this.Controls.Add(this.gbProbabilityOfStoppingAtGasStation);
            this.Controls.Add(this.gbRandomFlowParams2);
            this.Controls.Add(this.gbRandomFlowParams1);
            this.Controls.Add(this.gbDeterminedFlowParams);
            this.Controls.Add(this.gbSelectFlow);
            this.Controls.Add(this.btnToModelingForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseDistributionLaw";
            this.Text = "Настройка транспортного потока";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.nudProbabilityOfStoppingAtGasStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNormalDistrVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNormalDistrExpectedValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeterminedFlow)).EndInit();
            this.gbSelectFlow.ResumeLayout(false);
            this.gbSelectFlow.PerformLayout();
            this.gbDeterminedFlowParams.ResumeLayout(false);
            this.gbDeterminedFlowParams.PerformLayout();
            this.gbRandomFlowParams1.ResumeLayout(false);
            this.gbRandomFlowParams1.PerformLayout();
            this.gbRandomFlowParams2.ResumeLayout(false);
            this.gbExponentialDistrParams.ResumeLayout(false);
            this.gbExponentialDistrParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExponentialDistrLambda)).EndInit();
            this.gbNormalDistrParams.ResumeLayout(false);
            this.gbNormalDistrParams.PerformLayout();
            this.gbUniformDistrParams.ResumeLayout(false);
            this.gbUniformDistrParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUniformDistParamB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUniformDistParamA)).EndInit();
            this.gbProbabilityOfStoppingAtGasStation.ResumeLayout(false);
            this.gbProbabilityOfStoppingAtGasStation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDeterminedFlow;
        private System.Windows.Forms.RadioButton rbRandomFlow;
        private System.Windows.Forms.ComboBox cbChooseDistributionLaw;
        private System.Windows.Forms.Label labelProbabilityOfStoppingAtGasStation;
        private System.Windows.Forms.NumericUpDown nudProbabilityOfStoppingAtGasStation;
        private System.Windows.Forms.Button btnToModelingForm;
        private System.Windows.Forms.NumericUpDown nudNormalDistrVariance;
        private System.Windows.Forms.NumericUpDown nudNormalDistrExpectedValue;
        private System.Windows.Forms.Label labelNormalDistrVariance;
        private System.Windows.Forms.Label labelNormalDistrExpectedValue;
        private System.Windows.Forms.Label labelDeterminedFlowParams;
        private System.Windows.Forms.NumericUpDown nudDeterminedFlow;
        private System.Windows.Forms.GroupBox gbSelectFlow;
        private System.Windows.Forms.GroupBox gbDeterminedFlowParams;
        private System.Windows.Forms.GroupBox gbRandomFlowParams1;
        private System.Windows.Forms.Label labelChooseDistrLaw;
        private System.Windows.Forms.GroupBox gbRandomFlowParams2;
        private System.Windows.Forms.GroupBox gbUniformDistrParams;
        private System.Windows.Forms.NumericUpDown nudUniformDistParamA;
        private System.Windows.Forms.Label labelUniformDistParamA;
        private System.Windows.Forms.NumericUpDown nudUniformDistParamB;
        private System.Windows.Forms.Label labelUniformDistParamB;
        private System.Windows.Forms.GroupBox gbNormalDistrParams;
        private System.Windows.Forms.GroupBox gbExponentialDistrParams;
        private System.Windows.Forms.NumericUpDown nudExponentialDistrLambda;
        private System.Windows.Forms.Label labelExponentialDistrLambda;
        private System.Windows.Forms.GroupBox gbProbabilityOfStoppingAtGasStation;
    }
}