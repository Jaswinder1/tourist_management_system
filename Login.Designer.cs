namespace Project11
{
    partial class Login
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
            btnlog = new Button();
            label1 = new Label();
            txtid = new TextBox();
            txtPass = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnregister = new Button();
            linkRegister_LinkClicked = new LinkLabel();
            btnlogadmin = new Button();
            SuspendLayout();
            // 
            // btnlog
            // 
            btnlog.Location = new Point(175, 334);
            btnlog.Name = "btnlog";
            btnlog.Size = new Size(138, 79);
            btnlog.TabIndex = 0;
            btnlog.Text = "LOGIN";
            btnlog.UseVisualStyleBackColor = true;
            btnlog.Click += btnlog_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(255, 48);
            label1.Name = "label1";
            label1.Size = new Size(295, 51);
            label1.TabIndex = 1;
            label1.Text = "USER LOGIN";
            // 
            // txtid
            // 
            txtid.Location = new Point(269, 164);
            txtid.Name = "txtid";
            txtid.Size = new Size(305, 27);
            txtid.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(269, 253);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(305, 27);
            txtPass.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 167);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 4;
            label2.Text = "USER ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 256);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // btnregister
            // 
            btnregister.Location = new Point(356, 334);
            btnregister.Name = "btnregister";
            btnregister.Size = new Size(167, 88);
            btnregister.TabIndex = 6;
            btnregister.Text = "Not already exist?";
            btnregister.UseVisualStyleBackColor = true;
            // 
            // linkRegister_LinkClicked
            // 
            linkRegister_LinkClicked.AutoSize = true;
            linkRegister_LinkClicked.BackColor = SystemColors.ButtonHighlight;
            linkRegister_LinkClicked.Location = new Point(402, 392);
            linkRegister_LinkClicked.Name = "linkRegister_LinkClicked";
            linkRegister_LinkClicked.Size = new Size(63, 20);
            linkRegister_LinkClicked.TabIndex = 7;
            linkRegister_LinkClicked.TabStop = true;
            linkRegister_LinkClicked.Text = "register ";
            linkRegister_LinkClicked.LinkClicked += linkRegister_LinkClicked_LinkClicked;
            // 
            // btnlogadmin
            // 
            btnlogadmin.Location = new Point(573, 344);
            btnlogadmin.Name = "btnlogadmin";
            btnlogadmin.Size = new Size(123, 68);
            btnlogadmin.TabIndex = 9;
            btnlogadmin.Text = "Login as admin";
            btnlogadmin.UseVisualStyleBackColor = true;
            btnlogadmin.Click += btnlogadmin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnlogadmin);
            Controls.Add(linkRegister_LinkClicked);
            Controls.Add(btnregister);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPass);
            Controls.Add(txtid);
            Controls.Add(label1);
            Controls.Add(btnlog);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnlog;
        private Label label1;
        private TextBox txtid;
        private TextBox txtPass;
        private Label label2;
        private Label label3;
        private Button btnregister;
        private LinkLabel linkRegister_LinkClicked;
        private Button btnAdminLogin;
        private Button btnlogadmin;
    }
}