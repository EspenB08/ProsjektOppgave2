namespace ProsjektOppgave2
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
            login = new Button();
            label1 = new Label();
            Username = new TextBox();
            Password = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // login
            // 
            login.Location = new Point(252, 367);
            login.Name = "login";
            login.Size = new Size(243, 55);
            login.TabIndex = 0;
            login.Text = "Login";
            login.UseVisualStyleBackColor = true;
            login.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(342, 231);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // Username
            // 
            Username.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Username.Location = new Point(234, 264);
            Username.Name = "Username";
            Username.Size = new Size(284, 23);
            Username.TabIndex = 2;
            Username.TextChanged += inputBox_TextChanged;
            // 
            // Password
            // 
            Password.Location = new Point(234, 338);
            Password.Name = "Password";
            Password.Size = new Size(284, 23);
            Password.TabIndex = 4;
            Password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 306);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AcceptButton = login;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pointing_template;
            ClientSize = new Size(747, 552);
            Controls.Add(label2);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(label1);
            Controls.Add(login);
            Name = "Form1";
            Text = "Login screen";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login;
        private Label label1;
        private TextBox Username;
        private TextBox Password;
        private Label label2;
    }
}
