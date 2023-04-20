using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLR15
{
    static class Program
    {
        static public string User;
        static public double balTest1, maxBalTest1;
        static public int coutQuestionTest1;

        static public void resTest1()
        {
            MessageBox.Show("Шановний "+User+"!\nЗа результатами першого навчального тесту ви набрали " + balTest1.ToString() +
                            " балів з " + maxBalTest1.ToString(), "Підсумки тесту № 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormReestr());
        }
    }
}
