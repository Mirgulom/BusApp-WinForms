namespace FCKNDB
{
    partial class InfoForm
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
            this.Resultsgbx = new System.Windows.Forms.GroupBox();
            this.resultsdgv = new System.Windows.Forms.DataGridView();
            this.Resultsgbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Resultsgbx
            // 
            this.Resultsgbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Resultsgbx.AutoSize = true;
            this.Resultsgbx.Controls.Add(this.resultsdgv);
            this.Resultsgbx.Location = new System.Drawing.Point(1, -3);
            this.Resultsgbx.Name = "Resultsgbx";
            this.Resultsgbx.Size = new System.Drawing.Size(795, 455);
            this.Resultsgbx.TabIndex = 10;
            this.Resultsgbx.TabStop = false;
            this.Resultsgbx.Text = "Результаты поиска";
            // 
            // resultsdgv
            // 
            this.resultsdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsdgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsdgv.Location = new System.Drawing.Point(3, 19);
            this.resultsdgv.Name = "resultsdgv";
            this.resultsdgv.RowHeadersWidth = 51;
            this.resultsdgv.RowTemplate.Height = 25;
            this.resultsdgv.Size = new System.Drawing.Size(789, 433);
            this.resultsdgv.TabIndex = 8;
            this.resultsdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultsdgv_CellContentClick);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Resultsgbx);
            this.Name = "InfoForm";
            this.Text = "InfoForm";
            this.Resultsgbx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultsdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox Resultsgbx;
        private DataGridView resultsdgv;
    }
}