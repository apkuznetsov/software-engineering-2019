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
            this.SuspendLayout();
            // 
            // labelChooseFilePath
            // 
            this.labelChooseFilePath.AutoSize = true;
            this.labelChooseFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChooseFilePath.Location = new System.Drawing.Point(12, 79);
            this.labelChooseFilePath.Name = "labelChooseFilePath";
            this.labelChooseFilePath.Size = new System.Drawing.Size(426, 25);
            this.labelChooseFilePath.TabIndex = 0;
            this.labelChooseFilePath.Text = "Задайте расположение файла топологии";
            // 
            // btnFilePath
            // 
            this.btnFilePath.Location = new System.Drawing.Point(494, 83);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(78, 23);
            this.btnFilePath.TabIndex = 1;
            this.btnFilePath.Text = "Обзор";
            this.btnFilePath.UseVisualStyleBackColor = true;
            this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
            // 
            // btnOpenConstructorForm
            // 
            this.btnOpenConstructorForm.Location = new System.Drawing.Point(12, 326);
            this.btnOpenConstructorForm.Name = "btnOpenConstructorForm";
            this.btnOpenConstructorForm.Size = new System.Drawing.Size(560, 23);
            this.btnOpenConstructorForm.TabIndex = 2;
            this.btnOpenConstructorForm.Text = "Создать";
            this.btnOpenConstructorForm.UseVisualStyleBackColor = true;
            this.btnOpenConstructorForm.Click += new System.EventHandler(this.btnOpenConstructorForm_Click);
            // 
            // CreatingTopologyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnOpenConstructorForm);
            this.Controls.Add(this.btnFilePath);
            this.Controls.Add(this.labelChooseFilePath);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreatingTopologyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание топологии";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChooseFilePath;
        private System.Windows.Forms.Button btnFilePath;
        private System.Windows.Forms.Button btnOpenConstructorForm;
    }
}