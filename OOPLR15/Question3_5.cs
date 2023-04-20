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
    public partial class Question3_5 : Form
    {
        public Question3_5()
        {
            InitializeComponent();
        }

        public double balQuestion()
        {
            double bal = 0;
            if (!listStudent.GetSelected(0) &&
                listStudent.GetSelected(1) &&
                listStudent.GetSelected(2) &
                !listStudent.GetSelected(3) &&
                !listStudent.GetSelected(4))
            {
                MessageBox.Show("Відповідь вірна!\nВи набрали 1 бал", "Питання № 4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bal = 1;
            }
            else
            {
                if (!listStudent.GetSelected(0))
                    bal += 0.2;
                if (listStudent.GetSelected(1))
                    bal += 0.2;
                if (listStudent.GetSelected(2))
                    bal += 0.2;
                if (!listStudent.GetSelected(3)) 
                    bal += 0.2;
                if (!listStudent.GetSelected(4))
                    bal += 0.2;
                MessageBox.Show("Ви помилилися!\nЧасто спізнюються Гомечко і Газій\nВи набрали "+bal.ToString()+" балів", "Питання № 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Program.balTest1 += bal;
            Program.coutQuestionTest1++;
            Program.maxBalTest1++;
            return bal;
        }

        private void button1_Click(object sender, EventArgs e)
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
