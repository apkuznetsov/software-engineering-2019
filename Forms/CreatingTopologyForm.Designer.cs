namespace GasStationMs.App.Forms
{
    partial class CreatingTopologyForm
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
            this.labelChooseFilePath = new System.Windows.Forms.Label();
            this.btnFilePath = new System.Windows.Forms.Button();
            this.btnOpenConstructorForm = new System.Windows.Forms.Button();
            this.labelChooseColsCount = new System.Windows.Forms.Label();
            this.nudChooseColsCount = new System.Windows.Forms.NumericUpDown();
            this.nudChooseRowsCount = new System.Windows.Forms.NumericUpDown();
            this.labelChooseRowsCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudChooseColsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChooseRowsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // labelChooseFilePath
            // 
            this.labelChooseFilePath.AutoSize = true;
            this.labelChooseFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChooseFilePath.Location = new System.Drawing.Point(12, 45);
            this.labelChooseFilePath.Name = "labelChooseFilePath";
            this.labelChooseFilePath.Size = new System.Drawing.Size(260, 20);
            this.labelChooseFilePath.TabIndex = 0;
            this.labelChooseFilePath.Text = "Расположение файла топологии";
            // 
            // btnFilePath
            // 
            this.btnFilePath.Location = new System.Drawing.Point(12, 68);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(258, 23);
            this.btnFilePath.TabIndex = 1;
            this.btnFilePath.Text = "Выбрать";
            this.btnFilePath.UseVisualStyleBackColor = true;
            this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
            // 
            // btnOpenConstructorForm
            // 
            this.btnOpenConstructorForm.Location = new System.Drawing.Point(12, 201);
            this.btnOpenConstructorForm.Name = "btnOpenConstructorForm";
            this.btnOpenConstructorForm.Size = new System.Drawing.Size(258, 23);
            this.btnOpenConstructorForm.TabIndex = 2;
            this.btnOpenConstructorForm.Text = "Создать";
            this.btnOpenConstructorForm.UseVisualStyleBackColor = true;
            this.btnOpenConstructorForm.Click += new System.EventHandler(this.btnOpenConstructorForm_Click);
            // 
            // labelChooseColsCount
            // 
            this.labelChooseColsCount.AutoSize = true;
            this.labelChooseColsCount.Location = new System.Drawing.Point(9, 119);
            this.labelChooseColsCount.Name = "labelChooseColsCount";
            this.labelChooseColsCount.Size = new System.Drawing.Size(116, 13);
            this.labelChooseColsCount.TabIndex = 3;
            this.labelChooseColsCount.Text = "Количество столбцов";
            // 
            // nudChooseColsCount
            // 
            this.nudChooseColsCount.Location = new System.Drawing.Point(12, 135);
            this.nudChooseColsCount.Name = "nudChooseColsCount";
            this.nudChooseColsCount.Size = new System.Drawing.Size(120, 20);
            this.nudChooseColsCount.TabIndex = 4;
            // 
            // nudChooseRowsCount
            // 
            this.nudChooseRowsCount.Location = new System.Drawing.Point(150, 135);
            this.nudChooseRowsCount.Name = "nudChooseRowsCount";
            this.nudChooseRowsCount.Size = new System.Drawing.Size(120, 20);
            this.nudChooseRowsCount.TabIndex = 6;
            // 
            // labelChooseRowsCount
            // 
            this.labelChooseRowsCount.AutoSize = true;
            this.labelChooseRowsCount.Location = new System.Drawing.Point(147, 119);
            this.labelChooseRowsCount.Name = "labelChooseRowsCount";
            this.labelChooseRowsCount.Size = new System.Drawing.Size(116, 13);
            this.labelChooseRowsCount.TabIndex = 5;
            this.labelChooseRowsCount.Text = "Количество столбцов";
            // 
            // CreatingTopologyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 236);
            this.Controls.Add(this.nudChooseRowsCount);
            this.Controls.Add(this.labelChooseRowsCount);
            this.Controls.Add(this.nudChooseColsCount);
            this.Controls.Add(this.labelChooseColsCount);
            this.Controls.Add(this.btnOpenConstructorForm);
            this.Controls.Add(this.btnFilePath);
            this.Controls.Add(this.labelChooseFilePath);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreatingTopologyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание топологии";
            ((System.ComponentModel.ISupportInitialize)(this.nudChooseColsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChooseRowsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChooseFilePath;
        private System.Windows.Forms.Button btnFilePath;
        private System.Windows.Forms.Button btnOpenConstructorForm;
        private System.Windows.Forms.Label labelChooseColsCount;
        private System.Windows.Forms.NumericUpDown nudChooseColsCount;
        private System.Windows.Forms.NumericUpDown nudChooseRowsCount;
        private System.Windows.Forms.Label labelChooseRowsCount;
    }
}