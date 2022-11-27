namespace GasStationMs.App.Forms
{
    partial class AboutDevs
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
            this.tbAboutDevs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbAboutDevs
            // 
            this.tbAboutDevs.Location = new System.Drawing.Point(12, 12);
            this.tbAboutDevs.Multiline = true;
            this.tbAboutDevs.Name = "tbAboutDevs";
            this.tbAboutDevs.ReadOnly = true;
            this.tbAboutDevs.Size = new System.Drawing.Size(362, 328);
            this.tbAboutDevs.TabIndex = 0;
            // 
            // AboutDevs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 352);
            this.Controls.Add(this.tbAboutDevs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDevs";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О разработчиках";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAboutDevs;
    }
}