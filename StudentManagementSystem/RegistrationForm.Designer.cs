namespace StudentManagementSystem
{
    partial class RegistrationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mobTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addressTV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ageTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.repassTB = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(208, 60);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(253, 23);
            this.nameTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(208, 176);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(253, 23);
            this.emailTB.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mobile";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // mobTB
            // 
            this.mobTB.Location = new System.Drawing.Point(208, 118);
            this.mobTB.Name = "mobTB";
            this.mobTB.Size = new System.Drawing.Size(253, 23);
            this.mobTB.TabIndex = 1;
            this.mobTB.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // addressTV
            // 
            this.addressTV.Location = new System.Drawing.Point(208, 147);
            this.addressTV.Name = "addressTV";
            this.addressTV.Size = new System.Drawing.Size(253, 23);
            this.addressTV.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Age";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // ageTB
            // 
            this.ageTB.Location = new System.Drawing.Point(208, 89);
            this.ageTB.Name = "ageTB";
            this.ageTB.Size = new System.Drawing.Size(253, 23);
            this.ageTB.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Password";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // passTB
            // 
            this.passTB.Location = new System.Drawing.Point(208, 205);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(253, 23);
            this.passTB.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Re-Pass";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // repassTB
            // 
            this.repassTB.Location = new System.Drawing.Point(208, 234);
            this.repassTB.Name = "repassTB";
            this.repassTB.Size = new System.Drawing.Size(253, 23);
            this.repassTB.TabIndex = 1;
            this.repassTB.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(386, 278);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(294, 278);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.addressTV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mobTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.repassTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ageTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label1);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox nameTB;
        private Label label2;
        private TextBox emailTB;
        private Label label3;
        private TextBox mobTB;
        private Label label4;
        private TextBox addressTV;
        private Label label5;
        private TextBox ageTB;
        private Label label6;
        private TextBox passTB;
        private Label label7;
        private TextBox repassTB;
        private Button submitButton;
        private Button clearButton;
    }
}