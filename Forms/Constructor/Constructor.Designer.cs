﻿namespace GasStationMs.App.Constructor
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
            this.labelClickedTeName = new System.Windows.Forms.Label();
            this.labelMainTeProperty = new System.Windows.Forms.Label();
            this.numericUpDownVolume = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFuelDispenserSpeed = new System.Windows.Forms.NumericUpDown();
            this.textBoxChosenFuel = new System.Windows.Forms.TextBox();
            this.clickedFuelList = new System.Windows.Forms.ComboBox();
            this.btnToDistributionLawsForm = new System.Windows.Forms.Button();
            this.gbAddFuel = new System.Windows.Forms.GroupBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbTemplateElement = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFuelDispenserSpeed)).BeginInit();
            this.gbAddFuel.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.gbTemplateElement.SuspendLayout();
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
            // labelClickedTeName
            // 
            this.labelClickedTeName.AutoSize = true;
            this.labelClickedTeName.Location = new System.Drawing.Point(5, 16);
            this.labelClickedTeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClickedTeName.Name = "labelClickedTeName";
            this.labelClickedTeName.Size = new System.Drawing.Size(50, 13);
            this.labelClickedTeName.TabIndex = 19;
            this.labelClickedTeName.Text = "TE name";
            // 
            // labelMainTeProperty
            // 
            this.labelMainTeProperty.AutoSize = true;
            this.labelMainTeProperty.Location = new System.Drawing.Point(5, 33);
            this.labelMainTeProperty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMainTeProperty.Name = "labelMainTeProperty";
            this.labelMainTeProperty.Size = new System.Drawing.Size(87, 13);
            this.labelMainTeProperty.TabIndex = 18;
            this.labelMainTeProperty.Text = "TE main property";
            this.labelMainTeProperty.Visible = false;
            // 
            // numericUpDownVolume
            // 
            this.numericUpDownVolume.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownVolume.Location = new System.Drawing.Point(81, 87);
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
            this.numericUpDownFuelDispenserSpeed.Location = new System.Drawing.Point(140, 26);
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
            this.textBoxChosenFuel.Location = new System.Drawing.Point(6, 134);
            this.textBoxChosenFuel.Name = "textBoxChosenFuel";
            this.textBoxChosenFuel.ReadOnly = true;
            this.textBoxChosenFuel.Size = new System.Drawing.Size(63, 20);
            this.textBoxChosenFuel.TabIndex = 14;
            this.textBoxChosenFuel.Visible = false;
            // 
            // clickedFuelList
            // 
            this.clickedFuelList.FormattingEnabled = true;
            this.clickedFuelList.Location = new System.Drawing.Point(84, 133);
            this.clickedFuelList.Name = "clickedFuelList";
            this.clickedFuelList.Size = new System.Drawing.Size(121, 21);
            this.clickedFuelList.TabIndex = 12;
            this.clickedFuelList.Visible = false;
            this.clickedFuelList.SelectionChangeCommitted += new System.EventHandler(this.clickedFuelList_SelectionChangeCommitted);
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
            // gbTemplateElement
            // 
            this.gbTemplateElement.Controls.Add(this.clickedFuelList);
            this.gbTemplateElement.Controls.Add(this.textBoxChosenFuel);
            this.gbTemplateElement.Controls.Add(this.numericUpDownVolume);
            this.gbTemplateElement.Controls.Add(this.labelMainTeProperty);
            this.gbTemplateElement.Controls.Add(this.numericUpDownFuelDispenserSpeed);
            this.gbTemplateElement.Controls.Add(this.labelClickedTeName);
            this.gbTemplateElement.Location = new System.Drawing.Point(561, 69);
            this.gbTemplateElement.Name = "gbTemplateElement";
            this.gbTemplateElement.Size = new System.Drawing.Size(211, 173);
            this.gbTemplateElement.TabIndex = 22;
            this.gbTemplateElement.TabStop = false;
            this.gbTemplateElement.Text = "Информация";
            // 
            // Constructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gbTemplateElement);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFuelDispenserSpeed)).EndInit();
            this.gbAddFuel.ResumeLayout(false);
            this.gbAddFuel.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.gbTemplateElement.ResumeLayout(false);
            this.gbTemplateElement.PerformLayout();
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
        private System.Windows.Forms.ComboBox clickedFuelList;
        private System.Windows.Forms.TextBox textBoxChosenFuel;
        private System.Windows.Forms.NumericUpDown numericUpDownFuelDispenserSpeed;
        private System.Windows.Forms.NumericUpDown numericUpDownVolume;
        private System.Windows.Forms.Label labelMainTeProperty;
        private System.Windows.Forms.Button btnToDistributionLawsForm;
        private System.Windows.Forms.Label labelClickedTeName;
        private System.Windows.Forms.GroupBox gbAddFuel;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbTemplateElement;
    }
}

