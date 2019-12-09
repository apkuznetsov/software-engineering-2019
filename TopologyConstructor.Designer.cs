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
            this.listFuels = new System.Windows.Forms.ListBox();
            this.textBoxNewFuelName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textBoxNewFuelPrice = new System.Windows.Forms.TextBox();
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
            this.fillingStationField.ColumnHeadersHeight = 29;
            this.fillingStationField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.fillingStationField.ColumnHeadersVisible = false;
            this.fillingStationField.Location = new System.Drawing.Point(28, 66);
            this.fillingStationField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fillingStationField.Name = "fillingStationField";
            this.fillingStationField.RowHeadersWidth = 51;
            this.fillingStationField.Size = new System.Drawing.Size(719, 437);
            this.fillingStationField.TabIndex = 0;
            this.fillingStationField.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fillingStationField_CellClick);
            // 
            // cellsHorizontally
            // 
            this.cellsHorizontally.Location = new System.Drawing.Point(273, 612);
            this.cellsHorizontally.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cellsHorizontally.Name = "cellsHorizontally";
            this.cellsHorizontally.Size = new System.Drawing.Size(160, 22);
            this.cellsHorizontally.TabIndex = 1;
            this.cellsHorizontally.ValueChanged += new System.EventHandler(this.cellsHorizontally_ValueChanged);
            // 
            // cellsVertically
            // 
            this.cellsVertically.Location = new System.Drawing.Point(461, 612);
            this.cellsVertically.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cellsVertically.Name = "cellsVertically";
            this.cellsVertically.Size = new System.Drawing.Size(160, 22);
            this.cellsVertically.TabIndex = 2;
            this.cellsVertically.ValueChanged += new System.EventHandler(this.cellsVertically_ValueChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(807, 225);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 116);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // radioButtonFuelDisplenser
            // 
            this.radioButtonFuelDisplenser.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonFuelDisplenser.AutoSize = true;
            this.radioButtonFuelDisplenser.Image = global::GasStationMs.App.Properties.Resources.fuel2;
            this.radioButtonFuelDisplenser.Location = new System.Drawing.Point(807, 66);
            this.radioButtonFuelDisplenser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.radioButtonFuelTank.Location = new System.Drawing.Point(865, 69);
            this.radioButtonFuelTank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonFuelTank.Name = "radioButtonFuelTank";
            this.radioButtonFuelTank.Size = new System.Drawing.Size(36, 36);
            this.radioButtonFuelTank.TabIndex = 7;
            this.radioButtonFuelTank.TabStop = true;
            this.radioButtonFuelTank.UseVisualStyleBackColor = true;
            this.radioButtonFuelTank.CheckedChanged += new System.EventHandler(this.radioButtonFuelTank_CheckedChanged);
            this.radioButtonFuelTank.Click += new System.EventHandler(this.radioButtonFuelTank_Click);
            // 
            // listFuels
            // 
            this.listFuels.FormattingEnabled = true;
            this.listFuels.ItemHeight = 16;
            this.listFuels.Location = new System.Drawing.Point(807, 371);
            this.listFuels.Name = "listFuels";
            this.listFuels.Size = new System.Drawing.Size(211, 100);
            this.listFuels.TabIndex = 8;
            this.listFuels.SelectedIndexChanged += new System.EventHandler(this.listFuels_SelectedIndexChanged);
            // 
            // textBoxNewFuelName
            // 
            this.textBoxNewFuelName.Location = new System.Drawing.Point(807, 480);
            this.textBoxNewFuelName.Name = "textBoxNewFuelName";
            this.textBoxNewFuelName.Size = new System.Drawing.Size(211, 22);
            this.textBoxNewFuelName.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(807, 544);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(914, 544);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textBoxNewFuelPrice
            // 
            this.textBoxNewFuelPrice.Location = new System.Drawing.Point(807, 508);
            this.textBoxNewFuelPrice.Name = "textBoxNewFuelPrice";
            this.textBoxNewFuelPrice.Size = new System.Drawing.Size(211, 22);
            this.textBoxNewFuelPrice.TabIndex = 9;
            // 
            // TopologyConstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 690);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBoxNewFuelPrice);
            this.Controls.Add(this.textBoxNewFuelName);
            this.Controls.Add(this.listFuels);
            this.Controls.Add(this.radioButtonFuelTank);
            this.Controls.Add(this.radioButtonFuelDisplenser);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cellsVertically);
            this.Controls.Add(this.cellsHorizontally);
            this.Controls.Add(this.fillingStationField);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1061, 728);
            this.Name = "TopologyConstructor";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TopologyConstructor_FormClosing);
            this.Load += new System.EventHandler(this.TopologyConstructor_Load);
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
        private System.Windows.Forms.ListBox listFuels;
        private System.Windows.Forms.TextBox textBoxNewFuelName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textBoxNewFuelPrice;
    }
}

