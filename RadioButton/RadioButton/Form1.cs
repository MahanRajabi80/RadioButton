using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.rdiSizeable.Checked = true;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (rdiNone.Checked)
                this.FormBorderStyle = FormBorderStyle.None;
            else if (rdiFixedSingle.Checked)
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
            else if (rdiFixedSingle.Checked)
                this.FormBorderStyle = FormBorderStyle.Fixed3D;
            else if (rdiFixedDialog.Checked)
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
            else if (rdiSizeable.Checked)
                this.FormBorderStyle = FormBorderStyle.Sizable;
            else if (rdiSizeableToolWindow.Checked)
                this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            else if (rdiSizeableToolWindow.Checked)
                this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
        }
    }
}
