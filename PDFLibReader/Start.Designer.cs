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
            this.panLibCreater = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbRecentLibs = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tlbMain.SuspendLayout();
            this.tlbLibs.SuspendLayout();
            this.panLibCreater.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tlbLibs.Controls.Add(this.panLibCreater, 1, 0);
            this.tlbLibs.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlbLibs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlbLibs.Location = new System.Drawing.Point(3, 146);
            this.tlbLibs.Name = "tlbLibs";
            this.tlbLibs.RowCount = 1;
            this.tlbLibs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlbLibs.Size = new System.Drawing.Size(414, 138);
            this.tlbLibs.TabIndex = 0;
            // 
            // panLibCreater
            // 
            this.panLibCreater.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panLibCreater.Controls.Add(this.btnCreate);
            this.panLibCreater.Controls.Add(this.label3);
            this.panLibCreater.Controls.Add(this.btnOpen);
            this.panLibCreater.Controls.Add(this.label1);
            this.panLibCreater.Location = new System.Drawing.Point(235, 18);
            this.panLibCreater.Name = "panLibCreater";
            this.panLibCreater.Size = new System.Drawing.Size(151, 101);
            this.panLibCreater.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCreate.Location = new System.Drawing.Point(74, 56);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(64, 30);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(16, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Create a\r\nnew list";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpen
            // 
            this.btnOpen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOpen.Location = new System.Drawing.Point(74, 14);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(64, 31);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Open a\r\ndifferent list";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recent lists";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 287);
            this.Controls.Add(this.tlbMain);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximizeBox = false;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.tlbMain.ResumeLayout(false);
            this.tlbLibs.ResumeLayout(false);
            this.panLibCreater.ResumeLayout(false);
            this.panLibCreater.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlbMain;
        private System.Windows.Forms.TableLayoutPanel tlbLibs;
        private System.Windows.Forms.Panel panLibCreater;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lbRecentLibs;
        private System.Windows.Forms.Label label2;
    }
}

