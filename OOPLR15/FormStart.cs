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
    public partial class FormStart : Form
    {
        int nomer;
        public FormStart():base()
        {
           InitializeComponent();
        }

        public FormStart(int index):this()
        {
            switch (index)
            {
                case 1:
                    Text = "Царук";
                    break;
                case 2:
                    Text = "Музичук";
                    break;
                case 3:
                    Text = "Нагорнюк";
                    break;
                case 4:
                    Text = "Дарина";
                    break;
                default:
                    Text = "Ковалевич";
                    break;
            }
        }
        ~FormStart()
        {
            MessageBox.Show("Мене знищують");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2 курс вивчає візуальне програмування!", "Нарешті",
                            MessageBoxButtons.YesNo,MessageBoxIcon.Hand);
            (new FormStart((new Random()).Next(10))).Show();
;        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Музичук знає властивість \"Text\"");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            Random r = new Random();
            b.Left = 10 + r.Next(350);
            b.Top = 10 + r.Next(250);
            b.Size = new Size(120, 50);
            b.Parent = this;
            b.Text = ((Button)sender).Text;// DateTime.Now.ToString();
            b.Click += new System.EventHandler(this.button5_Click);
            b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(r.Next(256))))), ((int)(((byte)(r.Next(256))))), ((int)(((byte)(r.Next(256)))))); ;

        }
    }
}
