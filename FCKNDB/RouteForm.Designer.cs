namespace FCKNDB
{
    partial class RouteForm
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
            this.GoBackBtn = new System.Windows.Forms.Button();
            this.NextEntrybtn = new System.Windows.Forms.Button();
            this.PrevEntrybtn = new System.Windows.Forms.Button();
            this.EntryAtributespan = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.routetbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.citycodetbx = new System.Windows.Forms.TextBox();
            this.routecodetbx = new System.Windows.Forms.TextBox();
            this.DeleteEntrybtn = new System.Windows.Forms.Button();
            this.UpdEntrybtn = new System.Windows.Forms.Button();
            this.AddEntry = new System.Windows.Forms.Button();
            this.Tablegbx = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.countentrieslabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Genredgvw = new System.Windows.Forms.DataGridView();
            this.VydIVozpan.SuspendLayout();
            this.DBEntrygbx.SuspendLayout();
            this.EntryAtributespan.SuspendLayout();
            this.Tablegbx.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Genredgvw)).BeginInit();
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
            this.VydIVozpan.Paint += new System.Windows.Forms.PaintEventHandler(this.VydIVozpan_Paint);
            // 
            // DBEntrygbx
            // 
            this.DBEntrygbx.Controls.Add(this.GoBackBtn);
            this.DBEntrygbx.Controls.Add(this.NextEntrybtn);
            this.DBEntrygbx.Controls.Add(this.PrevEntrybtn);
            this.DBEntrygbx.Controls.Add(this.EntryAtributespan);
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
            // GoBackBtn
            // 
            this.GoBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GoBackBtn.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GoBackBtn.Location = new System.Drawing.Point(108, 400);
            this.GoBackBtn.Name = "GoBackBtn";
            this.GoBackBtn.Size = new System.Drawing.Size(75, 29);
            this.GoBackBtn.TabIndex = 10;
            this.GoBackBtn.Text = "Выход";
            this.GoBackBtn.UseVisualStyleBackColor = true;
            this.GoBackBtn.Click += new System.EventHandler(this.GoBackBtn_Click);
            // 
            // NextEntrybtn
            // 
            this.NextEntrybtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NextEntrybtn.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NextEntrybtn.Location = new System.Drawing.Point(210, 400);
            this.NextEntrybtn.Name = "NextEntrybtn";
            this.NextEntrybtn.Size = new System.Drawing.Size(75, 29);
            this.NextEntrybtn.TabIndex = 9;
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
            this.PrevEntrybtn.TabIndex = 8;
            this.PrevEntrybtn.Text = "🡄";
            this.PrevEntrybtn.UseVisualStyleBackColor = true;
            this.PrevEntrybtn.Click += new System.EventHandler(this.PrevEntrybtn_Click);
            // 
            // EntryAtributespan
            // 
            this.EntryAtributespan.AutoScroll = true;
            this.EntryAtributespan.Controls.Add(this.label9);
            this.EntryAtributespan.Controls.Add(this.routetbx);
            this.EntryAtributespan.Controls.Add(this.label1);
            this.EntryAtributespan.Controls.Add(this.label2);
            this.EntryAtributespan.Controls.Add(this.citycodetbx);
            this.EntryAtributespan.Controls.Add(this.routecodetbx);
            this.EntryAtributespan.Location = new System.Drawing.Point(6, 14);
            this.EntryAtributespan.Name = "EntryAtributespan";
            this.EntryAtributespan.Size = new System.Drawing.Size(282, 346);
            this.EntryAtributespan.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 21);
            this.label9.TabIndex = 13;
            this.label9.Text = "Код города";
            // 
            // routetbx
            // 
            this.routetbx.Location = new System.Drawing.Point(120, 99);
            this.routetbx.Name = "routetbx";
            this.routetbx.Size = new System.Drawing.Size(153, 23);
            this.routetbx.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Код маршрута";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Маршрут";
            // 
            // citycodetbx
            // 
            this.citycodetbx.Location = new System.Drawing.Point(120, 57);
            this.citycodetbx.Name = "citycodetbx";
            this.citycodetbx.Size = new System.Drawing.Size(153, 23);
            this.citycodetbx.TabIndex = 11;
            // 
            // routecodetbx
            // 
            this.routecodetbx.Location = new System.Drawing.Point(120, 7);
            this.routecodetbx.Name = "routecodetbx";
            this.routecodetbx.Size = new System.Drawing.Size(153, 23);
            this.routecodetbx.TabIndex = 10;
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
            this.Tablegbx.Controls.Add(this.Genredgvw);
            this.Tablegbx.Location = new System.Drawing.Point(3, 3);
            this.Tablegbx.Name = "Tablegbx";
            this.Tablegbx.Size = new System.Drawing.Size(525, 443);
            this.Tablegbx.TabIndex = 0;
            this.Tablegbx.TabStop = false;
            this.Tablegbx.Text = "Таблица";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.countentrieslabel});
            this.statusStrip1.Location = new System.Drawing.Point(3, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(519, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(119, 17);
            this.toolStripStatusLabel1.Text = "Количество записей";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // countentrieslabel
            // 
            this.countentrieslabel.Name = "countentrieslabel";
            this.countentrieslabel.Size = new System.Drawing.Size(0, 17);
            // 
            // Genredgvw
            // 
            this.Genredgvw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Genredgvw.Location = new System.Drawing.Point(8, 22);
            this.Genredgvw.Name = "Genredgvw";
            this.Genredgvw.RowHeadersWidth = 51;
            this.Genredgvw.RowTemplate.Height = 25;
            this.Genredgvw.Size = new System.Drawing.Size(511, 381);
            this.Genredgvw.TabIndex = 0;
            this.Genredgvw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Genredgvw_CellContentClick);
            // 
            // RouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GoBackBtn;
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.VydIVozpan);
            this.MaximizeBox = false;
            this.Name = "RouteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RouteForm";
            this.Load += new System.EventHandler(this.GenreForm_Load);
            this.VydIVozpan.ResumeLayout(false);
            this.DBEntrygbx.ResumeLayout(false);
            this.EntryAtributespan.ResumeLayout(false);
            this.EntryAtributespan.PerformLayout();
            this.Tablegbx.ResumeLayout(false);
            this.Tablegbx.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Genredgvw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel VydIVozpan;
        private GroupBox DBEntrygbx;
        private Button DeleteEntrybtn;
        private Button UpdEntrybtn;
        private Button AddEntry;
        private GroupBox Tablegbx;
        private DataGridView Genredgvw;
        private Panel EntryAtributespan;
        private Label label1;
        private Label label2;
        private TextBox textBox7;
        private Label label4;
        private TextBox textBox8;
        private Label label3;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Label label5;
        private TextBox textBox3;
        private Label label8;
        private TextBox textBox4;
        private Label label7;
        private TextBox citycodetbx;
        private TextBox routecodetbx;
        private Button PrevEntrybtn;
        private Button NextEntrybtn;
        private Button GoBackBtn;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel countentrieslabel;
        private Label label9;
        private TextBox routetbx;
    }
}