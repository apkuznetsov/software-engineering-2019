namespace software_engineering_2019
{
    partial class TopologyConstructor
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.fillingStationField = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.fillingStationField)).BeginInit();
            this.SuspendLayout();
            // 
            // fillingStationField
            // 
            this.fillingStationField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fillingStationField.Location = new System.Drawing.Point(21, 54);
            this.fillingStationField.Name = "fillingStationField";
            this.fillingStationField.Size = new System.Drawing.Size(539, 355);
            this.fillingStationField.TabIndex = 0;
            // 
            // TopologyConstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.fillingStationField);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "TopologyConstructor";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fillingStationField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView fillingStationField;
    }
}

