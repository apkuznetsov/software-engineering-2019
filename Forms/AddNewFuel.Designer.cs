namespace GasStationMs.App.Forms
{
    partial class AddNewFuel
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
            this.tbFuelName = new System.Windows.Forms.TextBox();
            this.labelFuelName = new System.Windows.Forms.Label();
            this.labelWrongFuelName = new System.Windows.Forms.Label();
            this.labelCostPerLiter = new System.Windows.Forms.Label();
            this.tbCostPerLiter = new System.Windows.Forms.TextBox();
            this.labelWrongCostPerLiter = new System.Windows.Forms.Label();
            this.btnAddNewFuel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFuelName
            // 
            this.tbFuelName.Location = new System.Drawing.Point(12, 69);
            this.tbFuelName.Name = "tbFuelName";
            this.tbFuelName.Size = new System.Drawing.Size(299, 20);
            this.tbFuelName.TabIndex = 0;
            // 
            // labelFuelName
            // 
            this.labelFuelName.AutoSize = true;
            this.labelFuelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFuelName.Location = new System.Drawing.Point(12, 46);
            this.labelFuelName.Name = "labelFuelName";
            this.labelFuelName.Size = new System.Drawing.Size(83, 20);
            this.labelFuelName.TabIndex = 1;
            this.labelFuelName.Text = "Название";
            // 
            // labelWrongFuelName
            // 
            this.labelWrongFuelName.AutoSize = true;
            this.labelWrongFuelName.ForeColor = System.Drawing.Color.Red;
            this.labelWrongFuelName.Location = new System.Drawing.Point(12, 92);
            this.labelWrongFuelName.Name = "labelWrongFuelName";
            this.labelWrongFuelName.Size = new System.Drawing.Size(96, 13);
            this.labelWrongFuelName.TabIndex = 2;
            this.labelWrongFuelName.Text = "ошибка названия";
            // 
            // labelCostPerLiter
            // 
            this.labelCostPerLiter.AutoSize = true;
            this.labelCostPerLiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCostPerLiter.Location = new System.Drawing.Point(8, 127);
            this.labelCostPerLiter.Name = "labelCostPerLiter";
            this.labelCostPerLiter.Size = new System.Drawing.Size(147, 20);
            this.labelCostPerLiter.TabIndex = 3;
            this.labelCostPerLiter.Text = "Цена за литр, руб.";
            // 
            // tbCostPerLiter
            // 
            this.tbCostPerLiter.Location = new System.Drawing.Point(12, 150);
            this.tbCostPerLiter.Name = "tbCostPerLiter";
            this.tbCostPerLiter.Size = new System.Drawing.Size(299, 20);
            this.tbCostPerLiter.TabIndex = 4;
            // 
            // labelWrongCostPerLiter
            // 
            this.labelWrongCostPerLiter.AutoSize = true;
            this.labelWrongCostPerLiter.ForeColor = System.Drawing.Color.Red;
            this.labelWrongCostPerLiter.Location = new System.Drawing.Point(12, 173);
            this.labelWrongCostPerLiter.Name = "labelWrongCostPerLiter";
            this.labelWrongCostPerLiter.Size = new System.Drawing.Size(74, 13);
            this.labelWrongCostPerLiter.TabIndex = 5;
            this.labelWrongCostPerLiter.Text = "ошибка цены";
            // 
            // btnAddNewFuel
            // 
            this.btnAddNewFuel.Location = new System.Drawing.Point(123, 234);
            this.btnAddNewFuel.Name = "btnAddNewFuel";
            this.btnAddNewFuel.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewFuel.TabIndex = 6;
            this.btnAddNewFuel.Text = "Добавить";
            this.btnAddNewFuel.UseVisualStyleBackColor = true;
            this.btnAddNewFuel.Click += new System.EventHandler(this.btnAddNewFuel_Click);
            // 
            // AddNewFuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 269);
            this.Controls.Add(this.btnAddNewFuel);
            this.Controls.Add(this.labelWrongCostPerLiter);
            this.Controls.Add(this.tbCostPerLiter);
            this.Controls.Add(this.labelCostPerLiter);
            this.Controls.Add(this.labelWrongFuelName);
            this.Controls.Add(this.labelFuelName);
            this.Controls.Add(this.tbFuelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewFuel";
            this.ShowIcon = false;
            this.Text = "Добавление топлива";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFuelName;
        private System.Windows.Forms.Label labelFuelName;
        private System.Windows.Forms.Label labelWrongFuelName;
        private System.Windows.Forms.Label labelCostPerLiter;
        private System.Windows.Forms.TextBox tbCostPerLiter;
        private System.Windows.Forms.Label labelWrongCostPerLiter;
        private System.Windows.Forms.Button btnAddNewFuel;
    }
}