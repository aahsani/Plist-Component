using FarsiLibrary.Win;
using ICSharpCode.TextEditor;
using IPATools.PlistEditor.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace IPATools.PlistEditor
{
    public partial class FormMain : Form
    {
        MainController controller;
        Form mc;

        public FormMain(Form mc, string path)
        {
            InitializeComponent();
            this.Text = Program.TITLE;
            this.mc = mc;
            controller = new MainController(this);
            /*
            if (args != null && args.Length > 0)
            {
                foreach (var item in args)
                {
                    controller.Open(this.faTabStripMain, item);
                }
            }
             */
            controller.Open(faTabStripMain, path);
        }        

        private void faTabStripMain_TabStripItemClosing(TabStripItemClosingEventArgs e)
        {
            controller.Close(e);
        }


        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.Exit(e);
            Application.Exit();//added
        }

        
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            this.mc.Show();
            controller.Exit();
            
            //? has problem
        }
        
       
    }
}
