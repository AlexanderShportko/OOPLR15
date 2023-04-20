
namespace OOPLR15
{
    partial class FormReestr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ДатаНародження = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PIB
            // 
            this.PIB.Text = "Лялькін Владислав Запізнився";
            // 
            // ДатаНародження
            // 
            this.ДатаНародження.Location = new System.Drawing.Point(212, 145);
            this.ДатаНародження.Name = "ДатаНародження";
            this.ДатаНародження.Size = new System.Drawing.Size(185, 20);
            this.ДатаНародження.TabIndex = 10;
            this.ДатаНародження.ValueChanged += new System.EventHandler(this.ДатаНародження_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Дата народження:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Створити форму батька";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 48);
            this.button2.TabIndex = 13;
            this.button2.Text = "Записати у файл по замовчуванню";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(38, 417);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 48);
            this.button3.TabIndex = 14;
            this.button3.Text = "Записати в обраний файл";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(243, 417);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 48);
            this.button4.TabIndex = 16;
            this.button4.Text = "Зчитати з обраного файла";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(243, 360);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 48);
            this.button5.TabIndex = 15;
            this.button5.Text = "Зчитати з файла по замовчуванню";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(145, 478);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(143, 39);
            this.button6.TabIndex = 17;
            this.button6.Text = "Вхід в систему";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // FormReestr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 530);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ДатаНародження);
            this.Name = "FormReestr";
            this.Text = "Реєстрація в системі";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPorodgeno_FormClosing);
            this.Load += new System.EventHandler(this.FormPorodgeno_Load);
            this.Controls.SetChildIndex(this.PrizvF, 0);
            this.Controls.SetChildIndex(this.FNameF, 0);
            this.Controls.SetChildIndex(this.NameF, 0);
            this.Controls.SetChildIndex(this.PIB, 0);
            this.Controls.SetChildIndex(this.ДатаНародження, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.button6, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker ДатаНародження;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}