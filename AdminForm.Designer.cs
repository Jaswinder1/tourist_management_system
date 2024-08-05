namespace Project11
{
    partial class AdminForm
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
            labelUsername = new Label();
            labelpassword = new Label();
            txtid = new TextBox();
            txtPass = new TextBox();
            btnlogina = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(194, 150);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(75, 20);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Username";
            // 
            // labelpassword
            // 
            labelpassword.AutoSize = true;
            labelpassword.Location = new Point(199, 268);
            labelpassword.Name = "labelpassword";
            labelpassword.Size = new Size(70, 20);
            labelpassword.TabIndex = 1;
            labelpassword.Text = "Password";
            // 
            // txtid
            // 
            txtid.Location = new Point(398, 147);
            txtid.Name = "txtid";
            txtid.Size = new Size(125, 27);
            txtid.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(398, 265);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(125, 27);
            txtPass.TabIndex = 3;
            // 
            // btnlogina
            // 
            btnlogina.Location = new Point(265, 342);
            btnlogina.Name = "btnlogina";
            btnlogina.Size = new Size(125, 59);
            btnlogina.TabIndex = 4;
            btnlogina.Text = "login as admin";
            btnlogina.UseVisualStyleBackColor = true;
            btnlogina.Click += btnlogina_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(146, 24);
            label1.Name = "label1";
            label1.Size = new Size(437, 67);
            label1.TabIndex = 5;
            label1.Text = "WELCOME ADMIN";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnlogina);
            Controls.Add(txtPass);
            Controls.Add(txtid);
            Controls.Add(labelpassword);
            Controls.Add(labelUsername);
            Name = "AdminForm";
            Text = "admin form";
            Load += AdminForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsername;
        private Label labelpassword;
        private TextBox txtid;
        private TextBox txtPass;
        private Button btnlogina;
        private Label label1;
    }
}