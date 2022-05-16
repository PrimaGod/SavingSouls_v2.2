namespace SavingSouls_v2._2
{
    partial class AddProblem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProblem));
            this.tb_OpisProblem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmB_Prioritet = new System.Windows.Forms.ComboBox();
            this.dateProis = new System.Windows.Forms.DateTimePicker();
            this.cmB_Group = new System.Windows.Forms.ComboBox();
            this.TimeProblem = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_OpisProblem
            // 
            this.tb_OpisProblem.Location = new System.Drawing.Point(178, 29);
            this.tb_OpisProblem.Name = "tb_OpisProblem";
            this.tb_OpisProblem.Size = new System.Drawing.Size(144, 20);
            this.tb_OpisProblem.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Описание происшествия -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Приоритет происшествия -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Дата -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Время -";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Группа на выезд -";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(130, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(274, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmB_Prioritet
            // 
            this.cmB_Prioritet.FormattingEnabled = true;
            this.cmB_Prioritet.Items.AddRange(new object[] {
            "Низкий",
            "Средний",
            "Высокий",
            "Незамедлительный"});
            this.cmB_Prioritet.Location = new System.Drawing.Point(179, 81);
            this.cmB_Prioritet.Name = "cmB_Prioritet";
            this.cmB_Prioritet.Size = new System.Drawing.Size(144, 21);
            this.cmB_Prioritet.TabIndex = 13;
            // 
            // dateProis
            // 
            this.dateProis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateProis.Location = new System.Drawing.Point(180, 109);
            this.dateProis.Name = "dateProis";
            this.dateProis.Size = new System.Drawing.Size(143, 20);
            this.dateProis.TabIndex = 14;
            // 
            // cmB_Group
            // 
            this.cmB_Group.FormattingEnabled = true;
            this.cmB_Group.Items.AddRange(new object[] {
            "331",
            "122",
            "411",
            "515",
            "555"});
            this.cmB_Group.Location = new System.Drawing.Point(179, 159);
            this.cmB_Group.Name = "cmB_Group";
            this.cmB_Group.Size = new System.Drawing.Size(143, 21);
            this.cmB_Group.TabIndex = 15;
            // 
            // TimeProblem
            // 
            this.TimeProblem.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeProblem.Location = new System.Drawing.Point(179, 133);
            this.TimeProblem.Name = "TimeProblem";
            this.TimeProblem.Size = new System.Drawing.Size(143, 20);
            this.TimeProblem.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Адресс -";
            // 
            // AddProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(373, 334);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TimeProblem);
            this.Controls.Add(this.cmB_Group);
            this.Controls.Add(this.dateProis);
            this.Controls.Add(this.cmB_Prioritet);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_OpisProblem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProblem";
            this.Text = "AddProblem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_OpisProblem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmB_Prioritet;
        private System.Windows.Forms.DateTimePicker dateProis;
        private System.Windows.Forms.ComboBox cmB_Group;
        private System.Windows.Forms.DateTimePicker TimeProblem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}