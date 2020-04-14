namespace Ikzamen
{
    partial class Aftorizacia
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
            this.button1_exit = new System.Windows.Forms.Button();
            this.button2_reg = new System.Windows.Forms.Button();
            this.label1_log = new System.Windows.Forms.Label();
            this.label2_pas = new System.Windows.Forms.Label();
            this.textBox1_log = new System.Windows.Forms.TextBox();
            this.textBox2_pas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1_exit
            // 
            this.button1_exit.BackColor = System.Drawing.Color.LightGray;
            this.button1_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_exit.ForeColor = System.Drawing.Color.Black;
            this.button1_exit.Location = new System.Drawing.Point(278, 96);
            this.button1_exit.Name = "button1_exit";
            this.button1_exit.Size = new System.Drawing.Size(145, 53);
            this.button1_exit.TabIndex = 0;
            this.button1_exit.Text = "Вход";
            this.button1_exit.UseVisualStyleBackColor = false;
            this.button1_exit.Click += new System.EventHandler(this.button1_exit_Click);
            // 
            // button2_reg
            // 
            this.button2_reg.BackColor = System.Drawing.Color.LightGray;
            this.button2_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2_reg.ForeColor = System.Drawing.Color.Black;
            this.button2_reg.Location = new System.Drawing.Point(15, 96);
            this.button2_reg.Name = "button2_reg";
            this.button2_reg.Size = new System.Drawing.Size(257, 53);
            this.button2_reg.TabIndex = 1;
            this.button2_reg.Text = "Регистрация";
            this.button2_reg.UseVisualStyleBackColor = false;
            this.button2_reg.Click += new System.EventHandler(this.button2_reg_Click);
            // 
            // label1_log
            // 
            this.label1_log.AutoSize = true;
            this.label1_log.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_log.Location = new System.Drawing.Point(12, 9);
            this.label1_log.Name = "label1_log";
            this.label1_log.Size = new System.Drawing.Size(62, 25);
            this.label1_log.TabIndex = 2;
            this.label1_log.Text = "Логин";
            // 
            // label2_pas
            // 
            this.label2_pas.AutoSize = true;
            this.label2_pas.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_pas.Location = new System.Drawing.Point(12, 56);
            this.label2_pas.Name = "label2_pas";
            this.label2_pas.Size = new System.Drawing.Size(74, 25);
            this.label2_pas.TabIndex = 3;
            this.label2_pas.Text = "Пароль";
            // 
            // textBox1_log
            // 
            this.textBox1_log.Location = new System.Drawing.Point(99, 9);
            this.textBox1_log.Name = "textBox1_log";
            this.textBox1_log.Size = new System.Drawing.Size(324, 22);
            this.textBox1_log.TabIndex = 4;
            // 
            // textBox2_pas
            // 
            this.textBox2_pas.Location = new System.Drawing.Point(99, 56);
            this.textBox2_pas.Name = "textBox2_pas";
            this.textBox2_pas.Size = new System.Drawing.Size(324, 22);
            this.textBox2_pas.TabIndex = 5;
            // 
            // Aftorizacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 161);
            this.Controls.Add(this.textBox2_pas);
            this.Controls.Add(this.textBox1_log);
            this.Controls.Add(this.label2_pas);
            this.Controls.Add(this.label1_log);
            this.Controls.Add(this.button2_reg);
            this.Controls.Add(this.button1_exit);
            this.Name = "Aftorizacia";
            this.Text = "Aftorizacia";
            this.Load += new System.EventHandler(this.Aftorizacia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_exit;
        private System.Windows.Forms.Button button2_reg;
        private System.Windows.Forms.Label label1_log;
        private System.Windows.Forms.Label label2_pas;
        private System.Windows.Forms.TextBox textBox1_log;
        private System.Windows.Forms.TextBox textBox2_pas;
    }
}

