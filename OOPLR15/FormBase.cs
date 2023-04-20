using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLR15
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        protected virtual void FormRes()
        {
            string res = PrizvF.Text;
            if (NameF.Text!="")
            {if (res!="")
                res += " ";
             res += NameF.Text;
            }
            if (FNameF.Text != "")
            {
                if (res != "")
                    res += " ";
                res += FNameF.Text;
            }
            PIB.Text = res;
            res = "";
            if (NameF.Text != "")
            {
                res = NameF.Text[0].ToString().ToUpper()+
                      NameF.Text.Substring(1, NameF.Text.Length-1).ToLower();
            }
            if (PrizvF.Text != "")
            {
                if (res != "")
                    res += " ";
                res += PrizvF.Text.ToUpper();
            }
            Pidpus.Text = res;
        }

        private void PrizvF_TextChanged(object sender, EventArgs e)
        {
            FormRes();
        }

        private void NameF_TextChanged(object sender, EventArgs e)
        {
            FormRes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormRes();
        }
    }
}
