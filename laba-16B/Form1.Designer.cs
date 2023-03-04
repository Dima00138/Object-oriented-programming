namespace laba_16B
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Russian = new System.Windows.Forms.RadioButton();
            this.Britain = new System.Windows.Forms.RadioButton();
            this.Europe = new System.Windows.Forms.RadioButton();
            this.America = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Russian2 = new System.Windows.Forms.RadioButton();
            this.Britain2 = new System.Windows.Forms.RadioButton();
            this.Europe2 = new System.Windows.Forms.RadioButton();
            this.America2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Размер одежды";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Перевод";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(157, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 61);
            this.button1.TabIndex = 14;
            this.button1.Text = "Перевести";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Russian);
            this.groupBox1.Controls.Add(this.Britain);
            this.groupBox1.Controls.Add(this.Europe);
            this.groupBox1.Controls.Add(this.America);
            this.groupBox1.Location = new System.Drawing.Point(349, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 269);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Откуда";
            // 
            // Russian
            // 
            this.Russian.AutoSize = true;
            this.Russian.Location = new System.Drawing.Point(60, 160);
            this.Russian.Name = "Russian";
            this.Russian.Size = new System.Drawing.Size(69, 19);
            this.Russian.TabIndex = 14;
            this.Russian.Text = "Русские";
            this.Russian.UseVisualStyleBackColor = true;
            // 
            // Britain
            // 
            this.Britain.AutoSize = true;
            this.Britain.Location = new System.Drawing.Point(60, 121);
            this.Britain.Name = "Britain";
            this.Britain.Size = new System.Drawing.Size(77, 19);
            this.Britain.TabIndex = 13;
            this.Britain.Text = "Британия";
            this.Britain.UseVisualStyleBackColor = true;
            // 
            // Europe
            // 
            this.Europe.AutoSize = true;
            this.Europe.Location = new System.Drawing.Point(60, 79);
            this.Europe.Name = "Europe";
            this.Europe.Size = new System.Drawing.Size(64, 19);
            this.Europe.TabIndex = 12;
            this.Europe.Text = "Европа";
            this.Europe.UseVisualStyleBackColor = true;
            // 
            // America
            // 
            this.America.AutoSize = true;
            this.America.Checked = true;
            this.America.Location = new System.Drawing.Point(60, 35);
            this.America.Name = "America";
            this.America.Size = new System.Drawing.Size(74, 19);
            this.America.TabIndex = 11;
            this.America.TabStop = true;
            this.America.Text = "Америка";
            this.America.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Russian2);
            this.groupBox2.Controls.Add(this.Britain2);
            this.groupBox2.Controls.Add(this.Europe2);
            this.groupBox2.Controls.Add(this.America2);
            this.groupBox2.Location = new System.Drawing.Point(565, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 269);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Откуда";
            // 
            // Russian2
            // 
            this.Russian2.AutoSize = true;
            this.Russian2.Location = new System.Drawing.Point(60, 160);
            this.Russian2.Name = "Russian2";
            this.Russian2.Size = new System.Drawing.Size(69, 19);
            this.Russian2.TabIndex = 14;
            this.Russian2.Text = "Русские";
            this.Russian2.UseVisualStyleBackColor = true;
            // 
            // Britain2
            // 
            this.Britain2.AutoSize = true;
            this.Britain2.Location = new System.Drawing.Point(60, 121);
            this.Britain2.Name = "Britain2";
            this.Britain2.Size = new System.Drawing.Size(77, 19);
            this.Britain2.TabIndex = 13;
            this.Britain2.Text = "Британия";
            this.Britain2.UseVisualStyleBackColor = true;
            // 
            // Europe2
            // 
            this.Europe2.AutoSize = true;
            this.Europe2.Location = new System.Drawing.Point(60, 79);
            this.Europe2.Name = "Europe2";
            this.Europe2.Size = new System.Drawing.Size(64, 19);
            this.Europe2.TabIndex = 12;
            this.Europe2.Text = "Европа";
            this.Europe2.UseVisualStyleBackColor = true;
            // 
            // America2
            // 
            this.America2.AutoSize = true;
            this.America2.Checked = true;
            this.America2.Location = new System.Drawing.Point(60, 35);
            this.America2.Name = "America2";
            this.America2.Size = new System.Drawing.Size(74, 19);
            this.America2.TabIndex = 11;
            this.America2.TabStop = true;
            this.America2.Text = "Америка";
            this.America2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private GroupBox groupBox1;
        private RadioButton Russian;
        private RadioButton Britain;
        private RadioButton Europe;
        private RadioButton America;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private GroupBox groupBox3;
        private RadioButton radioButton9;
        private GroupBox groupBox2;
        private RadioButton Russian2;
        private RadioButton Britain2;
        private RadioButton Europe2;
        private RadioButton America2;
    }
}