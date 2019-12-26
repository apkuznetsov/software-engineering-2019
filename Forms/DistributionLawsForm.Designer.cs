namespace GasStationMs.App
{
    partial class DistributionLawsForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.probabilityToEnter = new System.Windows.Forms.NumericUpDown();
            this.buttonToModelling = new System.Windows.Forms.Button();
            this.nudNormalDistrVariance = new System.Windows.Forms.NumericUpDown();
            this.nudNormalDistrExpectedValue = new System.Windows.Forms.NumericUpDown();
            this.labelNormalDistrVariance = new System.Windows.Forms.Label();
            this.labelNormalDistrExpectedValue = new System.Windows.Forms.Label();
            this.labelDeterminedFlowParams = new System.Windows.Forms.Label();
            this.nudDeterminedFlow = new System.Windows.Forms.NumericUpDown();
            this.gbSelectFlow = new System.Windows.Forms.GroupBox();
            this.gbDeterminedFlowParams = new System.Windows.Forms.GroupBox();
            this.gbRandomFlowParams1 = new System.Windows.Forms.GroupBox();
            this.labelChooseDistributionLaw = new System.Windows.Forms.Label();
            this.gbRandomFlowParams2 = new System.Windows.Forms.GroupBox();
            this.gbUniformFlowParams = new System.Windows.Forms.GroupBox();
            this.nudUniformDistParamB = new System.Windows.Forms.NumericUpDown();
            this.labelUniformDistParamB = new System.Windows.Forms.Label();
            this.nudUniformDistParamA = new System.Windows.Forms.NumericUpDown();
            this.labelUniformDistParamA = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudExponetialDistrLambda = new System.Windows.Forms.NumericUpDown();
            this.labelExponetialDistrLambda = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.probabilityToEnter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNormalDistrVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNormalDistrExpectedValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeterminedFlow)).BeginInit();
            this.gbSelectFlow.SuspendLayout();
            this.gbDeterminedFlowParams.SuspendLayout();
            this.gbRandomFlowParams1.SuspendLayout();
            this.gbRandomFlowParams2.SuspendLayout();
            this.gbUniformFlowParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUniformDistParamB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUniformDistParamA)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExponetialDistrLambda)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbDeterminedFlow
            // 
            this.rbDeterminedFlow.AutoSize = true;
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
            this.rbRandomFlow.TabStop = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Вероятность заезда автомобиля на АЗС";
            // 
            // probabilityToEnter
            // 
            this.probabilityToEnter.DecimalPlaces = 1;
            this.probabilityToEnter.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.probabilityToEnter.Location = new System.Drawing.Point(285, 428);
            this.probabilityToEnter.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.probabilityToEnter.Name = "probabilityToEnter";
            this.probabilityToEnter.Size = new System.Drawing.Size(39, 20);
            this.probabilityToEnter.TabIndex = 8;
            // 
            // buttonToModelling
            // 
            this.buttonToModelling.Location = new System.Drawing.Point(12, 460);
            this.buttonToModelling.Name = "buttonToModelling";
            this.buttonToModelling.Size = new System.Drawing.Size(624, 33);
            this.buttonToModelling.TabIndex = 9;
            this.buttonToModelling.Text = "Смоделировать";
            this.buttonToModelling.UseVisualStyleBackColor = true;
            this.buttonToModelling.Click += new System.EventHandler(this.buttonToModelling_Click);
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
            this.labelNormalDistrVariance.Click += new System.EventHandler(this.label4_Click);
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
            this.labelNormalDistrExpectedValue.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelDeterminedFlowParams
            // 
            this.labelDeterminedFlowParams.AutoSize = true;
            this.labelDeterminedFlowParams.Location = new System.Drawing.Point(6, 28);
            this.labelDeterminedFlowParams.Name = "labelDeterminedFlowParams";
            this.labelDeterminedFlowParams.Size = new System.Drawing.Size(223, 13);
            this.labelDeterminedFlowParams.TabIndex = 16;
            this.labelDeterminedFlowParams.Text = "Время между появлением автомобилей, с";
            this.labelDeterminedFlowParams.Visible = false;
            this.labelDeterminedFlowParams.Click += new System.EventHandler(this.label7_Click);
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
            this.nudDeterminedFlow.Visible = false;
            this.nudDeterminedFlow.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
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
            this.gbRandomFlowParams1.Controls.Add(this.labelChooseDistributionLaw);
            this.gbRandomFlowParams1.Controls.Add(this.cbChooseDistributionLaw);
            this.gbRandomFlowParams1.Location = new System.Drawing.Point(218, 80);
            this.gbRandomFlowParams1.Name = "gbRandomFlowParams1";
            this.gbRandomFlowParams1.Size = new System.Drawing.Size(418, 61);
            this.gbRandomFlowParams1.TabIndex = 24;
            this.gbRandomFlowParams1.TabStop = false;
            this.gbRandomFlowParams1.Text = "Параметры случайного потока 1";
            // 
            // labelChooseDistributionLaw
            // 
            this.labelChooseDistributionLaw.AutoSize = true;
            this.labelChooseDistributionLaw.Location = new System.Drawing.Point(6, 28);
            this.labelChooseDistributionLaw.Name = "labelChooseDistributionLaw";
            this.labelChooseDistributionLaw.Size = new System.Drawing.Size(171, 13);
            this.labelChooseDistributionLaw.TabIndex = 16;
            this.labelChooseDistributionLaw.Text = "Выберите закон распределения";
            this.labelChooseDistributionLaw.Visible = false;
            // 
            // gbRandomFlowParams2
            // 
            this.gbRandomFlowParams2.Controls.Add(this.groupBox2);
            this.gbRandomFlowParams2.Controls.Add(this.groupBox1);
            this.gbRandomFlowParams2.Controls.Add(this.gbUniformFlowParams);
            this.gbRandomFlowParams2.Location = new System.Drawing.Point(12, 147);
            this.gbRandomFlowParams2.Name = "gbRandomFlowParams2";
            this.gbRandomFlowParams2.Size = new System.Drawing.Size(624, 131);
            this.gbRandomFlowParams2.TabIndex = 25;
            this.gbRandomFlowParams2.TabStop = false;
            this.gbRandomFlowParams2.Text = "Параметры случайного потока 2";
            // 
            // gbUniformFlowParams
            // 
            this.gbUniformFlowParams.Controls.Add(this.nudUniformDistParamB);
            this.gbUniformFlowParams.Controls.Add(this.labelUniformDistParamB);
            this.gbUniformFlowParams.Controls.Add(this.nudUniformDistParamA);
            this.gbUniformFlowParams.Controls.Add(this.labelUniformDistParamA);
            this.gbUniformFlowParams.Location = new System.Drawing.Point(6, 19);
            this.gbUniformFlowParams.Name = "gbUniformFlowParams";
            this.gbUniformFlowParams.Size = new System.Drawing.Size(200, 107);
            this.gbUniformFlowParams.TabIndex = 20;
            this.gbUniformFlowParams.TabStop = false;
            this.gbUniformFlowParams.Text = "Параметры равномерного распределения";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNormalDistrExpectedValue);
            this.groupBox1.Controls.Add(this.labelNormalDistrVariance);
            this.groupBox1.Controls.Add(this.nudNormalDistrExpectedValue);
            this.groupBox1.Controls.Add(this.nudNormalDistrVariance);
            this.groupBox1.Location = new System.Drawing.Point(215, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 107);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры нормального распределения";
            // 
            // nudExponetialDistrLambda
            // 
            this.nudExponetialDistrLambda.DecimalPlaces = 1;
            this.nudExponetialDistrLambda.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudExponetialDistrLambda.Location = new System.Drawing.Point(147, 37);
            this.nudExponetialDistrLambda.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudExponetialDistrLambda.Name = "nudExponetialDistrLambda";
            this.nudExponetialDistrLambda.Size = new System.Drawing.Size(46, 20);
            this.nudExponetialDistrLambda.TabIndex = 10;
            this.nudExponetialDistrLambda.Visible = false;
            this.nudExponetialDistrLambda.ValueChanged += new System.EventHandler(this.exponentialDistributionLambda_ValueChanged);
            // 
            // labelExponetialDistrLambda
            // 
            this.labelExponetialDistrLambda.AutoSize = true;
            this.labelExponetialDistrLambda.Location = new System.Drawing.Point(6, 39);
            this.labelExponetialDistrLambda.Name = "labelExponetialDistrLambda";
            this.labelExponetialDistrLambda.Size = new System.Drawing.Size(85, 13);
            this.labelExponetialDistrLambda.TabIndex = 14;
            this.labelExponetialDistrLambda.Text = "Интенсивность";
            this.labelExponetialDistrLambda.Visible = false;
            this.labelExponetialDistrLambda.Click += new System.EventHandler(this.exponentialDistributionLambdaLabel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudExponetialDistrLambda);
            this.groupBox2.Controls.Add(this.labelExponetialDistrLambda);
            this.groupBox2.Location = new System.Drawing.Point(420, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 107);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры показательного распределения";
            // 
            // DistributionLawsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 505);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbRandomFlowParams2);
            this.Controls.Add(this.gbRandomFlowParams1);
            this.Controls.Add(this.gbDeterminedFlowParams);
            this.Controls.Add(this.gbSelectFlow);
            this.Controls.Add(this.buttonToModelling);
            this.Controls.Add(this.probabilityToEnter);
            this.Name = "DistributionLawsForm";
            this.Text = "Настройка транспортного потока";
            ((System.ComponentModel.ISupportInitialize)(this.probabilityToEnter)).EndInit();
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
            this.gbUniformFlowParams.ResumeLayout(false);
            this.gbUniformFlowParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUniformDistParamB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUniformDistParamA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExponetialDistrLambda)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDeterminedFlow;
        private System.Windows.Forms.RadioButton rbRandomFlow;
        private System.Windows.Forms.ComboBox cbChooseDistributionLaw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown probabilityToEnter;
        private System.Windows.Forms.Button buttonToModelling;
        private System.Windows.Forms.NumericUpDown nudNormalDistrVariance;
        private System.Windows.Forms.NumericUpDown nudNormalDistrExpectedValue;
        private System.Windows.Forms.Label labelNormalDistrVariance;
        private System.Windows.Forms.Label labelNormalDistrExpectedValue;
        private System.Windows.Forms.Label labelDeterminedFlowParams;
        private System.Windows.Forms.NumericUpDown nudDeterminedFlow;
        private System.Windows.Forms.GroupBox gbSelectFlow;
        private System.Windows.Forms.GroupBox gbDeterminedFlowParams;
        private System.Windows.Forms.GroupBox gbRandomFlowParams1;
        private System.Windows.Forms.Label labelChooseDistributionLaw;
        private System.Windows.Forms.GroupBox gbRandomFlowParams2;
        private System.Windows.Forms.GroupBox gbUniformFlowParams;
        private System.Windows.Forms.NumericUpDown nudUniformDistParamA;
        private System.Windows.Forms.Label labelUniformDistParamA;
        private System.Windows.Forms.NumericUpDown nudUniformDistParamB;
        private System.Windows.Forms.Label labelUniformDistParamB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudExponetialDistrLambda;
        private System.Windows.Forms.Label labelExponetialDistrLambda;
    }
}