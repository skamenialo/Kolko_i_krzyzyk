namespace KolkoIKrzyzyk
{
    partial class Form1
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.graczVsSIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sIVsSIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AllowUserToResizeColumns = false;
      this.dataGridView1.AllowUserToResizeRows = false;
      this.dataGridView1.ColumnHeadersHeight = 20;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dataGridView1.ColumnHeadersVisible = false;
      this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridView1.Location = new System.Drawing.Point(12, 27);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.RowHeadersWidth = 20;
      this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
      this.dataGridView1.RowTemplate.Height = 40;
      this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.dataGridView1.Size = new System.Drawing.Size(198, 198);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.restartToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(222, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // plikToolStripMenuItem
      // 
      this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graczVsSIToolStripMenuItem,
            this.sIVsSIToolStripMenuItem,
            this.exitToolStripMenuItem});
      this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
      this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
      this.plikToolStripMenuItem.Text = "Plik";
      // 
      // graczVsSIToolStripMenuItem
      // 
      this.graczVsSIToolStripMenuItem.Name = "graczVsSIToolStripMenuItem";
      this.graczVsSIToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
      this.graczVsSIToolStripMenuItem.Text = "Gracz vs SI";
      this.graczVsSIToolStripMenuItem.Click += new System.EventHandler(this.graczVsSIToolStripMenuItem_Click);
      // 
      // sIVsSIToolStripMenuItem
      // 
      this.sIVsSIToolStripMenuItem.Name = "sIVsSIToolStripMenuItem";
      this.sIVsSIToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
      this.sIVsSIToolStripMenuItem.Text = "SI vs SI";
      this.sIVsSIToolStripMenuItem.Click += new System.EventHandler(this.sIVsSIToolStripMenuItem_Click);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
      this.exitToolStripMenuItem.Text = "Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // restartToolStripMenuItem
      // 
      this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
      this.restartToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
      this.restartToolStripMenuItem.Text = "Restart";
      this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click_1);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.label1.Location = new System.Drawing.Point(60, 234);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(56, 20);
      this.label1.TabIndex = 2;
      this.label1.Text = "Gracz:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.label2.Location = new System.Drawing.Point(122, 234);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(0, 20);
      this.label2.TabIndex = 3;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(222, 263);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(238, 302);
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(238, 302);
      this.Name = "Form1";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.Text = "Kółko i krzyżyk";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem graczVsSIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sIVsSIToolStripMenuItem;
    }
}

