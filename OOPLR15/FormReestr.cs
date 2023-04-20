using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOPLR15
{
    public partial class FormReestr : FormBase
    {
        public FormReestr()
        {
            InitializeComponent();
        }

        protected override void FormRes()
        {
            base.FormRes();
            string str = PIB.Text;
            if (str != "")
                str += " ";
            str += "(" + ((int)((DateTime.Now - ДатаНародження.Value).Days/365.25)).ToString() + " років)";
            PIB.Text = str;
        }

        void WriteFile(string nameFile, bool povidom)
        {
            string[] masStr = new string[4];
            masStr[0] = PrizvF.Text;
            masStr[1] = NameF.Text;
            masStr[2] = FNameF.Text;
            masStr[3] = ДатаНародження.Value.ToString();
            File.WriteAllLines(nameFile, masStr);
            if (povidom)
                MessageBox.Show("Дані збережені успішно","Дані збережено",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        void WriteFile(bool povidom)
        {
            WriteFile("default.txt",povidom);
        }


        void ReadFile(string nameFile, bool povidom)
        {   if (!File.Exists(nameFile))
             {if (povidom)
                     MessageBox.Show("Файл даних не існує", "Дані не зчитано", MessageBoxButtons.OK, MessageBoxIcon.Error);
              return;
             }
            string[] masStr=File.ReadAllLines(nameFile);
            bool fullRead = true;
            if (masStr.Length > 0)
                PrizvF.Text = masStr[0];
            else
                fullRead = false;
            if (masStr.Length > 1)
                NameF.Text = masStr[1];
            else
                fullRead = false;
            if (masStr.Length > 2)
                FNameF.Text = masStr[2];
            else
                fullRead = false;
            if (masStr.Length > 3)
                try
                {
                    ДатаНародження.Value = Convert.ToDateTime(masStr[3]);
                }
                catch
                {
                    fullRead = false;
                }
            else
                fullRead = false;
            if (fullRead)
            {if (povidom)
                MessageBox.Show("Дані зчитані успішно", "Дані зчитано", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Файл даних пошкоджено", "Дані не зчитано", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        void ReadFile(bool povidom)
        {
            ReadFile("default.txt", povidom);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            (new FormBase()).Show();
        }

        private void ДатаНародження_ValueChanged(object sender, EventArgs e)
        {
            FormRes();
        }

        private void FormPorodgeno_Load(object sender, EventArgs e)
        {
            ReadFile(false);
            FormRes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WriteFile(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFile.Title = "КН лінуються програмувати";
            if (saveFile.ShowDialog() == DialogResult.Cancel)
                return;
            WriteFile(saveFile.FileName,true);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReadFile(true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFile.Title = "Шкабара заснула";
            if (openFile.ShowDialog() == DialogResult.Cancel)
                return;
            ReadFile(openFile.FileName, true);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void FormPorodgeno_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.Cancel)
                WriteFile(false);
        }

        private void button6_Click(object sender, EventArgs e)
        {   Program.User = PIB.Text;
            new FormMenu().ShowDialog();
            Close();
            
        }
    }
}
