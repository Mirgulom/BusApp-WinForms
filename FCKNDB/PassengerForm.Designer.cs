namespace FCKNDB
{
    partial class PassengerForm
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
            this.VydIVozpan = new System.Windows.Forms.Panel();
            this.DBEntrygbx = new System.Windows.Forms.GroupBox();
            this.NextEntrybtn = new System.Windows.Forms.Button();
            this.PrevEntrybtn = new System.Windows.Forms.Button();
            this.EntryAtributespan = new System.Windows.Forms.Panel();
            this.numplacetbx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.passnumtbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numsheduletbx = new System.Windows.Forms.TextBox();
            this.phonenumbertbx = new System.Windows.Forms.TextBox();
            this.FullNametbx = new System.Windows.Forms.TextBox();
            this.ClientCodetbx = new System.Windows.Forms.TextBox();
            this.GoBackBtn = new System.Windows.Forms.Button();
            this.DeleteEntrybtn = new System.Windows.Forms.Button();
            this.UpdEntrybtn = new System.Windows.Forms.Button();
            this.AddEntry = new System.Windows.Forms.Button();
            this.Tablegbx = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.countentrieslabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Clientdgvw = new System.Windows.Forms.DataGridView();
            this.VydIVozpan.SuspendLayout();
            this.DBEntrygbx.SuspendLayout();
            this.EntryAtributespan.SuspendLayout();
            this.Tablegbx.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clientdgvw)).BeginInit();
            this.SuspendLayout();
            // 
            // VydIVozpan
            // 
            this.VydIVozpan.Controls.Add(this.DBEntrygbx);
            this.VydIVozpan.Controls.Add(this.Tablegbx);
            this.VydIVozpan.Location = new System.Drawing.Point(1, 1);
            this.VydIVozpan.Name = "VydIVozpan";
            this.VydIVozpan.Size = new System.Drawing.Size(831, 449);
            this.VydIVozpan.TabIndex = 1;
            // 
            // DBEntrygbx
            // 
            this.DBEntrygbx.Controls.Add(this.NextEntrybtn);
            this.DBEntrygbx.Controls.Add(this.PrevEntrybtn);
            this.DBEntrygbx.Controls.Add(this.EntryAtributespan);
            this.DBEntrygbx.Controls.Add(this.GoBackBtn);
            this.DBEntrygbx.Controls.Add(this.DeleteEntrybtn);
            this.DBEntrygbx.Controls.Add(this.UpdEntrybtn);
            this.DBEntrygbx.Controls.Add(this.AddEntry);
            this.DBEntrygbx.Location = new System.Drawing.Point(534, 11);
            this.DBEntrygbx.Name = "DBEntrygbx";
            this.DBEntrygbx.Size = new System.Drawing.Size(294, 435);
            this.DBEntrygbx.TabIndex = 1;
            this.DBEntrygbx.TabStop = false;
            this.DBEntrygbx.Text = "Запись";
            // 
            // NextEntrybtn
            // 
            this.NextEntrybtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NextEntrybtn.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NextEntrybtn.Location = new System.Drawing.Point(210, 400);
            this.NextEntrybtn.Name = "NextEntrybtn";
            this.NextEntrybtn.Size = new System.Drawing.Size(75, 29);
            this.NextEntrybtn.TabIndex = 8;
            this.NextEntrybtn.Text = "🡆";
            this.NextEntrybtn.UseVisualStyleBackColor = true;
            this.NextEntrybtn.Click += new System.EventHandler(this.NextEntrybtn_Click);
            // 
            // PrevEntrybtn
            // 
            this.PrevEntrybtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PrevEntrybtn.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrevEntrybtn.Location = new System.Drawing.Point(6, 400);
            this.PrevEntrybtn.Name = "PrevEntrybtn";
            this.PrevEntrybtn.Size = new System.Drawing.Size(75, 29);
            this.PrevEntrybtn.TabIndex = 7;
            this.PrevEntrybtn.Text = "🡄";
            this.PrevEntrybtn.UseVisualStyleBackColor = true;
            this.PrevEntrybtn.Click += new System.EventHandler(this.PrevEntrybtn_Click);
            // 
            // EntryAtributespan
            // 
            this.EntryAtributespan.AutoScroll = true;
            this.EntryAtributespan.Controls.Add(this.numplacetbx);
            this.EntryAtributespan.Controls.Add(this.label9);
            this.EntryAtributespan.Controls.Add(this.label1);
            this.EntryAtributespan.Controls.Add(this.label2);
            this.EntryAtributespan.Controls.Add(this.label4);
            this.EntryAtributespan.Controls.Add(this.label6);
            this.EntryAtributespan.Controls.Add(this.passnumtbx);
            this.EntryAtributespan.Controls.Add(this.label5);
            this.EntryAtributespan.Controls.Add(this.numsheduletbx);
            this.EntryAtributespan.Controls.Add(this.phonenumbertbx);
            this.EntryAtributespan.Controls.Add(this.FullNametbx);
            this.EntryAtributespan.Controls.Add(this.ClientCodetbx);
            this.EntryAtributespan.Location = new System.Drawing.Point(6, 14);
            this.EntryAtributespan.Name = "EntryAtributespan";
            this.EntryAtributespan.Size = new System.Drawing.Size(282, 346);
            this.EntryAtributespan.TabIndex = 6;
            // 
            // numplacetbx
            // 
            this.numplacetbx.Location = new System.Drawing.Point(120, 217);
            this.numplacetbx.Name = "numplacetbx";
            this.numplacetbx.Size = new System.Drawing.Size(153, 23);
            this.numplacetbx.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "№ места";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Код пассажира";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "ФИО";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "№ паспорта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Телефон";
            // 
            // passnumtbx
            // 
            this.passnumtbx.Location = new System.Drawing.Point(120, 179);
            this.passnumtbx.Name = "passnumtbx";
            this.passnumtbx.Size = new System.Drawing.Size(153, 23);
            this.passnumtbx.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "№ рейса";
            // 
            // numsheduletbx
            // 
            this.numsheduletbx.Location = new System.Drawing.Point(120, 137);
            this.numsheduletbx.Name = "numsheduletbx";
            this.numsheduletbx.Size = new System.Drawing.Size(153, 23);
            this.numsheduletbx.TabIndex = 13;
            // 
            // phonenumbertbx
            // 
            this.phonenumbertbx.Location = new System.Drawing.Point(120, 95);
            this.phonenumbertbx.Name = "phonenumbertbx";
            this.phonenumbertbx.Size = new System.Drawing.Size(153, 23);
            this.phonenumbertbx.TabIndex = 12;
            // 
            // FullNametbx
            // 
            this.FullNametbx.Location = new System.Drawing.Point(120, 53);
            this.FullNametbx.Name = "FullNametbx";
            this.FullNametbx.Size = new System.Drawing.Size(153, 23);
            this.FullNametbx.TabIndex = 11;
            // 
            // ClientCodetbx
            // 
            this.ClientCodetbx.Location = new System.Drawing.Point(120, 11);
            this.ClientCodetbx.Name = "ClientCodetbx";
            this.ClientCodetbx.Size = new System.Drawing.Size(153, 23);
            this.ClientCodetbx.TabIndex = 10;
            // 
            // GoBackBtn
            // 
            this.GoBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GoBackBtn.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GoBackBtn.Location = new System.Drawing.Point(108, 400);
            this.GoBackBtn.Name = "GoBackBtn";
            this.GoBackBtn.Size = new System.Drawing.Size(75, 29);
            this.GoBackBtn.TabIndex = 3;
            this.GoBackBtn.Text = "Выход";
            this.GoBackBtn.UseVisualStyleBackColor = true;
            this.GoBackBtn.Click += new System.EventHandler(this.GoBackBtn_Click);
            // 
            // DeleteEntrybtn
            // 
            this.DeleteEntrybtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DeleteEntrybtn.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteEntrybtn.Location = new System.Drawing.Point(210, 366);
            this.DeleteEntrybtn.Name = "DeleteEntrybtn";
            this.DeleteEntrybtn.Size = new System.Drawing.Size(75, 29);
            this.DeleteEntrybtn.TabIndex = 2;
            this.DeleteEntrybtn.Text = "Удалить";
            this.DeleteEntrybtn.UseVisualStyleBackColor = true;
            this.DeleteEntrybtn.Click += new System.EventHandler(this.DeleteEntrybtn_Click);
            // 
            // UpdEntrybtn
            // 
            this.UpdEntrybtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UpdEntrybtn.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdEntrybtn.Location = new System.Drawing.Point(108, 366);
            this.UpdEntrybtn.Name = "UpdEntrybtn";
            this.UpdEntrybtn.Size = new System.Drawing.Size(75, 29);
            this.UpdEntrybtn.TabIndex = 1;
            this.UpdEntrybtn.Text = "Обновить";
            this.UpdEntrybtn.UseVisualStyleBackColor = true;
            this.UpdEntrybtn.Click += new System.EventHandler(this.UpdEntrybtn_Click);
            // 
            // AddEntry
            // 
            this.AddEntry.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddEntry.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddEntry.Location = new System.Drawing.Point(6, 366);
            this.AddEntry.Name = "AddEntry";
            this.AddEntry.Size = new System.Drawing.Size(75, 29);
            this.AddEntry.TabIndex = 0;
            this.AddEntry.Text = "Добавить";
            this.AddEntry.UseVisualStyleBackColor = true;
            this.AddEntry.Click += new System.EventHandler(this.AddEntry_Click);
            // 
            // Tablegbx
            // 
            this.Tablegbx.Controls.Add(this.statusStrip1);
            this.Tablegbx.Controls.Add(this.Clientdgvw);
            this.Tablegbx.Location = new System.Drawing.Point(3, 3);
            this.Tablegbx.Name = "Tablegbx";
            this.Tablegbx.Size = new System.Drawing.Size(525, 443);
            this.Tablegbx.TabIndex = 0;
            this.Tablegbx.TabStop = false;
            this.Tablegbx.Text = "Таблица";
            this.Tablegbx.Enter += new System.EventHandler(this.Tablegbx_Enter);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.countentrieslabel});
            this.statusStrip1.Location = new System.Drawing.Point(3, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(519, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(119, 17);
            this.toolStripStatusLabel1.Text = "Количество записей";
            // 
            // countentrieslabel
            // 
            this.countentrieslabel.Name = "countentrieslabel";
            this.countentrieslabel.Size = new System.Drawing.Size(0, 17);
            // 
            // Clientdgvw
            // 
            this.Clientdgvw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Clientdgvw.Location = new System.Drawing.Point(7, 14);
            this.Clientdgvw.Name = "Clientdgvw";
            this.Clientdgvw.RowHeadersWidth = 51;
            this.Clientdgvw.RowTemplate.Height = 25;
            this.Clientdgvw.Size = new System.Drawing.Size(511, 389);
            this.Clientdgvw.TabIndex = 1;
            this.Clientdgvw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Clientdgvw_CellContentClick_1);
            // 
            // PassengerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GoBackBtn;
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.VydIVozpan);
            this.MaximizeBox = false;
            this.Name = "PassengerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PassengerForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.VydIVozpan.ResumeLayout(false);
            this.DBEntrygbx.ResumeLayout(false);
            this.EntryAtributespan.ResumeLayout(false);
            this.EntryAtributespan.PerformLayout();
            this.Tablegbx.ResumeLayout(false);
            this.Tablegbx.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clientdgvw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel VydIVozpan;
        private GroupBox DBEntrygbx;
        private Button GoBackBtn;
        private Button DeleteEntrybtn;
        private Button UpdEntrybtn;
        private Button AddEntry;
        private GroupBox Tablegbx;
        private Panel EntryAtributespan;
        private Label label1;
        private Label label2;
        private TextBox textBox7;
        private Label label4;
        private TextBox textBox8;
        private Label label3;
        private TextBox textBox5;
        private Label label6;
        private TextBox passnumtbx;
        private Label label5;
        private TextBox numsheduletbx;
        private Label label8;
        private TextBox phonenumbertbx;
        private Label label7;
        private TextBox FullNametbx;
        private TextBox ClientCodetbx;
        private DataGridView Clientdgvw;
        private Button NextEntrybtn;
        private Button PrevEntrybtn;
        private TextBox numplacetbx;
        private Label label9;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel countentrieslabel;
    }
}