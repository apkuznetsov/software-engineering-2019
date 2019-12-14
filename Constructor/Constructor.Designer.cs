namespace GasStationMs.App
{
    partial class Constructor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Constructor));
            this.dgvTopology = new System.Windows.Forms.DataGridView();
            this.cellsHorizontally = new System.Windows.Forms.NumericUpDown();
            this.cellsVertically = new System.Windows.Forms.NumericUpDown();
            this.rbFuelDispenser = new System.Windows.Forms.RadioButton();
            this.rbFuelTank = new System.Windows.Forms.RadioButton();
            this.listFuels = new System.Windows.Forms.ListBox();
            this.textBoxNewFuelName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textBoxNewFuelPrice = new System.Windows.Forms.TextBox();
            this.tbClickedCell = new System.Windows.Forms.TextBox();
            this.rbCashCounter = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopology)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsHorizontally)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsVertically)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTopology
            // 
            this.dgvTopology.AllowUserToResizeColumns = false;
            this.dgvTopology.AllowUserToResizeRows = false;
            this.dgvTopology.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTopology.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTopology.ColumnHeadersHeight = 29;
            this.dgvTopology.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTopology.ColumnHeadersVisible = false;
            this.dgvTopology.Location = new System.Drawing.Point(21, 54);
            this.dgvTopology.Name = "dgvTopology";
            this.dgvTopology.RowHeadersWidth = 51;
            this.dgvTopology.Size = new System.Drawing.Size(539, 355);
            this.dgvTopology.TabIndex = 0;
            this.dgvTopology.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTopology_CellMouseClick);
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
            // rbFuelDispenser
            // 
            this.rbFuelDispenser.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbFuelDispenser.AutoSize = true;
            this.rbFuelDispenser.Image = global::GasStationMs.App.Properties.Resources.fuel2;
            this.rbFuelDispenser.Location = new System.Drawing.Point(605, 54);
            this.rbFuelDispenser.Name = "rbFuelDispenser";
            this.rbFuelDispenser.Size = new System.Drawing.Size(38, 38);
            this.rbFuelDispenser.TabIndex = 6;
            this.rbFuelDispenser.TabStop = true;
            this.rbFuelDispenser.UseVisualStyleBackColor = true;
            this.rbFuelDispenser.CheckedChanged += new System.EventHandler(this.radioButtonFuelDispenser_CheckedChanged);
            this.rbFuelDispenser.Click += new System.EventHandler(this.radioButtonFuelDispenser_Click);
            // 
            // rbFuelTank
            // 
            this.rbFuelTank.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbFuelTank.AutoSize = true;
            this.rbFuelTank.Image = global::GasStationMs.App.Properties.Resources.icons8_oil_storage_tank_64_photo_resizer_ru;
            this.rbFuelTank.Location = new System.Drawing.Point(649, 56);
            this.rbFuelTank.Name = "rbFuelTank";
            this.rbFuelTank.Size = new System.Drawing.Size(36, 36);
            this.rbFuelTank.TabIndex = 7;
            this.rbFuelTank.TabStop = true;
            this.rbFuelTank.UseVisualStyleBackColor = true;
            this.rbFuelTank.CheckedChanged += new System.EventHandler(this.radioButtonFuelTank_CheckedChanged);
            this.rbFuelTank.Click += new System.EventHandler(this.radioButtonFuelTank_Click);
            // 
            // listFuels
            // 
            this.listFuels.FormattingEnabled = true;
            this.listFuels.Location = new System.Drawing.Point(605, 301);
            this.listFuels.Margin = new System.Windows.Forms.Padding(2);
            this.listFuels.Name = "listFuels";
            this.listFuels.Size = new System.Drawing.Size(159, 82);
            this.listFuels.TabIndex = 8;
            this.listFuels.SelectedIndexChanged += new System.EventHandler(this.listFuels_SelectedIndexChanged);
            // 
            // textBoxNewFuelName
            // 
            this.textBoxNewFuelName.Location = new System.Drawing.Point(605, 390);
            this.textBoxNewFuelName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNewFuelName.Name = "textBoxNewFuelName";
            this.textBoxNewFuelName.Size = new System.Drawing.Size(159, 20);
            this.textBoxNewFuelName.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(605, 442);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 19);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(686, 442);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 19);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textBoxNewFuelPrice
            // 
            this.textBoxNewFuelPrice.Location = new System.Drawing.Point(605, 413);
            this.textBoxNewFuelPrice.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNewFuelPrice.Name = "textBoxNewFuelPrice";
            this.textBoxNewFuelPrice.Size = new System.Drawing.Size(159, 20);
            this.textBoxNewFuelPrice.TabIndex = 9;
            // 
            // tbClickedCell
            // 
            this.tbClickedCell.Location = new System.Drawing.Point(605, 123);
            this.tbClickedCell.Multiline = true;
            this.tbClickedCell.Name = "tbClickedCell";
            this.tbClickedCell.Size = new System.Drawing.Size(159, 143);
            this.tbClickedCell.TabIndex = 11;
            // 
            // rbCashCounter
            // 
            this.rbCashCounter.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbCashCounter.AutoSize = true;
            this.rbCashCounter.Image = ((System.Drawing.Image)(resources.GetObject("rbCashCounter.Image")));
            this.rbCashCounter.Location = new System.Drawing.Point(691, 56);
            this.rbCashCounter.Name = "rbCashCounter";
            this.rbCashCounter.Size = new System.Drawing.Size(36, 36);
            this.rbCashCounter.TabIndex = 12;
            this.rbCashCounter.TabStop = true;
            this.rbCashCounter.UseVisualStyleBackColor = true;
            this.rbCashCounter.CheckedChanged += new System.EventHandler(this.rbCashCounter_CheckedChanged);
            this.rbCashCounter.Click += new System.EventHandler(this.rbCashCounter_Click);
            // 
            // Constructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.rbCashCounter);
            this.Controls.Add(this.tbClickedCell);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBoxNewFuelPrice);
            this.Controls.Add(this.textBoxNewFuelName);
            this.Controls.Add(this.listFuels);
            this.Controls.Add(this.rbFuelTank);
            this.Controls.Add(this.rbFuelDispenser);
            this.Controls.Add(this.cellsVertically);
            this.Controls.Add(this.cellsHorizontally);
            this.Controls.Add(this.dgvTopology);
            this.MinimumSize = new System.Drawing.Size(800, 599);
            this.Name = "Constructor";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TopologyConstructor_FormClosing);
            this.Load += new System.EventHandler(this.TopologyConstructor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopology)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsHorizontally)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsVertically)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTopology;
        private System.Windows.Forms.NumericUpDown cellsHorizontally;
        private System.Windows.Forms.NumericUpDown cellsVertically;
        private System.Windows.Forms.RadioButton rbFuelDispenser;
        private System.Windows.Forms.RadioButton rbFuelTank;
        private System.Windows.Forms.ListBox listFuels;
        private System.Windows.Forms.TextBox textBoxNewFuelName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textBoxNewFuelPrice;
        private System.Windows.Forms.TextBox tbClickedCell;
        private System.Windows.Forms.RadioButton rbCashCounter;
    }
}

