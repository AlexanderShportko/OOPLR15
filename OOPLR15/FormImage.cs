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
    public partial class FormImage : Form
    {
        public FormImage(string Shulyak, string text, bool linked)
        {
            InitializeComponent();
            label1.Text = text;
            if (!linked)
                this.Shulyak.Load(Shulyak); //завантажуємо зображення з файла
            else
            {
                System.Resources.ResourceManager rm =
                Properties.Resources.ResourceManager;
                //завантажуємо зображення з ресурсів
                this.Shulyak.Image = (Image)rm.GetObject(Shulyak);
            }
        }

     private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
