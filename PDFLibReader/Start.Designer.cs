namespace PDFLibReader
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
            this.tlbMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlbLibs = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbRecentLibs = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tlbMain.SuspendLayout();
            this.tlbLibs.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlbMain
            // 
            this.tlbMain.ColumnCount = 1;
            this.tlbMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlbMain.Controls.Add(this.tlbLibs, 0, 1);
            this.tlbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlbMain.Location = new System.Drawing.Point(0, 0);
            this.tlbMain.Name = "tlbMain";
            this.tlbMain.RowCount = 2;
            this.tlbMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlbMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlbMain.Size = new System.Drawing.Size(420, 287);
            this.tlbMain.TabIndex = 0;
            // 
            // tlbLibs
            // 
            this.tlbLibs.ColumnCount = 2;
            this.tlbLibs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlbLibs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlbLibs.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tlbLibs.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlbLibs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlbLibs.Location = new System.Drawing.Point(3, 146);
            this.tlbLibs.Name = "tlbLibs";
            this.tlbLibs.RowCount = 1;
            this.tlbLibs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlbLibs.Size = new System.Drawing.Size(414, 138);
            this.tlbLibs.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbRecentLibs, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(201, 132);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lbRecentLibs
            // 
            this.lbRecentLibs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRecentLibs.FormattingEnabled = true;
            this.lbRecentLibs.Location = new System.Drawing.Point(3, 29);
            this.lbRecentLibs.Name = "lbRecentLibs";
            this.lbRecentLibs.Size = new System.Drawing.Size(195, 100);
            this.lbRecentLibs.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(69, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recent lists";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnOpen, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnCreate, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.button1, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(210, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(201, 132);
            this.tableLayoutPanel3.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(20, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Open a\r\ndifferent list";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpen
            // 
            this.btnOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOpen.Location = new System.Drawing.Point(103, 3);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(95, 37);
            this.btnOpen.TabIndex = 17;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(26, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "Create a\r\nnew list";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreate
            // 
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCreate.Location = new System.Drawing.Point(103, 46);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(95, 37);
            this.btnCreate.TabIndex = 19;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.ListManipulation);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 26);
            this.label4.TabIndex = 20;
            this.label4.Text = "Modify an\r\nexistent list";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(103, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 40);
            this.button1.TabIndex = 21;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ListManipulation);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 287);
            this.Controls.Add(this.tlbMain);
            this.MaximizeBox = false;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.tlbMain.ResumeLayout(false);
            this.tlbLibs.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlbMain;
        private System.Windows.Forms.TableLayoutPanel tlbLibs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lbRecentLibs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

