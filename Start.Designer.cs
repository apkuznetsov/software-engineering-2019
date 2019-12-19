namespace GasStationMs.App
{
    partial class Start
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
            this.btnCreateTopology = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelAbout = new System.Windows.Forms.Label();
            this.labelDoSomething = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateTopology
            // 
            this.btnCreateTopology.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCreateTopology.Location = new System.Drawing.Point(216, 165);
            this.btnCreateTopology.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateTopology.Name = "btnCreateTopology";
            this.btnCreateTopology.Size = new System.Drawing.Size(127, 24);
            this.btnCreateTopology.TabIndex = 0;
            this.btnCreateTopology.Text = "Создать";
            this.btnCreateTopology.UseVisualStyleBackColor = true;
            this.btnCreateTopology.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(239, 296);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Выйти";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(216, 194);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(127, 23);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "Загрузить";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.labelDoSomething);
            this.Controls.Add(this.labelAbout);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateTopology);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Start";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Начало работы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTopology;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.Label labelDoSomething;
        private System.Windows.Forms.Button btnDownload;
    }
}