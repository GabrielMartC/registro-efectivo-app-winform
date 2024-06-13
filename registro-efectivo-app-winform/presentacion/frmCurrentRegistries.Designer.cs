namespace presentation
{
    partial class frmCurrentRegistries
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
            this.dgvRegistries = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistries)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegistries
            // 
            this.dgvRegistries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegistries.Location = new System.Drawing.Point(0, 0);
            this.dgvRegistries.Name = "dgvRegistries";
            this.dgvRegistries.Size = new System.Drawing.Size(800, 450);
            this.dgvRegistries.TabIndex = 0;
            // 
            // frmCurrentRegistries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRegistries);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCurrentRegistries";
            this.Text = "frmCurrentRegistries";
            this.Load += new System.EventHandler(this.frmCurrentRegistries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistries;
    }
}