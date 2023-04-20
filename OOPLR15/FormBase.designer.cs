
namespace OOPLR15
{
    partial class FormBase
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PrizvF = new System.Windows.Forms.TextBox();
            this.FNameF = new System.Windows.Forms.TextBox();
            this.NameF = new System.Windows.Forms.TextBox();
            this.PIB = new System.Windows.Forms.TextBox();
            this.Pidpus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PrizvF
            // 
            this.PrizvF.Location = new System.Drawing.Point(208, 39);
            this.PrizvF.Name = "PrizvF";
            this.PrizvF.Size = new System.Drawing.Size(190, 20);
            this.PrizvF.TabIndex = 0;
            this.PrizvF.Text = "Лялькін";
            this.PrizvF.TextChanged += new System.EventHandler(this.PrizvF_TextChanged);
            // 
            // FNameF
            // 
            this.FNameF.Location = new System.Drawing.Point(208, 108);
            this.FNameF.Name = "FNameF";
            this.FNameF.Size = new System.Drawing.Size(190, 20);
            this.FNameF.TabIndex = 1;
            this.FNameF.Text = "Запізнився";
            this.FNameF.TextChanged += new System.EventHandler(this.NameF_TextChanged);
            // 
            // NameF
            // 
            this.NameF.Location = new System.Drawing.Point(208, 74);
            this.NameF.Name = "NameF";
            this.NameF.Size = new System.Drawing.Size(190, 20);
            this.NameF.TabIndex = 2;
            this.NameF.Text = "Владислав";
            this.NameF.TextChanged += new System.EventHandler(this.NameF_TextChanged);
            // 
            // PIB
            // 
            this.PIB.Enabled = false;
            this.PIB.Location = new System.Drawing.Point(208, 237);
            this.PIB.Name = "PIB";
            this.PIB.Size = new System.Drawing.Size(190, 20);
            this.PIB.TabIndex = 3;
            // 
            // Pidpus
            // 
            this.Pidpus.Enabled = false;
            this.Pidpus.Location = new System.Drawing.Point(208, 273);
            this.Pidpus.Name = "Pidpus";
            this.Pidpus.Size = new System.Drawing.Size(190, 20);
            this.Pidpus.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Прізвище:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ім\'я";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "По батькові";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Прізвище, ім\'я та по батькові:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Підпис:";
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 431);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pidpus);
            this.Controls.Add(this.PIB);
            this.Controls.Add(this.NameF);
            this.Controls.Add(this.FNameF);
            this.Controls.Add(this.PrizvF);
            this.Name = "FormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дані фізичної особи";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Pidpus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox PIB;
        public System.Windows.Forms.TextBox PrizvF;
        public System.Windows.Forms.TextBox FNameF;
        public System.Windows.Forms.TextBox NameF;
    }
}

