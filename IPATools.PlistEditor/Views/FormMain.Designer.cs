namespace IPATools.PlistEditor
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.faTabStripMain = new FarsiLibrary.Win.FATabStrip();
            this.faTabStripItem1 = new FarsiLibrary.Win.FATabStripItem();
            this.contextMenuStripTab = new System.Windows.Forms.ContextMenuStrip(this.components);
            //this.tabSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            //this.tabOpenPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faTabStripMain)).BeginInit();
            this.contextMenuStripTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.faTabStripMain);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(776, 373);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(776, 398);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // faTabStripMain
            // 
            this.faTabStripMain.AllowDrop = true;
            this.faTabStripMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.faTabStripMain.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.faTabStripMain.Location = new System.Drawing.Point(0, 0);
            this.faTabStripMain.Name = "faTabStripMain";
            this.faTabStripMain.SelectedItem = this.faTabStripItem1;
            this.faTabStripMain.Size = new System.Drawing.Size(776, 373);
            this.faTabStripMain.TabIndex = 0;
            this.faTabStripMain.TabStripItemClosing += new FarsiLibrary.Win.TabStripItemClosingHandler(this.faTabStripMain_TabStripItemClosing);
            //this.faTabStripMain.TabStripItemSelectionChanged += new FarsiLibrary.Win.TabStripItemChangedHandler(this.faTabStripMain_TabStripItemSelectionChanged);
            // 
            // faTabStripItem1
            // 
            this.faTabStripItem1.IsDrawn = true;
            this.faTabStripItem1.Name = "faTabStripItem1";
            this.faTabStripItem1.Selected = true;
            this.faTabStripItem1.Size = new System.Drawing.Size(609, 169);
            this.faTabStripItem1.TabIndex = 0;
            this.faTabStripItem1.Title = "TabStrip Page 1";
            // 
            // contextMenuStripTab
            // 
            //this.contextMenuStripTab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            //this.tabSaveToolStripMenuItem,
            //this.tabOpenPathToolStripMenuItem,
            //this.tabCloseToolStripMenuItem});
            this.contextMenuStripTab.Name = "contextMenuStripTab";
            this.contextMenuStripTab.Size = new System.Drawing.Size(131, 70);
            // 
            // tabSaveToolStripMenuItem
            // 
            /*
            this.tabSaveToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabSaveToolStripMenuItem.Name = "tabSaveToolStripMenuItem";
            this.tabSaveToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.tabSaveToolStripMenuItem.Text = "Save";
            //this.tabSaveToolStripMenuItem.Click += new System.EventHandler(this.tabSaveToolStripMenuItem_Click);
             */
            // 
            // tabOpenPathToolStripMenuItem
            // 
            /*
            this.tabOpenPathToolStripMenuItem.Name = "tabOpenPathToolStripMenuItem";
            this.tabOpenPathToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.tabOpenPathToolStripMenuItem.Text = "Open Path";
            this.tabOpenPathToolStripMenuItem.Click += new System.EventHandler(this.tabOpenPathToolStripMenuItem_Click);
             */
            // 
            // tabCloseToolStripMenuItem-
            // 
            /*
            this.tabCloseToolStripMenuItem.Name = "tabCloseToolStripMenuItem";
            this.tabCloseToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.tabCloseToolStripMenuItem.Text = "Close";
            this.tabCloseToolStripMenuItem.Click += new System.EventHandler(this.tabCloseToolStripMenuItem_Click);
             */
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 398);
            this.Controls.Add(this.toolStripContainer1);
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plist Editor ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            //this.Load += new System.EventHandler(this.FormMain_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faTabStripMain)).EndInit();
            this.contextMenuStripTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private FarsiLibrary.Win.FATabStripItem faTabStripItem1;
        //private System.Windows.Forms.ToolStripMenuItem tabSaveToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem tabOpenPathToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem tabCloseToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip contextMenuStripTab;
        public FarsiLibrary.Win.FATabStrip faTabStripMain;

    }
}

