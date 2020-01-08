namespace GasStationMs.App
{
    partial class CreateOrLoadTopology
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
            this.btnOpenCreateTopology = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelAbout = new System.Windows.Forms.Label();
            this.labelDoSomething = new System.Windows.Forms.Label();
            this.btnLoadTopology = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenCreateTopology
            // 
            this.btnOpenCreateTopology.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOpenCreateTopology.Location = new System.Drawing.Point(216, 165);
            this.btnOpenCreateTopology.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenCreateTopology.Name = "btnOpenCreateTopology";
            this.btnOpenCreateTopology.Size = new System.Drawing.Size(127, 24);
            this.btnOpenCreateTopology.TabIndex = 0;
            this.btnOpenCreateTopology.Text = "Создать";
            this.btnOpenCreateTopology.UseVisualStyleBackColor = true;
            this.btnOpenCreateTopology.Click += new System.EventHandler(this.btnOpenCreateTopology_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(239, 296);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelAbout
            // 
            this.labelAbout.AutoSize = true;
            this.labelAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAbout.Location = new System.Drawing.Point(31, 62);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(528, 33);
            this.labelAbout.TabIndex = 2;
            this.labelAbout.Text = "Система моделирования работы АЗС";
            // 
            // labelDoSomething
            // 
            this.labelDoSomething.AutoSize = true;
            this.labelDoSomething.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDoSomething.Location = new System.Drawing.Point(64, 121);
            this.labelDoSomething.Name = "labelDoSomething";
            this.labelDoSomething.Size = new System.Drawing.Size(464, 24);
            this.labelDoSomething.TabIndex = 3;
            this.labelDoSomething.Text = "Создайте топологию АЗС или загрузите из файла";
            // 
            // btnLoadTopology
            // 
            this.btnLoadTopology.Location = new System.Drawing.Point(216, 194);
            this.btnLoadTopology.Name = "btnLoadTopology";
            this.btnLoadTopology.Size = new System.Drawing.Size(127, 23);
            this.btnLoadTopology.TabIndex = 4;
            this.btnLoadTopology.Text = "Загрузить";
            this.btnLoadTopology.UseVisualStyleBackColor = true;
            this.btnLoadTopology.Click += new System.EventHandler(this.btnLoadTopology_Click);
            // 
            // CreateOrLoadTopology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnLoadTopology);
            this.Controls.Add(this.labelDoSomething);
            this.Controls.Add(this.labelAbout);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOpenCreateTopology);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateOrLoadTopology";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Начало работы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenCreateTopology;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.Label labelDoSomething;
        private System.Windows.Forms.Button btnLoadTopology;
    }
}