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
    public partial class Question3_4 : Form
    {
        public Question3_4()
        {
            InitializeComponent();
        }

        public double balQuestion()
        {
            double bal = 0;
            if (checkBox1.Checked &&
                checkBox4.Checked &&
                !checkBox2.Checked &&
                !checkBox3.Checked)
            {
                MessageBox.Show("Відповідь вірна!\nВи набрали 1 бал", "Питання № 4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bal = 1;
            }
            else
            {
                if (checkBox1.Checked)
                    bal += 0.25;
                if (checkBox4.Checked)
                    bal += 0.25;
                if (!checkBox2.Checked)
                    bal += 0.25;
                if (!checkBox3.Checked)
                    bal += 0.25;
                MessageBox.Show("Ви помилилися!\nПрограмувати люблять Шуляк і Лесковець\nВи набрали "+bal.ToString()+" балів", "Питання № 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Program.balTest1 += bal;
            Program.coutQuestionTest1++;
            Program.maxBalTest1++;
            return bal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            balQuestion();
            new Question3_3().Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            balQuestion();
            new Question3_5().Show();
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
