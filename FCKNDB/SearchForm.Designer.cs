namespace FCKNDB
{
    partial class SearchForm
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
            this.searchgbx = new System.Windows.Forms.GroupBox();
            this.searchparamspan = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.GoBackBtn = new System.Windows.Forms.Button();
            this.operationsgbx = new System.Windows.Forms.GroupBox();
            this.sparam1rb = new System.Windows.Forms.RadioButton();
            this.sparam2rb = new System.Windows.Forms.RadioButton();
            this.sparam3rb = new System.Windows.Forms.RadioButton();
            this.sparam4rb = new System.Windows.Forms.RadioButton();
            this.sparam5rb = new System.Windows.Forms.RadioButton();
            this.sparam6rb = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.numsearchrb = new System.Windows.Forms.RadioButton();
            this.textsearchrb = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.entervalslb = new System.Windows.Forms.Label();
            this.firstvaluetbx = new System.Windows.Forms.TextBox();
            this.secondvaluetbx = new System.Windows.Forms.TextBox();
            this.searchcmbx = new System.Windows.Forms.ComboBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.Resultsgbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsdgv)).BeginInit();
            this.searchgbx.SuspendLayout();
            this.searchparamspan.SuspendLayout();
            this.operationsgbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // Resultsgbx
            // 
            this.Resultsgbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Resultsgbx.AutoSize = true;
            this.Resultsgbx.Controls.Add(this.resultsdgv);
            this.Resultsgbx.Location = new System.Drawing.Point(6, 3);
            this.Resultsgbx.Name = "Resultsgbx";
            this.Resultsgbx.Size = new System.Drawing.Size(510, 490);
            this.Resultsgbx.TabIndex = 9;
            this.Resultsgbx.TabStop = false;
            this.Resultsgbx.Text = "Результаты поиска";
            this.Resultsgbx.Enter += new System.EventHandler(this.Resultsgbx_Enter);
            // 
            // resultsdgv
            // 
            this.resultsdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsdgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsdgv.Location = new System.Drawing.Point(3, 19);
            this.resultsdgv.Name = "resultsdgv";
            this.resultsdgv.RowHeadersWidth = 51;
            this.resultsdgv.RowTemplate.Height = 25;
            this.resultsdgv.Size = new System.Drawing.Size(504, 468);
            this.resultsdgv.TabIndex = 8;
            // 
            // searchgbx
            // 
            this.searchgbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchgbx.AutoSize = true;
            this.searchgbx.Controls.Add(this.searchparamspan);
            this.searchgbx.Location = new System.Drawing.Point(516, 3);
            this.searchgbx.Name = "searchgbx";
            this.searchgbx.Size = new System.Drawing.Size(314, 490);
            this.searchgbx.TabIndex = 9;
            this.searchgbx.TabStop = false;
            this.searchgbx.Text = "Параметры поиска";
            // 
            // searchparamspan
            // 
            this.searchparamspan.AutoSize = true;
            this.searchparamspan.BackColor = System.Drawing.Color.Transparent;
            this.searchparamspan.Controls.Add(this.button1);
            this.searchparamspan.Controls.Add(this.GoBackBtn);
            this.searchparamspan.Controls.Add(this.operationsgbx);
            this.searchparamspan.Controls.Add(this.label3);
            this.searchparamspan.Controls.Add(this.numsearchrb);
            this.searchparamspan.Controls.Add(this.textsearchrb);
            this.searchparamspan.Controls.Add(this.label2);
            this.searchparamspan.Controls.Add(this.label1);
            this.searchparamspan.Controls.Add(this.entervalslb);
            this.searchparamspan.Controls.Add(this.firstvaluetbx);
            this.searchparamspan.Controls.Add(this.secondvaluetbx);
            this.searchparamspan.Controls.Add(this.searchcmbx);
            this.searchparamspan.Controls.Add(this.searchbtn);
            this.searchparamspan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchparamspan.Location = new System.Drawing.Point(3, 19);
            this.searchparamspan.Name = "searchparamspan";
            this.searchparamspan.Size = new System.Drawing.Size(308, 468);
            this.searchparamspan.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(113, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 21);
            this.button1.TabIndex = 20;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GoBackBtn
            // 
            this.GoBackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GoBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GoBackBtn.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GoBackBtn.Location = new System.Drawing.Point(114, 549);
            this.GoBackBtn.Name = "GoBackBtn";
            this.GoBackBtn.Size = new System.Drawing.Size(88, 21);
            this.GoBackBtn.TabIndex = 19;
            this.GoBackBtn.Text = "Выход";
            this.GoBackBtn.UseVisualStyleBackColor = true;
            // 
            // operationsgbx
            // 
            this.operationsgbx.Controls.Add(this.sparam1rb);
            this.operationsgbx.Controls.Add(this.sparam2rb);
            this.operationsgbx.Controls.Add(this.sparam3rb);
            this.operationsgbx.Controls.Add(this.sparam4rb);
            this.operationsgbx.Controls.Add(this.sparam5rb);
            this.operationsgbx.Controls.Add(this.sparam6rb);
            this.operationsgbx.Location = new System.Drawing.Point(4, 113);
            this.operationsgbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operationsgbx.Name = "operationsgbx";
            this.operationsgbx.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operationsgbx.Size = new System.Drawing.Size(291, 92);
            this.operationsgbx.TabIndex = 18;
            this.operationsgbx.TabStop = false;
            this.operationsgbx.Text = "Операции над цифровыми полями";
            // 
            // sparam1rb
            // 
            this.sparam1rb.AutoSize = true;
            this.sparam1rb.Location = new System.Drawing.Point(5, 19);
            this.sparam1rb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sparam1rb.Name = "sparam1rb";
            this.sparam1rb.Size = new System.Drawing.Size(36, 19);
            this.sparam1rb.TabIndex = 3;
            this.sparam1rb.TabStop = true;
            this.sparam1rb.Text = "( )";
            this.sparam1rb.UseVisualStyleBackColor = true;
            // 
            // sparam2rb
            // 
            this.sparam2rb.AutoSize = true;
            this.sparam2rb.Location = new System.Drawing.Point(5, 41);
            this.sparam2rb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sparam2rb.Name = "sparam2rb";
            this.sparam2rb.Size = new System.Drawing.Size(36, 19);
            this.sparam2rb.TabIndex = 4;
            this.sparam2rb.TabStop = true;
            this.sparam2rb.Text = "( ]";
            this.sparam2rb.UseVisualStyleBackColor = true;
            // 
            // sparam3rb
            // 
            this.sparam3rb.AutoSize = true;
            this.sparam3rb.Location = new System.Drawing.Point(5, 63);
            this.sparam3rb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sparam3rb.Name = "sparam3rb";
            this.sparam3rb.Size = new System.Drawing.Size(41, 19);
            this.sparam3rb.TabIndex = 5;
            this.sparam3rb.TabStop = true;
            this.sparam3rb.Text = "=>";
            this.sparam3rb.UseVisualStyleBackColor = true;
            // 
            // sparam4rb
            // 
            this.sparam4rb.AutoSize = true;
            this.sparam4rb.Location = new System.Drawing.Point(192, 19);
            this.sparam4rb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sparam4rb.Name = "sparam4rb";
            this.sparam4rb.Size = new System.Drawing.Size(36, 19);
            this.sparam4rb.TabIndex = 7;
            this.sparam4rb.TabStop = true;
            this.sparam4rb.Text = "[ ]";
            this.sparam4rb.UseVisualStyleBackColor = true;
            // 
            // sparam5rb
            // 
            this.sparam5rb.AutoSize = true;
            this.sparam5rb.Location = new System.Drawing.Point(192, 41);
            this.sparam5rb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sparam5rb.Name = "sparam5rb";
            this.sparam5rb.Size = new System.Drawing.Size(36, 19);
            this.sparam5rb.TabIndex = 8;
            this.sparam5rb.TabStop = true;
            this.sparam5rb.Text = "[ )";
            this.sparam5rb.UseVisualStyleBackColor = true;
            // 
            // sparam6rb
            // 
            this.sparam6rb.AutoSize = true;
            this.sparam6rb.Location = new System.Drawing.Point(192, 63);
            this.sparam6rb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sparam6rb.Name = "sparam6rb";
            this.sparam6rb.Size = new System.Drawing.Size(41, 19);
            this.sparam6rb.TabIndex = 9;
            this.sparam6rb.TabStop = true;
            this.sparam6rb.Text = "<=";
            this.sparam6rb.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Выберите тип поиска:";
            // 
            // numsearchrb
            // 
            this.numsearchrb.AutoSize = true;
            this.numsearchrb.Location = new System.Drawing.Point(150, 23);
            this.numsearchrb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numsearchrb.Name = "numsearchrb";
            this.numsearchrb.Size = new System.Drawing.Size(149, 19);
            this.numsearchrb.TabIndex = 16;
            this.numsearchrb.TabStop = true;
            this.numsearchrb.Text = "По маршруту и ценам";
            this.numsearchrb.UseVisualStyleBackColor = true;
            this.numsearchrb.CheckedChanged += new System.EventHandler(this.numsearchrb_CheckedChanged);
            // 
            // textsearchrb
            // 
            this.textsearchrb.AutoSize = true;
            this.textsearchrb.Location = new System.Drawing.Point(3, 23);
            this.textsearchrb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textsearchrb.Name = "textsearchrb";
            this.textsearchrb.Size = new System.Drawing.Size(101, 19);
            this.textsearchrb.TabIndex = 15;
            this.textsearchrb.TabStop = true;
            this.textsearchrb.Text = "По маршруту";
            this.textsearchrb.UseVisualStyleBackColor = true;
            this.textsearchrb.CheckedChanged += new System.EventHandler(this.textsearchrb_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(154, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "1:";
            // 
            // entervalslb
            // 
            this.entervalslb.AutoSize = true;
            this.entervalslb.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entervalslb.Location = new System.Drawing.Point(5, 35);
            this.entervalslb.Name = "entervalslb";
            this.entervalslb.Size = new System.Drawing.Size(101, 20);
            this.entervalslb.TabIndex = 12;
            this.entervalslb.Text = "Заполните поле:";
            // 
            // firstvaluetbx
            // 
            this.firstvaluetbx.Location = new System.Drawing.Point(40, 86);
            this.firstvaluetbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstvaluetbx.Name = "firstvaluetbx";
            this.firstvaluetbx.Size = new System.Drawing.Size(110, 23);
            this.firstvaluetbx.TabIndex = 11;
            // 
            // secondvaluetbx
            // 
            this.secondvaluetbx.Location = new System.Drawing.Point(187, 86);
            this.secondvaluetbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.secondvaluetbx.Name = "secondvaluetbx";
            this.secondvaluetbx.Size = new System.Drawing.Size(110, 23);
            this.secondvaluetbx.TabIndex = 10;
            // 
            // searchcmbx
            // 
            this.searchcmbx.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.searchcmbx.FormattingEnabled = true;
            this.searchcmbx.Location = new System.Drawing.Point(3, 58);
            this.searchcmbx.Name = "searchcmbx";
            this.searchcmbx.Size = new System.Drawing.Size(294, 23);
            this.searchcmbx.TabIndex = 1;
            this.searchcmbx.SelectedIndexChanged += new System.EventHandler(this.searchcmbx_SelectedIndexChanged_1);
            // 
            // searchbtn
            // 
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.searchbtn.Location = new System.Drawing.Point(207, 209);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(88, 21);
            this.searchbtn.TabIndex = 2;
            this.searchbtn.Text = "Искать";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // SearchForm
            // 
            this.AcceptButton = this.searchbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(834, 505);
            this.Controls.Add(this.searchgbx);
            this.Controls.Add(this.Resultsgbx);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Resultsgbx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultsdgv)).EndInit();
            this.searchgbx.ResumeLayout(false);
            this.searchgbx.PerformLayout();
            this.searchparamspan.ResumeLayout(false);
            this.searchparamspan.PerformLayout();
            this.operationsgbx.ResumeLayout(false);
            this.operationsgbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox Resultsgbx;
        private DataGridView resultsdgv;
        private GroupBox searchgbx;
        private Panel searchparamspan;
        private Button GoBackBtn;
        private GroupBox operationsgbx;
        private RadioButton sparam1rb;
        private RadioButton sparam2rb;
        private RadioButton sparam3rb;
        private RadioButton sparam4rb;
        private RadioButton sparam5rb;
        private RadioButton sparam6rb;
        private Label label3;
        private RadioButton numsearchrb;
        private RadioButton textsearchrb;
        private Label label2;
        private Label label1;
        private Label entervalslb;
        private TextBox firstvaluetbx;
        private TextBox secondvaluetbx;
        private ComboBox searchcmbx;
        private Button searchbtn;
        private Button button1;
    }
}