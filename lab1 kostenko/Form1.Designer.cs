namespace lab1_kostenko
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nomerzadaniya = new TextBox();
            danie = new TextBox();
            result = new TextBox();
            buttonresult = new Button();
            buttonexit = new Button();
            danie_dlya_3_4_zadaniya = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 0;
            label1.Text = "Введіть номер завдання:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(685, 90);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 170);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 2;
            label3.Text = "Введіть данні:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 367);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 3;
            label4.Text = "Результат:";
            // 
            // nomerzadaniya
            // 
            nomerzadaniya.Location = new Point(158, 24);
            nomerzadaniya.Name = "nomerzadaniya";
            nomerzadaniya.Size = new Size(100, 23);
            nomerzadaniya.TabIndex = 4;
            // 
            // danie
            // 
            danie.Location = new Point(12, 188);
            danie.Multiline = true;
            danie.Name = "danie";
            danie.Size = new Size(776, 108);
            danie.TabIndex = 5;
            // 
            // result
            // 
            result.Location = new Point(12, 385);
            result.Multiline = true;
            result.Name = "result";
            result.Size = new Size(776, 111);
            result.TabIndex = 6;
            result.TextChanged += result_TextChanged;
            // 
            // buttonresult
            // 
            buttonresult.Location = new Point(94, 512);
            buttonresult.Name = "buttonresult";
            buttonresult.Size = new Size(234, 55);
            buttonresult.TabIndex = 7;
            buttonresult.Text = "Результат";
            buttonresult.UseVisualStyleBackColor = true;
            buttonresult.Click += buttonresult_Click;
            // 
            // buttonexit
            // 
            buttonexit.Location = new Point(444, 512);
            buttonexit.Name = "buttonexit";
            buttonexit.Size = new Size(219, 55);
            buttonexit.TabIndex = 8;
            buttonexit.Text = "Закрити";
            buttonexit.UseVisualStyleBackColor = true;
            buttonexit.Click += buttonexit_Click;
            // 
            // danie_dlya_3_4_zadaniya
            // 
            danie_dlya_3_4_zadaniya.Location = new Point(197, 319);
            danie_dlya_3_4_zadaniya.Name = "danie_dlya_3_4_zadaniya";
            danie_dlya_3_4_zadaniya.Size = new Size(100, 23);
            danie_dlya_3_4_zadaniya.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 322);
            label5.Name = "label5";
            label5.Size = new Size(179, 15);
            label5.TabIndex = 10;
            label5.Text = "Введіть данні для 2 і 4 завдання:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 575);
            Controls.Add(label5);
            Controls.Add(danie_dlya_3_4_zadaniya);
            Controls.Add(buttonexit);
            Controls.Add(buttonresult);
            Controls.Add(result);
            Controls.Add(danie);
            Controls.Add(nomerzadaniya);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nomerzadaniya;
        private TextBox danie;
        private TextBox result;
        private Button buttonresult;
        private Button buttonexit;
        private TextBox danie_dlya_3_4_zadaniya;
        private Label label5;
    }
}
