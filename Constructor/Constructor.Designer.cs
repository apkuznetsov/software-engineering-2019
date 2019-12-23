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
            this.rbEntry = new System.Windows.Forms.RadioButton();
            this.rbExit = new System.Windows.Forms.RadioButton();
            this.panelClickedCell = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownVolume = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFuelDispenserSpeed = new System.Windows.Forms.NumericUpDown();
            this.textBoxChosenFuel = new System.Windows.Forms.TextBox();
            this.clickedFuelList = new System.Windows.Forms.ComboBox();
            this.btnSaveTopology = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnOpenInBrowserAbout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopology)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsHorizontally)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsVertically)).BeginInit();
            this.panelClickedCell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFuelDispenserSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTopology
            // 
            this.dgvTopology.AllowUserToResizeColumns = false;
            this.dgvTopology.AllowUserToAddRows = false;
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
            this.rbFuelDispenser.Location = new System.Drawing.Point(589, 54);
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
            this.rbFuelTank.Location = new System.Drawing.Point(633, 56);
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
            this.tbClickedCell.Location = new System.Drawing.Point(3, 13);
            this.tbClickedCell.Multiline = true;
            this.tbClickedCell.Name = "tbClickedCell";
            this.tbClickedCell.Size = new System.Drawing.Size(106, 21);
            this.tbClickedCell.TabIndex = 11;
            // 
            // rbCashCounter
            // 
            this.rbCashCounter.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbCashCounter.AutoSize = true;
            this.rbCashCounter.Image = ((System.Drawing.Image)(resources.GetObject("rbCashCounter.Image")));
            this.rbCashCounter.Location = new System.Drawing.Point(675, 54);
            this.rbCashCounter.Name = "rbCashCounter";
            this.rbCashCounter.Size = new System.Drawing.Size(36, 36);
            this.rbCashCounter.TabIndex = 12;
            this.rbCashCounter.TabStop = true;
            this.rbCashCounter.UseVisualStyleBackColor = true;
            this.rbCashCounter.CheckedChanged += new System.EventHandler(this.rbCashCounter_CheckedChanged);
            this.rbCashCounter.Click += new System.EventHandler(this.rbCashCounter_Click);
            // 
            // rbEntry
            // 
            this.rbEntry.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbEntry.AutoSize = true;
            this.rbEntry.Image = global::GasStationMs.App.Properties.Resources.Entry;
            this.rbEntry.Location = new System.Drawing.Point(717, 56);
            this.rbEntry.Name = "rbEntry";
            this.rbEntry.Size = new System.Drawing.Size(36, 36);
            this.rbEntry.TabIndex = 13;
            this.rbEntry.TabStop = true;
            this.rbEntry.UseVisualStyleBackColor = true;
            this.rbEntry.CheckedChanged += new System.EventHandler(this.rbEntry_CheckedChanged);
            this.rbEntry.Click += new System.EventHandler(this.rbEntry_Click);
            // 
            // rbExit
            // 
            this.rbExit.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbExit.AutoSize = true;
            this.rbExit.Image = global::GasStationMs.App.Properties.Resources.Exit;
            this.rbExit.Location = new System.Drawing.Point(759, 54);
            this.rbExit.Name = "rbExit";
            this.rbExit.Size = new System.Drawing.Size(36, 36);
            this.rbExit.TabIndex = 14;
            this.rbExit.TabStop = true;
            this.rbExit.UseVisualStyleBackColor = true;
            this.rbExit.CheckedChanged += new System.EventHandler(this.rbExit_CheckedChanged);
            this.rbExit.Click += new System.EventHandler(this.rbExit_Click);
            // 
            // panelClickedCell
            // 
            this.panelClickedCell.Controls.Add(this.label2);
            this.panelClickedCell.Controls.Add(this.label1);
            this.panelClickedCell.Controls.Add(this.numericUpDownVolume);
            this.panelClickedCell.Controls.Add(this.numericUpDownFuelDispenserSpeed);
            this.panelClickedCell.Controls.Add(this.textBoxChosenFuel);
            this.panelClickedCell.Controls.Add(this.clickedFuelList);
            this.panelClickedCell.Controls.Add(this.tbClickedCell);
            this.panelClickedCell.Location = new System.Drawing.Point(566, 130);
            this.panelClickedCell.Name = "panelClickedCell";
            this.panelClickedCell.Size = new System.Drawing.Size(222, 145);
            this.panelClickedCell.TabIndex = 15;
            this.panelClickedCell.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Скорость заправки";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Объем бака";
            this.label1.Visible = false;
            // 
            // numericUpDownVolume
            // 
            this.numericUpDownVolume.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownVolume.Location = new System.Drawing.Point(98, 80);
            this.numericUpDownVolume.Maximum = new decimal(new int[] {
            75000,
            0,
            0,
            0});
            this.numericUpDownVolume.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownVolume.Name = "numericUpDownVolume";
            this.numericUpDownVolume.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownVolume.TabIndex = 16;
            this.numericUpDownVolume.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownVolume.Visible = false;
            this.numericUpDownVolume.ValueChanged += new System.EventHandler(this.numericUpDownVolume_ValueChanged);
            // 
            // numericUpDownFuelDispenserSpeed
            // 
            this.numericUpDownFuelDispenserSpeed.Location = new System.Drawing.Point(151, 54);
            this.numericUpDownFuelDispenserSpeed.Maximum = new decimal(new int[] {
            160,
            0,
            0,
            0});
            this.numericUpDownFuelDispenserSpeed.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownFuelDispenserSpeed.Name = "numericUpDownFuelDispenserSpeed";
            this.numericUpDownFuelDispenserSpeed.Size = new System.Drawing.Size(67, 20);
            this.numericUpDownFuelDispenserSpeed.TabIndex = 15;
            this.numericUpDownFuelDispenserSpeed.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownFuelDispenserSpeed.Visible = false;
            this.numericUpDownFuelDispenserSpeed.ValueChanged += new System.EventHandler(this.numericUpDownFuelDispenserSpeed_ValueChanged);
            // 
            // textBoxChosenFuel
            // 
            this.textBoxChosenFuel.Location = new System.Drawing.Point(3, 107);
            this.textBoxChosenFuel.Name = "textBoxChosenFuel";
            this.textBoxChosenFuel.ReadOnly = true;
            this.textBoxChosenFuel.Size = new System.Drawing.Size(79, 20);
            this.textBoxChosenFuel.TabIndex = 14;
            this.textBoxChosenFuel.Visible = false;
            // 
            // clickedFuelList
            // 
            this.clickedFuelList.FormattingEnabled = true;
            this.clickedFuelList.Location = new System.Drawing.Point(98, 106);
            this.clickedFuelList.Name = "clickedFuelList";
            this.clickedFuelList.Size = new System.Drawing.Size(121, 21);
            this.clickedFuelList.TabIndex = 12;
            this.clickedFuelList.Visible = false;
            this.clickedFuelList.SelectionChangeCommitted += new System.EventHandler(this.clickedFuelList_SelectionChangeCommitted);
            // 
            // btnSaveTopology
            // 
            this.btnSaveTopology.Location = new System.Drawing.Point(13, 13);
            this.btnSaveTopology.Name = "btnSaveTopology";
            this.btnSaveTopology.Size = new System.Drawing.Size(75, 23);
            this.btnSaveTopology.TabIndex = 16;
            this.btnSaveTopology.Text = "Сохранить";
            this.btnSaveTopology.UseVisualStyleBackColor = true;
            this.btnSaveTopology.Click += new System.EventHandler(this.btnSaveTopology_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(94, 13);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(112, 23);
            this.btnSaveAs.TabIndex = 17;
            this.btnSaveAs.Text = "Сохранить как";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnOpenInBrowserAbout
            // 
            this.btnOpenInBrowserAbout.Location = new System.Drawing.Point(212, 13);
            this.btnOpenInBrowserAbout.Name = "btnOpenInBrowserAbout";
            this.btnOpenInBrowserAbout.Size = new System.Drawing.Size(75, 23);
            this.btnOpenInBrowserAbout.TabIndex = 18;
            this.btnOpenInBrowserAbout.Text = "Справка";
            this.btnOpenInBrowserAbout.UseVisualStyleBackColor = true;
            // 
            // Constructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.btnOpenInBrowserAbout);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.btnSaveTopology);
            this.Controls.Add(this.panelClickedCell);
            this.Controls.Add(this.rbExit);
            this.Controls.Add(this.rbEntry);
            this.Controls.Add(this.rbCashCounter);
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
            this.panelClickedCell.ResumeLayout(false);
            this.panelClickedCell.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFuelDispenserSpeed)).EndInit();
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
        private System.Windows.Forms.RadioButton rbEntry;
        private System.Windows.Forms.RadioButton rbExit;
        private System.Windows.Forms.Panel panelClickedCell;
        private System.Windows.Forms.ComboBox clickedFuelList;
        private System.Windows.Forms.TextBox textBoxChosenFuel;
        private System.Windows.Forms.NumericUpDown numericUpDownFuelDispenserSpeed;
        private System.Windows.Forms.NumericUpDown numericUpDownVolume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveTopology;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnOpenInBrowserAbout;
    }
}

