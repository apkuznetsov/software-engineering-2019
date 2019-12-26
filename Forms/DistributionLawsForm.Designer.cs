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
            this.label2 = new System.Windows.Forms.Label();
            this.cbSelectDistributionLaw = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.probabilityToEnter = new System.Windows.Forms.NumericUpDown();
            this.buttonToModelling = new System.Windows.Forms.Button();
            this.exponentialDistributionLambda = new System.Windows.Forms.NumericUpDown();
            this.normalDistributionDispersion = new System.Windows.Forms.NumericUpDown();
            this.normalDistributionPredicted = new System.Windows.Forms.NumericUpDown();
            this.normalDistributionDispersionLabel = new System.Windows.Forms.Label();
            this.exponentialDistributionLambdaLabel = new System.Windows.Forms.Label();
            this.normalDistributionPredictedLabel = new System.Windows.Forms.Label();
            this.labelDeterminedFlowParams = new System.Windows.Forms.Label();
            this.nudDeterminedFlow = new System.Windows.Forms.NumericUpDown();
            this.exponentialDistributionPanel = new System.Windows.Forms.Panel();
            this.normalDistributionPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.gbSelectFlow = new System.Windows.Forms.GroupBox();
            this.gbDeterminedFlowParams = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.probabilityToEnter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exponentialDistributionLambda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalDistributionDispersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalDistributionPredicted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeterminedFlow)).BeginInit();
            this.exponentialDistributionPanel.SuspendLayout();
            this.normalDistributionPanel.SuspendLayout();
            this.gbSelectFlow.SuspendLayout();
            this.gbDeterminedFlowParams.SuspendLayout();
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
            this.rbRandomFlow.Location = new System.Drawing.Point(6, 68);
            this.rbRandomFlow.Name = "rbRandomFlow";
            this.rbRandomFlow.Size = new System.Drawing.Size(112, 17);
            this.rbRandomFlow.TabIndex = 1;
            this.rbRandomFlow.TabStop = true;
            this.rbRandomFlow.Text = "Случайный поток";
            this.rbRandomFlow.UseVisualStyleBackColor = true;
            this.rbRandomFlow.CheckedChanged += new System.EventHandler(this.rbRandomFlow_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Закон распределения";
            // 
            // cbSelectDistributionLaw
            // 
            this.cbSelectDistributionLaw.FormattingEnabled = true;
            this.cbSelectDistributionLaw.Items.AddRange(new object[] {
            "Равномерный",
            "Нормальный",
            "Показательный"});
            this.cbSelectDistributionLaw.Location = new System.Drawing.Point(166, 175);
            this.cbSelectDistributionLaw.Name = "cbSelectDistributionLaw";
            this.cbSelectDistributionLaw.Size = new System.Drawing.Size(124, 21);
            this.cbSelectDistributionLaw.TabIndex = 6;
            this.cbSelectDistributionLaw.Visible = false;
            this.cbSelectDistributionLaw.SelectedIndexChanged += new System.EventHandler(this.cbSelectDistributionLaw_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 226);
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
            this.probabilityToEnter.Location = new System.Drawing.Point(262, 218);
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
            this.buttonToModelling.Location = new System.Drawing.Point(129, 277);
            this.buttonToModelling.Name = "buttonToModelling";
            this.buttonToModelling.Size = new System.Drawing.Size(357, 23);
            this.buttonToModelling.TabIndex = 9;
            this.buttonToModelling.Text = "Смоделировать";
            this.buttonToModelling.UseVisualStyleBackColor = true;
            this.buttonToModelling.Click += new System.EventHandler(this.buttonToModelling_Click);
            // 
            // exponentialDistributionLambda
            // 
            this.exponentialDistributionLambda.DecimalPlaces = 1;
            this.exponentialDistributionLambda.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.exponentialDistributionLambda.Location = new System.Drawing.Point(243, 15);
            this.exponentialDistributionLambda.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.exponentialDistributionLambda.Name = "exponentialDistributionLambda";
            this.exponentialDistributionLambda.Size = new System.Drawing.Size(46, 20);
            this.exponentialDistributionLambda.TabIndex = 10;
            this.exponentialDistributionLambda.Visible = false;
            this.exponentialDistributionLambda.ValueChanged += new System.EventHandler(this.exponentialDistributionLambda_ValueChanged);
            // 
            // normalDistributionDispersion
            // 
            this.normalDistributionDispersion.DecimalPlaces = 1;
            this.normalDistributionDispersion.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.normalDistributionDispersion.Location = new System.Drawing.Point(192, 24);
            this.normalDistributionDispersion.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.normalDistributionDispersion.Name = "normalDistributionDispersion";
            this.normalDistributionDispersion.Size = new System.Drawing.Size(46, 20);
            this.normalDistributionDispersion.TabIndex = 11;
            this.normalDistributionDispersion.Visible = false;
            // 
            // normalDistributionPredicted
            // 
            this.normalDistributionPredicted.DecimalPlaces = 1;
            this.normalDistributionPredicted.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.normalDistributionPredicted.Location = new System.Drawing.Point(192, 50);
            this.normalDistributionPredicted.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.normalDistributionPredicted.Name = "normalDistributionPredicted";
            this.normalDistributionPredicted.Size = new System.Drawing.Size(46, 20);
            this.normalDistributionPredicted.TabIndex = 12;
            this.normalDistributionPredicted.Visible = false;
            // 
            // normalDistributionDispersionLabel
            // 
            this.normalDistributionDispersionLabel.AutoSize = true;
            this.normalDistributionDispersionLabel.Location = new System.Drawing.Point(10, 26);
            this.normalDistributionDispersionLabel.Name = "normalDistributionDispersionLabel";
            this.normalDistributionDispersionLabel.Size = new System.Drawing.Size(176, 13);
            this.normalDistributionDispersionLabel.TabIndex = 13;
            this.normalDistributionDispersionLabel.Text = "Дисперсия Нормального Закона";
            this.normalDistributionDispersionLabel.Visible = false;
            this.normalDistributionDispersionLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // exponentialDistributionLambdaLabel
            // 
            this.exponentialDistributionLambdaLabel.AutoSize = true;
            this.exponentialDistributionLambdaLabel.Location = new System.Drawing.Point(3, 15);
            this.exponentialDistributionLambdaLabel.Name = "exponentialDistributionLambdaLabel";
            this.exponentialDistributionLambdaLabel.Size = new System.Drawing.Size(234, 13);
            this.exponentialDistributionLambdaLabel.TabIndex = 14;
            this.exponentialDistributionLambdaLabel.Text = "Интенсивоность экспоненциального закона";
            this.exponentialDistributionLambdaLabel.Visible = false;
            this.exponentialDistributionLambdaLabel.Click += new System.EventHandler(this.exponentialDistributionLambdaLabel_Click);
            // 
            // normalDistributionPredictedLabel
            // 
            this.normalDistributionPredictedLabel.AutoSize = true;
            this.normalDistributionPredictedLabel.Location = new System.Drawing.Point(26, 57);
            this.normalDistributionPredictedLabel.Name = "normalDistributionPredictedLabel";
            this.normalDistributionPredictedLabel.Size = new System.Drawing.Size(148, 13);
            this.normalDistributionPredictedLabel.TabIndex = 15;
            this.normalDistributionPredictedLabel.Text = "Математическое Ожидание";
            this.normalDistributionPredictedLabel.Visible = false;
            this.normalDistributionPredictedLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelDeterminedFlowParams
            // 
            this.labelDeterminedFlowParams.AutoSize = true;
            this.labelDeterminedFlowParams.Location = new System.Drawing.Point(6, 28);
            this.labelDeterminedFlowParams.Name = "labelDeterminedFlowParams";
            this.labelDeterminedFlowParams.Size = new System.Drawing.Size(211, 13);
            this.labelDeterminedFlowParams.TabIndex = 16;
            this.labelDeterminedFlowParams.Text = "Время между появлением автомобилей";
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
            this.nudDeterminedFlow.Location = new System.Drawing.Point(223, 26);
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
            // exponentialDistributionPanel
            // 
            this.exponentialDistributionPanel.Controls.Add(this.exponentialDistributionLambdaLabel);
            this.exponentialDistributionPanel.Controls.Add(this.exponentialDistributionLambda);
            this.exponentialDistributionPanel.Location = new System.Drawing.Point(307, 190);
            this.exponentialDistributionPanel.Name = "exponentialDistributionPanel";
            this.exponentialDistributionPanel.Size = new System.Drawing.Size(306, 49);
            this.exponentialDistributionPanel.TabIndex = 18;
            this.exponentialDistributionPanel.Visible = false;
            // 
            // normalDistributionPanel
            // 
            this.normalDistributionPanel.Controls.Add(this.normalDistributionDispersionLabel);
            this.normalDistributionPanel.Controls.Add(this.normalDistributionDispersion);
            this.normalDistributionPanel.Controls.Add(this.normalDistributionPredicted);
            this.normalDistributionPanel.Controls.Add(this.normalDistributionPredictedLabel);
            this.normalDistributionPanel.Location = new System.Drawing.Point(360, 88);
            this.normalDistributionPanel.Name = "normalDistributionPanel";
            this.normalDistributionPanel.Size = new System.Drawing.Size(253, 100);
            this.normalDistributionPanel.TabIndex = 19;
            this.normalDistributionPanel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Для проверки генерации";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // gbSelectFlow
            // 
            this.gbSelectFlow.Controls.Add(this.rbDeterminedFlow);
            this.gbSelectFlow.Controls.Add(this.rbRandomFlow);
            this.gbSelectFlow.Location = new System.Drawing.Point(12, 18);
            this.gbSelectFlow.Name = "gbSelectFlow";
            this.gbSelectFlow.Size = new System.Drawing.Size(200, 100);
            this.gbSelectFlow.TabIndex = 22;
            this.gbSelectFlow.TabStop = false;
            // 
            // gbDeterminedFlowParams
            // 
            this.gbDeterminedFlowParams.Controls.Add(this.nudDeterminedFlow);
            this.gbDeterminedFlowParams.Controls.Add(this.labelDeterminedFlowParams);
            this.gbDeterminedFlowParams.Location = new System.Drawing.Point(227, 21);
            this.gbDeterminedFlowParams.Name = "gbDeterminedFlowParams";
            this.gbDeterminedFlowParams.Size = new System.Drawing.Size(369, 61);
            this.gbDeterminedFlowParams.TabIndex = 23;
            this.gbDeterminedFlowParams.TabStop = false;
            this.gbDeterminedFlowParams.Text = "Параметры детерминированного потока";
            // 
            // DistributionLawsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 339);
            this.Controls.Add(this.gbDeterminedFlowParams);
            this.Controls.Add(this.gbSelectFlow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.normalDistributionPanel);
            this.Controls.Add(this.exponentialDistributionPanel);
            this.Controls.Add(this.buttonToModelling);
            this.Controls.Add(this.probabilityToEnter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSelectDistributionLaw);
            this.Controls.Add(this.label2);
            this.Name = "DistributionLawsForm";
            this.Text = "DistributionLaws";
            ((System.ComponentModel.ISupportInitialize)(this.probabilityToEnter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exponentialDistributionLambda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalDistributionDispersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalDistributionPredicted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeterminedFlow)).EndInit();
            this.exponentialDistributionPanel.ResumeLayout(false);
            this.exponentialDistributionPanel.PerformLayout();
            this.normalDistributionPanel.ResumeLayout(false);
            this.normalDistributionPanel.PerformLayout();
            this.gbSelectFlow.ResumeLayout(false);
            this.gbSelectFlow.PerformLayout();
            this.gbDeterminedFlowParams.ResumeLayout(false);
            this.gbDeterminedFlowParams.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDeterminedFlow;
        private System.Windows.Forms.RadioButton rbRandomFlow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSelectDistributionLaw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown probabilityToEnter;
        private System.Windows.Forms.Button buttonToModelling;
        private System.Windows.Forms.NumericUpDown exponentialDistributionLambda;
        private System.Windows.Forms.NumericUpDown normalDistributionDispersion;
        private System.Windows.Forms.NumericUpDown normalDistributionPredicted;
        private System.Windows.Forms.Label normalDistributionDispersionLabel;
        private System.Windows.Forms.Label exponentialDistributionLambdaLabel;
        private System.Windows.Forms.Label normalDistributionPredictedLabel;
        private System.Windows.Forms.Label labelDeterminedFlowParams;
        private System.Windows.Forms.NumericUpDown nudDeterminedFlow;
        private System.Windows.Forms.Panel exponentialDistributionPanel;
        private System.Windows.Forms.Panel normalDistributionPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbSelectFlow;
        private System.Windows.Forms.GroupBox gbDeterminedFlowParams;
    }
}