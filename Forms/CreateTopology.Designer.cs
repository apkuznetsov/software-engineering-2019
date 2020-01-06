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
            this.labelChooseColsCount = new System.Windows.Forms.Label();
            this.nudChooseColsCount = new System.Windows.Forms.NumericUpDown();
            this.nudChooseRowsCount = new System.Windows.Forms.NumericUpDown();
            this.labelChooseRowsCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudChooseColsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChooseRowsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // labelChooseFullFilePath
            // 
            this.labelChooseFullFilePath.AutoSize = true;
            this.labelChooseFullFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChooseFullFilePath.Location = new System.Drawing.Point(12, 45);
            this.labelChooseFullFilePath.Name = "labelChooseFullFilePath";
            this.labelChooseFullFilePath.Size = new System.Drawing.Size(260, 20);
            this.labelChooseFullFilePath.TabIndex = 0;
            this.labelChooseFullFilePath.Text = "Расположение файла топологии";
            // 
            // btnChooseFullFilePath
            // 
            this.btnChooseFullFilePath.Location = new System.Drawing.Point(12, 68);
            this.btnChooseFullFilePath.Name = "btnChooseFullFilePath";
            this.btnChooseFullFilePath.Size = new System.Drawing.Size(258, 23);
            this.btnChooseFullFilePath.TabIndex = 1;
            this.btnChooseFullFilePath.Text = "Выбрать";
            this.btnChooseFullFilePath.UseVisualStyleBackColor = true;
            this.btnChooseFullFilePath.Click += new System.EventHandler(this.btnChooseFullFilePath_Click);
            // 
            // btnOpenConstructor
            // 
            this.btnOpenConstructor.Location = new System.Drawing.Point(12, 201);
            this.btnOpenConstructor.Name = "btnOpenConstructor";
            this.btnOpenConstructor.Size = new System.Drawing.Size(258, 23);
            this.btnOpenConstructor.TabIndex = 2;
            this.btnOpenConstructor.Text = "Создать";
            this.btnOpenConstructor.UseVisualStyleBackColor = true;
            this.btnOpenConstructor.Click += new System.EventHandler(this.btnOpenConstructor_Click);
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
            this.labelChooseRowsCount.Size = new System.Drawing.Size(98, 13);
            this.labelChooseRowsCount.TabIndex = 5;
            this.labelChooseRowsCount.Text = "Количество строк";
            // 
            // CreateTopology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 236);
            this.Controls.Add(this.nudChooseRowsCount);
            this.Controls.Add(this.labelChooseRowsCount);
            this.Controls.Add(this.nudChooseColsCount);
            this.Controls.Add(this.labelChooseColsCount);
            this.Controls.Add(this.btnOpenConstructor);
            this.Controls.Add(this.btnChooseFullFilePath);
            this.Controls.Add(this.labelChooseFullFilePath);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateTopology";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание топологии";
            ((System.ComponentModel.ISupportInitialize)(this.nudChooseColsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChooseRowsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChooseFullFilePath;
        private System.Windows.Forms.Button btnChooseFullFilePath;
        private System.Windows.Forms.Button btnOpenConstructor;
        private System.Windows.Forms.Label labelChooseColsCount;
        private System.Windows.Forms.NumericUpDown nudChooseColsCount;
        private System.Windows.Forms.NumericUpDown nudChooseRowsCount;
        private System.Windows.Forms.Label labelChooseRowsCount;
    }
}