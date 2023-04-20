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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormStart().Show();
        }

        private void тестЗТеми1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.balTest1 = 0;
            Program.coutQuestionTest1 = 0;
            Program.maxBalTest1 = 0;
            new Question3_1().Show();

        }

        private void тема1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormImage("Foto1","Улюблена квітка моєї бабусі",true).Show();
        }

        private void тема2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormImage("Foto2", "Пісок для дачі", true).Show();
        }

        private void тема3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormImage("Foto3", "Відпочинок на морі", true).Show();
        }

        private void емблемаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormImage("emblema.jpg", "Наша емблема", false).Show();
        }

        private void тестуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PI20().Show();
        }
    }
}
