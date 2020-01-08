namespace GasStationMs.App.Constructor
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
            this.dgvField = new System.Windows.Forms.DataGridView();
            this.rbFuelDispenser = new System.Windows.Forms.RadioButton();
            this.rbFuelTank = new System.Windows.Forms.RadioButton();
            this.listFuels = new System.Windows.Forms.ListBox();
            this.textBoxNewFuelName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textBoxNewFuelPrice = new System.Windows.Forms.TextBox();
            this.rbCashCounter = new System.Windows.Forms.RadioButton();
            this.rbEntry = new System.Windows.Forms.RadioButton();
            this.rbExit = new System.Windows.Forms.RadioButton();
            this.labelElementProperty1 = new System.Windows.Forms.Label();
            this.nudElementProperty2 = new System.Windows.Forms.NumericUpDown();
            this.nudElementProperty1 = new System.Windows.Forms.NumericUpDown();
            this.cbFuelList = new System.Windows.Forms.ComboBox();
            this.btnToDistributionLawsForm = new System.Windows.Forms.Button();
            this.gbAddFuel = new System.Windows.Forms.GroupBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbClickedCell = new System.Windows.Forms.GroupBox();
            this.labelElementProperty3 = new System.Windows.Forms.Label();
            this.labelElementProperty2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudElementProperty2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudElementProperty1)).BeginInit();
            this.gbAddFuel.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.gbClickedCell.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvField
            // 
            this.dgvField.AllowDrop = true;
            this.dgvField.AllowUserToAddRows = false;
            this.dgvField.AllowUserToResizeColumns = false;
            this.dgvField.AllowUserToResizeRows = false;
            this.dgvField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvField.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvField.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvField.ColumnHeadersHeight = 29;
            this.dgvField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvField.ColumnHeadersVisible = false;
            this.dgvField.Location = new System.Drawing.Point(12, 27);
            this.dgvField.Name = "dgvField";
            this.dgvField.RowHeadersWidth = 51;
            this.dgvField.Size = new System.Drawing.Size(543, 522);
            this.dgvField.TabIndex = 0;
            this.dgvField.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvField_CellMouseClick);
            this.dgvField.DragDrop += new System.Windows.Forms.DragEventHandler(this.DataGridView_DragDrop);
            this.dgvField.DragEnter += new System.Windows.Forms.DragEventHandler(this.DataGridView_DragEnter);
            // 
            // rbFuelDispenser
            // 
            this.rbFuelDispenser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbFuelDispenser.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbFuelDispenser.AutoSize = true;
            this.rbFuelDispenser.Image = global::GasStationMs.App.Properties.Resources.fuel2;
            this.rbFuelDispenser.Location = new System.Drawing.Point(566, 27);
            this.rbFuelDispenser.Name = "rbFuelDispenser";
            this.rbFuelDispenser.Size = new System.Drawing.Size(38, 38);
            this.rbFuelDispenser.TabIndex = 6;
            this.rbFuelDispenser.TabStop = true;
            this.rbFuelDispenser.UseVisualStyleBackColor = true;
            this.rbFuelDispenser.CheckedChanged += new System.EventHandler(this.radioButtonFuelDispenser_CheckedChanged);
            this.rbFuelDispenser.Click += new System.EventHandler(this.radioButtonFuelDispenser_Click);
            this.rbFuelDispenser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rbFuelDispenser_mouseDown);
            // 
            // rbFuelTank
            // 
            this.rbFuelTank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbFuelTank.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbFuelTank.AutoSize = true;
            this.rbFuelTank.Image = global::GasStationMs.App.Properties.Resources.icons8_oil_storage_tank_64_photo_resizer_ru;
            this.rbFuelTank.Location = new System.Drawing.Point(610, 27);
            this.rbFuelTank.Name = "rbFuelTank";
            this.rbFuelTank.Size = new System.Drawing.Size(36, 36);
            this.rbFuelTank.TabIndex = 7;
            this.rbFuelTank.TabStop = true;
            this.rbFuelTank.UseVisualStyleBackColor = true;
            this.rbFuelTank.CheckedChanged += new System.EventHandler(this.radioButtonFuelTank_CheckedChanged);
            this.rbFuelTank.Click += new System.EventHandler(this.radioButtonFuelTank_Click);
            this.rbFuelTank.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rbFuelTank_mouseDown);
            // 
            // listFuels
            // 
            this.listFuels.FormattingEnabled = true;
            this.listFuels.Location = new System.Drawing.Point(5, 18);
            this.listFuels.Margin = new System.Windows.Forms.Padding(2);
            this.listFuels.Name = "listFuels";
            this.listFuels.Size = new System.Drawing.Size(159, 82);
            this.listFuels.TabIndex = 8;
            this.listFuels.SelectedIndexChanged += new System.EventHandler(this.listFuels_SelectedIndexChanged);
            // 
            // textBoxNewFuelName
            // 
            this.textBoxNewFuelName.Location = new System.Drawing.Point(5, 104);
            this.textBoxNewFuelName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNewFuelName.Name = "textBoxNewFuelName";
            this.textBoxNewFuelName.Size = new System.Drawing.Size(159, 20);
            this.textBoxNewFuelName.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(5, 152);
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
            this.btnDelete.Location = new System.Drawing.Point(108, 152);
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
            this.textBoxNewFuelPrice.Location = new System.Drawing.Point(5, 128);
            this.textBoxNewFuelPrice.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNewFuelPrice.Name = "textBoxNewFuelPrice";
            this.textBoxNewFuelPrice.Size = new System.Drawing.Size(159, 20);
            this.textBoxNewFuelPrice.TabIndex = 9;
            // 
            // rbCashCounter
            // 
            this.rbCashCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbCashCounter.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbCashCounter.AutoSize = true;
            this.rbCashCounter.Image = ((System.Drawing.Image)(resources.GetObject("rbCashCounter.Image")));
            this.rbCashCounter.Location = new System.Drawing.Point(652, 27);
            this.rbCashCounter.Name = "rbCashCounter";
            this.rbCashCounter.Size = new System.Drawing.Size(36, 36);
            this.rbCashCounter.TabIndex = 12;
            this.rbCashCounter.TabStop = true;
            this.rbCashCounter.UseVisualStyleBackColor = true;
            this.rbCashCounter.CheckedChanged += new System.EventHandler(this.rbCashCounter_CheckedChanged);
            this.rbCashCounter.Click += new System.EventHandler(this.rbCashCounter_Click);
            this.rbCashCounter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rbCashCounter_mouseDown);
            // 
            // rbEntry
            // 
            this.rbEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbEntry.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbEntry.AutoSize = true;
            this.rbEntry.Image = global::GasStationMs.App.Properties.Resources.Entry;
            this.rbEntry.Location = new System.Drawing.Point(694, 27);
            this.rbEntry.Name = "rbEntry";
            this.rbEntry.Size = new System.Drawing.Size(36, 36);
            this.rbEntry.TabIndex = 13;
            this.rbEntry.TabStop = true;
            this.rbEntry.UseVisualStyleBackColor = true;
            this.rbEntry.CheckedChanged += new System.EventHandler(this.rbEntry_CheckedChanged);
            this.rbEntry.Click += new System.EventHandler(this.rbEntry_Click);
            this.rbEntry.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rbEntry_mouseDown);
            // 
            // rbExit
            // 
            this.rbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbExit.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbExit.AutoSize = true;
            this.rbExit.Image = global::GasStationMs.App.Properties.Resources.Exit;
            this.rbExit.Location = new System.Drawing.Point(736, 27);
            this.rbExit.Name = "rbExit";
            this.rbExit.Size = new System.Drawing.Size(36, 36);
            this.rbExit.TabIndex = 14;
            this.rbExit.TabStop = true;
            this.rbExit.UseVisualStyleBackColor = true;
            this.rbExit.CheckedChanged += new System.EventHandler(this.rbExit_CheckedChanged);
            this.rbExit.Click += new System.EventHandler(this.rbExit_Click);
            this.rbExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rbExit_mouseDown);
            // 
            // labelElementProperty1
            // 
            this.labelElementProperty1.AutoSize = true;
            this.labelElementProperty1.Location = new System.Drawing.Point(5, 16);
            this.labelElementProperty1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelElementProperty1.Name = "labelElementProperty1";
            this.labelElementProperty1.Size = new System.Drawing.Size(64, 13);
            this.labelElementProperty1.TabIndex = 18;
            this.labelElementProperty1.Text = "Свойство 1";
            this.labelElementProperty1.Visible = false;
            // 
            // nudElementProperty2
            // 
            this.nudElementProperty2.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudElementProperty2.Location = new System.Drawing.Point(138, 40);
            this.nudElementProperty2.Maximum = new decimal(new int[] {
            75000,
            0,
            0,
            0});
            this.nudElementProperty2.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudElementProperty2.Name = "nudElementProperty2";
            this.nudElementProperty2.Size = new System.Drawing.Size(67, 20);
            this.nudElementProperty2.TabIndex = 16;
            this.nudElementProperty2.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudElementProperty2.Visible = false;
            this.nudElementProperty2.ValueChanged += new System.EventHandler(this.nudElementProperty2_ValueChanged);
            // 
            // nudElementProperty1
            // 
            this.nudElementProperty1.Location = new System.Drawing.Point(138, 14);
            this.nudElementProperty1.Maximum = new decimal(new int[] {
            160,
            0,
            0,
            0});
            this.nudElementProperty1.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudElementProperty1.Name = "nudElementProperty1";
            this.nudElementProperty1.Size = new System.Drawing.Size(67, 20);
            this.nudElementProperty1.TabIndex = 15;
            this.nudElementProperty1.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudElementProperty1.Visible = false;
            this.nudElementProperty1.ValueChanged += new System.EventHandler(this.nudElementProperty1_ValueChanged);
            // 
            // cbFuelList
            // 
            this.cbFuelList.FormattingEnabled = true;
            this.cbFuelList.Location = new System.Drawing.Point(6, 85);
            this.cbFuelList.Name = "cbFuelList";
            this.cbFuelList.Size = new System.Drawing.Size(199, 21);
            this.cbFuelList.TabIndex = 12;
            this.cbFuelList.Visible = false;
            this.cbFuelList.SelectionChangeCommitted += new System.EventHandler(this.cbFuelList_SelectionChangeCommitted);
            // 
            // btnToDistributionLawsForm
            // 
            this.btnToDistributionLawsForm.Location = new System.Drawing.Point(6, 175);
            this.btnToDistributionLawsForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnToDistributionLawsForm.Name = "btnToDistributionLawsForm";
            this.btnToDistributionLawsForm.Size = new System.Drawing.Size(158, 50);
            this.btnToDistributionLawsForm.TabIndex = 19;
            this.btnToDistributionLawsForm.Text = "Смоделировать";
            this.btnToDistributionLawsForm.UseVisualStyleBackColor = true;
            this.btnToDistributionLawsForm.Click += new System.EventHandler(this.btnToDistributionLawsForm_Click);
            // 
            // gbAddFuel
            // 
            this.gbAddFuel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAddFuel.Controls.Add(this.btnToDistributionLawsForm);
            this.gbAddFuel.Controls.Add(this.btnDelete);
            this.gbAddFuel.Controls.Add(this.btnAdd);
            this.gbAddFuel.Controls.Add(this.textBoxNewFuelPrice);
            this.gbAddFuel.Controls.Add(this.listFuels);
            this.gbAddFuel.Controls.Add(this.textBoxNewFuelName);
            this.gbAddFuel.Location = new System.Drawing.Point(561, 310);
            this.gbAddFuel.Name = "gbAddFuel";
            this.gbAddFuel.Size = new System.Drawing.Size(211, 239);
            this.gbAddFuel.TabIndex = 20;
            this.gbAddFuel.TabStop = false;
            this.gbAddFuel.Text = "groupBox1";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.mainMenuStrip.TabIndex = 21;
            this.mainMenuStrip.TabStop = true;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // gbClickedCell
            // 
            this.gbClickedCell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbClickedCell.Controls.Add(this.labelElementProperty3);
            this.gbClickedCell.Controls.Add(this.labelElementProperty2);
            this.gbClickedCell.Controls.Add(this.cbFuelList);
            this.gbClickedCell.Controls.Add(this.nudElementProperty2);
            this.gbClickedCell.Controls.Add(this.labelElementProperty1);
            this.gbClickedCell.Controls.Add(this.nudElementProperty1);
            this.gbClickedCell.Location = new System.Drawing.Point(561, 69);
            this.gbClickedCell.Name = "gbClickedCell";
            this.gbClickedCell.Size = new System.Drawing.Size(211, 141);
            this.gbClickedCell.TabIndex = 22;
            this.gbClickedCell.TabStop = false;
            this.gbClickedCell.Text = "Информация";
            // 
            // labelElementProperty3
            // 
            this.labelElementProperty3.AutoSize = true;
            this.labelElementProperty3.CausesValidation = false;
            this.labelElementProperty3.Location = new System.Drawing.Point(5, 69);
            this.labelElementProperty3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelElementProperty3.Name = "labelElementProperty3";
            this.labelElementProperty3.Size = new System.Drawing.Size(64, 13);
            this.labelElementProperty3.TabIndex = 20;
            this.labelElementProperty3.Text = "Свойство 3";
            this.labelElementProperty3.Visible = false;
            // 
            // labelElementProperty2
            // 
            this.labelElementProperty2.AutoSize = true;
            this.labelElementProperty2.CausesValidation = false;
            this.labelElementProperty2.Location = new System.Drawing.Point(5, 42);
            this.labelElementProperty2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelElementProperty2.Name = "labelElementProperty2";
            this.labelElementProperty2.Size = new System.Drawing.Size(64, 13);
            this.labelElementProperty2.TabIndex = 19;
            this.labelElementProperty2.Text = "Свойство 2";
            this.labelElementProperty2.Visible = false;
            // 
            // Constructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gbClickedCell);
            this.Controls.Add(this.rbFuelDispenser);
            this.Controls.Add(this.rbEntry);
            this.Controls.Add(this.rbCashCounter);
            this.Controls.Add(this.rbFuelTank);
            this.Controls.Add(this.rbExit);
            this.Controls.Add(this.gbAddFuel);
            this.Controls.Add(this.dgvField);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Constructor";
            this.ShowIcon = false;
            this.Text = "Конструктор топологии";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TopologyConstructor_FormClosing);
            this.Load += new System.EventHandler(this.TopologyConstructor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudElementProperty2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudElementProperty1)).EndInit();
            this.gbAddFuel.ResumeLayout(false);
            this.gbAddFuel.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.gbClickedCell.ResumeLayout(false);
            this.gbClickedCell.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvField;
        private System.Windows.Forms.RadioButton rbFuelDispenser;
        private System.Windows.Forms.RadioButton rbFuelTank;
        private System.Windows.Forms.ListBox listFuels;
        private System.Windows.Forms.TextBox textBoxNewFuelName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textBoxNewFuelPrice;
        private System.Windows.Forms.RadioButton rbCashCounter;
        private System.Windows.Forms.RadioButton rbEntry;
        private System.Windows.Forms.RadioButton rbExit;
        private System.Windows.Forms.ComboBox cbFuelList;
        private System.Windows.Forms.NumericUpDown nudElementProperty1;
        private System.Windows.Forms.NumericUpDown nudElementProperty2;
        private System.Windows.Forms.Label labelElementProperty1;
        private System.Windows.Forms.Button btnToDistributionLawsForm;
        private System.Windows.Forms.GroupBox gbAddFuel;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbClickedCell;
        private System.Windows.Forms.Label labelElementProperty2;
        private System.Windows.Forms.Label labelElementProperty3;
    }
}

