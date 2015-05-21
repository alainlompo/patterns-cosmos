using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excelta.GOF.Patterns.Structural.Bridge;


namespace BridgeTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void standardWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StandardWindow win = new StandardWindow(new StandardWindowImplementor());
            win.DrawDemoRectangle();
        }
    }
}
