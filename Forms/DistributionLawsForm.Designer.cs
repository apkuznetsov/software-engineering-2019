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
            this.determinedFlow = new System.Windows.Forms.RadioButton();
            this.randomFlow = new System.Windows.Forms.RadioButton();
            this.determinedFlowInterval = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.distributionLaw = new System.Windows.Forms.ComboBox();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.probabilityToEnter = new System.Windows.Forms.NumericUpDown();
            this.buttonToModelling = new System.Windows.Forms.Button();
            this.exponentialDistributionLambda = new System.Windows.Forms.NumericUpDown();
            this.normalDistributionDispersion = new System.Windows.Forms.NumericUpDown();
            this.normalDistributionPredicted = new System.Windows.Forms.NumericUpDown();
            this.normalDistributionDispersionLabel = new System.Windows.Forms.Label();
            this.exponentialDistributionLambdaLabel = new System.Windows.Forms.Label();
            this.normalDistributionPredictedLabel = new System.Windows.Forms.Label();
            this.uniformDistributionTimeLabel = new System.Windows.Forms.Label();
            this.uniformDistributionTime = new System.Windows.Forms.NumericUpDown();
            this.exponentialDistributionPanel = new System.Windows.Forms.Panel();
            this.normalDistributionPanel = new System.Windows.Forms.Panel();
            this.uniformDistributionPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.determinedFlowInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probabilityToEnter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exponentialDistributionLambda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalDistributionDispersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalDistributionPredicted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniformDistributionTime)).BeginInit();
            this.exponentialDistributionPanel.SuspendLayout();
            this.normalDistributionPanel.SuspendLayout();
            this.uniformDistributionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // determinedFlow
            // 
            this.determinedFlow.AutoSize = true;
            this.determinedFlow.Location = new System.Drawing.Point(25, 64);
            this.determinedFlow.Name = "determinedFlow";
            this.determinedFlow.Size = new System.Drawing.Size(165, 17);
            this.determinedFlow.TabIndex = 0;
            this.determinedFlow.TabStop = true;
            this.determinedFlow.Text = "Детерминированный поток";
            this.determinedFlow.UseVisualStyleBackColor = true;
            this.determinedFlow.CheckedChanged += new System.EventHandler(this.radioButtonDeterminedFlow_CheckedChanged);
            this.determinedFlow.Click += new System.EventHandler(this.radioButtonDeterminedFlow_Click);
            // 
            // randomFlow
            // 
            this.randomFlow.AutoSize = true;
            this.randomFlow.Location = new System.Drawing.Point(25, 139);
            this.randomFlow.Name = "randomFlow";
            this.randomFlow.Size = new System.Drawing.Size(112, 17);
            this.randomFlow.TabIndex = 1;
            this.randomFlow.TabStop = true;
            this.randomFlow.Text = "Случайный поток";
            this.randomFlow.UseVisualStyleBackColor = true;
            this.randomFlow.CheckedChanged += new System.EventHandler(this.radioButtonRandomFlow_CheckedChanged);
            this.randomFlow.Click += new System.EventHandler(this.radioButtonRandomFlow_Click);
            // 
            // determinedFlowInterval
            // 
            this.determinedFlowInterval.Location = new System.Drawing.Point(100, 105);
            this.determinedFlowInterval.Name = "determinedFlowInterval";
            this.determinedFlowInterval.Size = new System.Drawing.Size(45, 20);
            this.determinedFlowInterval.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Интервал";
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
            // distributionLaw
            // 
            this.distributionLaw.FormattingEnabled = true;
            this.distributionLaw.Items.AddRange(new object[] {
            "Равномерный",
            "Нормальный",
            "Показательный"});
            this.distributionLaw.Location = new System.Drawing.Point(166, 175);
            this.distributionLaw.Name = "distributionLaw";
            this.distributionLaw.Size = new System.Drawing.Size(124, 21);
            this.distributionLaw.TabIndex = 6;
            this.distributionLaw.SelectedIndexChanged += new System.EventHandler(this.distributionLaw_SelectedIndexChanged);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Image = global::GasStationMs.App.Properties.Resources.info;
            this.buttonInfo.Location = new System.Drawing.Point(196, 53);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(39, 40);
            this.buttonInfo.TabIndex = 2;
            this.buttonInfo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonInfo.UseVisualStyleBackColor = true;
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
            // uniformDistributionTimeLabel
            // 
            this.uniformDistributionTimeLabel.AutoSize = true;
            this.uniformDistributionTimeLabel.Location = new System.Drawing.Point(4, 14);
            this.uniformDistributionTimeLabel.Name = "uniformDistributionTimeLabel";
            this.uniformDistributionTimeLabel.Size = new System.Drawing.Size(211, 13);
            this.uniformDistributionTimeLabel.TabIndex = 16;
            this.uniformDistributionTimeLabel.Text = "Время между появлением автомобилей";
            this.uniformDistributionTimeLabel.Visible = false;
            this.uniformDistributionTimeLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // uniformDistributionTime
            // 
            this.uniformDistributionTime.DecimalPlaces = 1;
            this.uniformDistributionTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.uniformDistributionTime.Location = new System.Drawing.Point(221, 12);
            this.uniformDistributionTime.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uniformDistributionTime.Name = "uniformDistributionTime";
            this.uniformDistributionTime.Size = new System.Drawing.Size(46, 20);
            this.uniformDistributionTime.TabIndex = 17;
            this.uniformDistributionTime.Visible = false;
            this.uniformDistributionTime.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
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
            this.normalDistributionPanel.Location = new System.Drawing.Point(349, 74);
            this.normalDistributionPanel.Name = "normalDistributionPanel";
            this.normalDistributionPanel.Size = new System.Drawing.Size(253, 100);
            this.normalDistributionPanel.TabIndex = 19;
            this.normalDistributionPanel.Visible = false;
            // 
            // uniformDistributionPanel
            // 
            this.uniformDistributionPanel.Controls.Add(this.uniformDistributionTimeLabel);
            this.uniformDistributionPanel.Controls.Add(this.uniformDistributionTime);
            this.uniformDistributionPanel.Location = new System.Drawing.Point(316, 23);
            this.uniformDistributionPanel.Name = "uniformDistributionPanel";
            this.uniformDistributionPanel.Size = new System.Drawing.Size(286, 45);
            this.uniformDistributionPanel.TabIndex = 20;
            this.uniformDistributionPanel.Visible = false;
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
            // DistributionLaws
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 339);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uniformDistributionPanel);
            this.Controls.Add(this.normalDistributionPanel);
            this.Controls.Add(this.exponentialDistributionPanel);
            this.Controls.Add(this.buttonToModelling);
            this.Controls.Add(this.probabilityToEnter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.distributionLaw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.determinedFlowInterval);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.randomFlow);
            this.Controls.Add(this.determinedFlow);
            this.Name = "DistributionLaws";
            this.Text = "DistributionLaws";
            ((System.ComponentModel.ISupportInitialize)(this.determinedFlowInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probabilityToEnter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exponentialDistributionLambda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalDistributionDispersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalDistributionPredicted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniformDistributionTime)).EndInit();
            this.exponentialDistributionPanel.ResumeLayout(false);
            this.exponentialDistributionPanel.PerformLayout();
            this.normalDistributionPanel.ResumeLayout(false);
            this.normalDistributionPanel.PerformLayout();
            this.uniformDistributionPanel.ResumeLayout(false);
            this.uniformDistributionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton determinedFlow;
        private System.Windows.Forms.RadioButton randomFlow;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.NumericUpDown determinedFlowInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox distributionLaw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown probabilityToEnter;
        private System.Windows.Forms.Button buttonToModelling;
        private System.Windows.Forms.NumericUpDown exponentialDistributionLambda;
        private System.Windows.Forms.NumericUpDown normalDistributionDispersion;
        private System.Windows.Forms.NumericUpDown normalDistributionPredicted;
        private System.Windows.Forms.Label normalDistributionDispersionLabel;
        private System.Windows.Forms.Label exponentialDistributionLambdaLabel;
        private System.Windows.Forms.Label normalDistributionPredictedLabel;
        private System.Windows.Forms.Label uniformDistributionTimeLabel;
        private System.Windows.Forms.NumericUpDown uniformDistributionTime;
        private System.Windows.Forms.Panel exponentialDistributionPanel;
        private System.Windows.Forms.Panel normalDistributionPanel;
        private System.Windows.Forms.Panel uniformDistributionPanel;
        private System.Windows.Forms.Label label4;
    }
}