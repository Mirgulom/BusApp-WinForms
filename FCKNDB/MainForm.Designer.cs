namespace FCKNDB
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.VideoStoreLabel = new System.Windows.Forms.Label();
            this.StartBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VideoStoreLabel
            // 
            this.VideoStoreLabel.AutoSize = true;
            this.VideoStoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.VideoStoreLabel.Font = new System.Drawing.Font("Times New Roman", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.VideoStoreLabel.ForeColor = System.Drawing.Color.Black;
            this.VideoStoreLabel.Location = new System.Drawing.Point(104, -10);
            this.VideoStoreLabel.Name = "VideoStoreLabel";
            this.VideoStoreLabel.Size = new System.Drawing.Size(501, 108);
            this.VideoStoreLabel.TabIndex = 0;
            this.VideoStoreLabel.Text = "Автокасса";
            // 
            // StartBTN
            // 
            this.StartBTN.FlatAppearance.BorderSize = 0;
            this.StartBTN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StartBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartBTN.ForeColor = System.Drawing.Color.Transparent;
            this.StartBTN.Location = new System.Drawing.Point(759, 535);
            this.StartBTN.Name = "StartBTN";
            this.StartBTN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartBTN.Size = new System.Drawing.Size(123, 43);
            this.StartBTN.TabIndex = 1;
            this.StartBTN.Text = "➥";
            this.StartBTN.UseVisualStyleBackColor = true;
            this.StartBTN.Click += new System.EventHandler(this.StartBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(644, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 76);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выполнил: Мирсолихов М\r\nНаправление: Информационные\r\nсистемы и технологии\r\nГруппа" +
    ": АТТ-2003R\r\n";
            // 
            // MainForm
            // 
            this.AcceptButton = this.StartBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 590);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartBTN);
            this.Controls.Add(this.VideoStoreLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(910, 629);
            this.MinimumSize = new System.Drawing.Size(910, 629);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VideoStore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label VideoStoreLabel;
        private Button StartBTN;
        private Label label1;
    }
}