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
            this.cellsHorizontally = new System.Windows.Forms.NumericUpDown();
            this.cellsVertically = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.fillingStationField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsHorizontally)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsVertically)).BeginInit();
            this.SuspendLayout();
            // 
            // fillingStationField
            // 
            this.fillingStationField.AllowUserToResizeColumns = false;
            this.fillingStationField.AllowUserToResizeRows = false;
            this.fillingStationField.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.fillingStationField.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.fillingStationField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.fillingStationField.ColumnHeadersVisible = false;
            this.fillingStationField.Location = new System.Drawing.Point(21, 54);
            this.fillingStationField.Name = "fillingStationField";
            this.fillingStationField.Size = new System.Drawing.Size(539, 355);
            this.fillingStationField.TabIndex = 0;
            // 
            // cellsHorizontally
            // 
            this.cellsHorizontally.Location = new System.Drawing.Point(205, 497);
            this.cellsHorizontally.Name = "cellsHorizontally";
            this.cellsHorizontally.Size = new System.Drawing.Size(120, 20);
            this.cellsHorizontally.TabIndex = 1;
            this.cellsHorizontally.ValueChanged += new System.EventHandler(this.cellsHorizontally_ValueChanged);
            // 
            // cellsVertically
            // 
            this.cellsVertically.Location = new System.Drawing.Point(346, 497);
            this.cellsVertically.Name = "cellsVertically";
            this.cellsVertically.Size = new System.Drawing.Size(120, 20);
            this.cellsVertically.TabIndex = 2;
            this.cellsVertically.ValueChanged += new System.EventHandler(this.cellsVertically_ValueChanged);
            // 
            // TopologyConstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.cellsVertically);
            this.Controls.Add(this.cellsHorizontally);
            this.Controls.Add(this.fillingStationField);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "TopologyConstructor";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fillingStationField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsHorizontally)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsVertically)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView fillingStationField;
        private System.Windows.Forms.NumericUpDown cellsHorizontally;
        private System.Windows.Forms.NumericUpDown cellsVertically;
    }
}

