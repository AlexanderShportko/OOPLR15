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
    public partial class Question3_3 : Form
    {
        public Question3_3()
        {
            InitializeComponent();
        }

        public double balQuestion()
        {
            double bal = 0;
            if (starosta.Checked)
            {
                MessageBox.Show("Відповідь вірна!\nВи набрали 1 бал", "Питання № 3", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bal = 1;
            }
            else
            {
                MessageBox.Show("Ви помилилися!\nСтароста КН-21 - Маринич\nВи набрали 0 балів", "Питання № 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Program.balTest1 += bal;
            Program.coutQuestionTest1++;
            Program.maxBalTest1++;
            return bal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            balQuestion();
            new Question3_2().Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            balQuestion();
            new Question3_4().Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            balQuestion();
            Close();
            Program.resTest1();
        }
    }
}
