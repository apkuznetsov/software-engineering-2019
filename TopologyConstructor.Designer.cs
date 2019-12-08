namespace GasStationMs.App
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.radioButtonFuelDisplenser = new System.Windows.Forms.RadioButton();
            this.radioButtonFuelTank = new System.Windows.Forms.RadioButton();
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
            this.fillingStationField.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fillingStationField_CellClick);
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(605, 183);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // radioButtonFuelDisplenser
            // 
            this.radioButtonFuelDisplenser.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonFuelDisplenser.AutoSize = true;
            this.radioButtonFuelDisplenser.Image = global::GasStationMs.App.Properties.Resources.fuel2;
            this.radioButtonFuelDisplenser.Location = new System.Drawing.Point(605, 54);
            this.radioButtonFuelDisplenser.Name = "radioButtonFuelDisplenser";
            this.radioButtonFuelDisplenser.Size = new System.Drawing.Size(38, 38);
            this.radioButtonFuelDisplenser.TabIndex = 6;
            this.radioButtonFuelDisplenser.TabStop = true;
            this.radioButtonFuelDisplenser.UseVisualStyleBackColor = true;
            this.radioButtonFuelDisplenser.CheckedChanged += new System.EventHandler(this.radioButtonFuelDisplenser_CheckedChanged);
            this.radioButtonFuelDisplenser.Click += new System.EventHandler(this.radioButtonFuelDisplenser_Click);
            // 
            // radioButtonFuelTank
            // 
            this.radioButtonFuelTank.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonFuelTank.AutoSize = true;
            this.radioButtonFuelTank.Image = global::GasStationMs.App.Properties.Resources.icons8_oil_storage_tank_64_photo_resizer_ru;
            this.radioButtonFuelTank.Location = new System.Drawing.Point(649, 56);
            this.radioButtonFuelTank.Name = "radioButtonFuelTank";
            this.radioButtonFuelTank.Size = new System.Drawing.Size(36, 36);
            this.radioButtonFuelTank.TabIndex = 7;
            this.radioButtonFuelTank.TabStop = true;
            this.radioButtonFuelTank.UseVisualStyleBackColor = true;
            this.radioButtonFuelTank.CheckedChanged += new System.EventHandler(this.radioButtonFuelTank_CheckedChanged);
            this.radioButtonFuelTank.Click += new System.EventHandler(this.radioButtonFuelTank_Click);
            // 
            // TopologyConstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.radioButtonFuelTank);
            this.Controls.Add(this.radioButtonFuelDisplenser);
            this.Controls.Add(this.listBox1);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView fillingStationField;
        private System.Windows.Forms.NumericUpDown cellsHorizontally;
        private System.Windows.Forms.NumericUpDown cellsVertically;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton radioButtonFuelDisplenser;
        private System.Windows.Forms.RadioButton radioButtonFuelTank;
    }
}

