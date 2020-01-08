namespace GasStationMs.App.Forms
{
    partial class CreateTopology
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
            this.labelChooseFullFilePath = new System.Windows.Forms.Label();
            this.btnChooseFullFilePath = new System.Windows.Forms.Button();
            this.btnOpenConstructor = new System.Windows.Forms.Button();
            this.nudChooseColsCount = new System.Windows.Forms.NumericUpDown();
            this.nudChooseRowsCount = new System.Windows.Forms.NumericUpDown();
            this.gbChooseFullFilePath = new System.Windows.Forms.GroupBox();
            this.gbChooseSize = new System.Windows.Forms.GroupBox();
            this.labelTimes = new System.Windows.Forms.Label();
            this.rbChosenOtherSize = new System.Windows.Forms.RadioButton();
            this.rbChosenBigSize = new System.Windows.Forms.RadioButton();
            this.rbChosenMediumSize = new System.Windows.Forms.RadioButton();
            this.rbChosenSmallSize = new System.Windows.Forms.RadioButton();
            this.gbFullFilePath = new System.Windows.Forms.GroupBox();
            this.labelFullFilePath = new System.Windows.Forms.Label();
            this.tbFullFilePath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudChooseColsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChooseRowsCount)).BeginInit();
            this.gbChooseFullFilePath.SuspendLayout();
            this.gbChooseSize.SuspendLayout();
            this.gbFullFilePath.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelChooseFullFilePath
            // 
            this.labelChooseFullFilePath.AutoSize = true;
            this.labelChooseFullFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChooseFullFilePath.Location = new System.Drawing.Point(6, 23);
            this.labelChooseFullFilePath.Name = "labelChooseFullFilePath";
            this.labelChooseFullFilePath.Size = new System.Drawing.Size(339, 20);
            this.labelChooseFullFilePath.TabIndex = 0;
            this.labelChooseFullFilePath.Text = "Выберите расположение файла топологии";
            // 
            // btnChooseFullFilePath
            // 
            this.btnChooseFullFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChooseFullFilePath.Location = new System.Drawing.Point(351, 21);
            this.btnChooseFullFilePath.Name = "btnChooseFullFilePath";
            this.btnChooseFullFilePath.Size = new System.Drawing.Size(93, 25);
            this.btnChooseFullFilePath.TabIndex = 1;
            this.btnChooseFullFilePath.Text = "Обзор";
            this.btnChooseFullFilePath.UseVisualStyleBackColor = true;
            this.btnChooseFullFilePath.Click += new System.EventHandler(this.btnChooseFullFilePath_Click);
            // 
            // btnOpenConstructor
            // 
            this.btnOpenConstructor.Location = new System.Drawing.Point(12, 319);
            this.btnOpenConstructor.Name = "btnOpenConstructor";
            this.btnOpenConstructor.Size = new System.Drawing.Size(560, 30);
            this.btnOpenConstructor.TabIndex = 2;
            this.btnOpenConstructor.Text = "Создать";
            this.btnOpenConstructor.UseVisualStyleBackColor = true;
            this.btnOpenConstructor.Click += new System.EventHandler(this.btnOpenConstructor_Click);
            // 
            // nudChooseColsCount
            // 
            this.nudChooseColsCount.Location = new System.Drawing.Point(104, 89);
            this.nudChooseColsCount.Name = "nudChooseColsCount";
            this.nudChooseColsCount.Size = new System.Drawing.Size(37, 20);
            this.nudChooseColsCount.TabIndex = 4;
            // 
            // nudChooseRowsCount
            // 
            this.nudChooseRowsCount.Location = new System.Drawing.Point(165, 89);
            this.nudChooseRowsCount.Name = "nudChooseRowsCount";
            this.nudChooseRowsCount.Size = new System.Drawing.Size(40, 20);
            this.nudChooseRowsCount.TabIndex = 6;
            // 
            // gbChooseFullFilePath
            // 
            this.gbChooseFullFilePath.Controls.Add(this.labelChooseFullFilePath);
            this.gbChooseFullFilePath.Controls.Add(this.btnChooseFullFilePath);
            this.gbChooseFullFilePath.Location = new System.Drawing.Point(12, 12);
            this.gbChooseFullFilePath.Name = "gbChooseFullFilePath";
            this.gbChooseFullFilePath.Size = new System.Drawing.Size(560, 63);
            this.gbChooseFullFilePath.TabIndex = 7;
            this.gbChooseFullFilePath.TabStop = false;
            // 
            // gbChooseSize
            // 
            this.gbChooseSize.Controls.Add(this.labelTimes);
            this.gbChooseSize.Controls.Add(this.rbChosenOtherSize);
            this.gbChooseSize.Controls.Add(this.rbChosenBigSize);
            this.gbChooseSize.Controls.Add(this.nudChooseRowsCount);
            this.gbChooseSize.Controls.Add(this.rbChosenMediumSize);
            this.gbChooseSize.Controls.Add(this.rbChosenSmallSize);
            this.gbChooseSize.Controls.Add(this.nudChooseColsCount);
            this.gbChooseSize.Location = new System.Drawing.Point(12, 180);
            this.gbChooseSize.Name = "gbChooseSize";
            this.gbChooseSize.Size = new System.Drawing.Size(560, 118);
            this.gbChooseSize.TabIndex = 8;
            this.gbChooseSize.TabStop = false;
            this.gbChooseSize.Text = "Укажите размер топологии (количество столбцов x количество строк)";
            // 
            // labelTimes
            // 
            this.labelTimes.AutoSize = true;
            this.labelTimes.Location = new System.Drawing.Point(147, 91);
            this.labelTimes.Name = "labelTimes";
            this.labelTimes.Size = new System.Drawing.Size(12, 13);
            this.labelTimes.TabIndex = 7;
            this.labelTimes.Text = "x";
            // 
            // rbChosenOtherSize
            // 
            this.rbChosenOtherSize.AutoSize = true;
            this.rbChosenOtherSize.Location = new System.Drawing.Point(7, 92);
            this.rbChosenOtherSize.Name = "rbChosenOtherSize";
            this.rbChosenOtherSize.Size = new System.Drawing.Size(91, 17);
            this.rbChosenOtherSize.TabIndex = 3;
            this.rbChosenOtherSize.TabStop = true;
            this.rbChosenOtherSize.Text = "Свой размер";
            this.rbChosenOtherSize.UseVisualStyleBackColor = true;
            this.rbChosenOtherSize.CheckedChanged += new System.EventHandler(this.rbChosenOtherSize_CheckedChanged);
            // 
            // rbChosenBigSize
            // 
            this.rbChosenBigSize.AutoSize = true;
            this.rbChosenBigSize.Location = new System.Drawing.Point(7, 68);
            this.rbChosenBigSize.Name = "rbChosenBigSize";
            this.rbChosenBigSize.Size = new System.Drawing.Size(108, 17);
            this.rbChosenBigSize.TabIndex = 2;
            this.rbChosenBigSize.TabStop = true;
            this.rbChosenBigSize.Text = "Большая 30 x 25";
            this.rbChosenBigSize.UseVisualStyleBackColor = true;
            // 
            // rbChosenMediumSize
            // 
            this.rbChosenMediumSize.AutoSize = true;
            this.rbChosenMediumSize.Location = new System.Drawing.Point(7, 44);
            this.rbChosenMediumSize.Name = "rbChosenMediumSize";
            this.rbChosenMediumSize.Size = new System.Drawing.Size(106, 17);
            this.rbChosenMediumSize.TabIndex = 1;
            this.rbChosenMediumSize.TabStop = true;
            this.rbChosenMediumSize.Text = "Средняя 20 x 15";
            this.rbChosenMediumSize.UseVisualStyleBackColor = true;
            // 
            // rbChosenSmallSize
            // 
            this.rbChosenSmallSize.AutoSize = true;
            this.rbChosenSmallSize.Location = new System.Drawing.Point(7, 20);
            this.rbChosenSmallSize.Name = "rbChosenSmallSize";
            this.rbChosenSmallSize.Size = new System.Drawing.Size(114, 17);
            this.rbChosenSmallSize.TabIndex = 0;
            this.rbChosenSmallSize.TabStop = true;
            this.rbChosenSmallSize.Text = "Маленькая 10 x 7";
            this.rbChosenSmallSize.UseVisualStyleBackColor = true;
            // 
            // gbFullFilePath
            // 
            this.gbFullFilePath.Controls.Add(this.tbFullFilePath);
            this.gbFullFilePath.Controls.Add(this.labelFullFilePath);
            this.gbFullFilePath.Location = new System.Drawing.Point(12, 90);
            this.gbFullFilePath.Name = "gbFullFilePath";
            this.gbFullFilePath.Size = new System.Drawing.Size(560, 70);
            this.gbFullFilePath.TabIndex = 9;
            this.gbFullFilePath.TabStop = false;
            // 
            // labelFullFilePath
            // 
            this.labelFullFilePath.AutoSize = true;
            this.labelFullFilePath.Location = new System.Drawing.Point(6, 16);
            this.labelFullFilePath.Name = "labelFullFilePath";
            this.labelFullFilePath.Size = new System.Drawing.Size(172, 13);
            this.labelFullFilePath.TabIndex = 0;
            this.labelFullFilePath.Text = "Расположение файла топологии";
            // 
            // tbFullFilePath
            // 
            this.tbFullFilePath.BackColor = System.Drawing.SystemColors.Control;
            this.tbFullFilePath.ForeColor = System.Drawing.Color.Black;
            this.tbFullFilePath.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbFullFilePath.Location = new System.Drawing.Point(6, 32);
            this.tbFullFilePath.Name = "tbFullFilePath";
            this.tbFullFilePath.Size = new System.Drawing.Size(548, 20);
            this.tbFullFilePath.TabIndex = 1;
            // 
            // CreateTopology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.gbFullFilePath);
            this.Controls.Add(this.gbChooseSize);
            this.Controls.Add(this.gbChooseFullFilePath);
            this.Controls.Add(this.btnOpenConstructor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateTopology";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание топологии";
            ((System.ComponentModel.ISupportInitialize)(this.nudChooseColsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChooseRowsCount)).EndInit();
            this.gbChooseFullFilePath.ResumeLayout(false);
            this.gbChooseFullFilePath.PerformLayout();
            this.gbChooseSize.ResumeLayout(false);
            this.gbChooseSize.PerformLayout();
            this.gbFullFilePath.ResumeLayout(false);
            this.gbFullFilePath.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelChooseFullFilePath;
        private System.Windows.Forms.Button btnChooseFullFilePath;
        private System.Windows.Forms.Button btnOpenConstructor;
        private System.Windows.Forms.NumericUpDown nudChooseColsCount;
        private System.Windows.Forms.NumericUpDown nudChooseRowsCount;
        private System.Windows.Forms.GroupBox gbChooseFullFilePath;
        private System.Windows.Forms.GroupBox gbChooseSize;
        private System.Windows.Forms.RadioButton rbChosenOtherSize;
        private System.Windows.Forms.RadioButton rbChosenBigSize;
        private System.Windows.Forms.RadioButton rbChosenMediumSize;
        private System.Windows.Forms.RadioButton rbChosenSmallSize;
        private System.Windows.Forms.Label labelTimes;
        private System.Windows.Forms.GroupBox gbFullFilePath;
        private System.Windows.Forms.TextBox tbFullFilePath;
        private System.Windows.Forms.Label labelFullFilePath;
    }
}