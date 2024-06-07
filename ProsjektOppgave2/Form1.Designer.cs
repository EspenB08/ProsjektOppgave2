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
            button1 = new Button();
            label1 = new Label();
            inputBox = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(293, 151);
            button1.Name = "button1";
            button1.Size = new Size(243, 55);
            button1.TabIndex = 0;
            button1.Text = "Click me";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(378, 236);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter Value";
            label1.Click += label1_Click;
            // 
            // inputBox
            // 
            inputBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputBox.Location = new Point(241, 287);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(360, 23);
            inputBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 541);
            Controls.Add(inputBox);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Test";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox inputBox;
    }
}
