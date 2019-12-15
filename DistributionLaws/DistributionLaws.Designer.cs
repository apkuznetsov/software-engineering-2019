namespace GasStationMs.App.DistributionLaws
{
    partial class DistributionLaws
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
            this.buttonInfo = new System.Windows.Forms.Button();
            this.determinedFlowInterval = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.distributionLaw = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.determinedFlowInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // determinedFlow
            // 
            this.determinedFlow.AutoSize = true;
            this.determinedFlow.Location = new System.Drawing.Point(66, 37);
            this.determinedFlow.Name = "determinedFlow";
            this.determinedFlow.Size = new System.Drawing.Size(165, 17);
            this.determinedFlow.TabIndex = 0;
            this.determinedFlow.TabStop = true;
            this.determinedFlow.Text = "Детерминированный поток";
            this.determinedFlow.UseVisualStyleBackColor = true;
            this.determinedFlow.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // randomFlow
            // 
            this.randomFlow.AutoSize = true;
            this.randomFlow.Location = new System.Drawing.Point(66, 112);
            this.randomFlow.Name = "randomFlow";
            this.randomFlow.Size = new System.Drawing.Size(112, 17);
            this.randomFlow.TabIndex = 1;
            this.randomFlow.TabStop = true;
            this.randomFlow.Text = "Случайный поток";
            this.randomFlow.UseVisualStyleBackColor = true;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Image = global::GasStationMs.App.Properties.Resources.info;
            this.buttonInfo.Location = new System.Drawing.Point(258, 14);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(39, 40);
            this.buttonInfo.TabIndex = 2;
            this.buttonInfo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonInfo.UseVisualStyleBackColor = true;
            // 
            // determinedFlowInterval
            // 
            this.determinedFlowInterval.Location = new System.Drawing.Point(141, 78);
            this.determinedFlowInterval.Name = "determinedFlowInterval";
            this.determinedFlowInterval.Size = new System.Drawing.Size(45, 20);
            this.determinedFlowInterval.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Интервал";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Закон распределения";
            // 
            // distributionLaw
            // 
            this.distributionLaw.FormattingEnabled = true;
            this.distributionLaw.Items.AddRange(new object[] {
            "Ранвомерный",
            "Нормальный",
            "Показательный"});
            this.distributionLaw.Location = new System.Drawing.Point(207, 148);
            this.distributionLaw.Name = "distributionLaw";
            this.distributionLaw.Size = new System.Drawing.Size(124, 21);
            this.distributionLaw.TabIndex = 6;
            this.distributionLaw.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DistributionLaws
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 339);
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
    }
}