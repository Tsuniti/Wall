namespace Wall.Forms
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            TitleBarPanel = new Components.TitleBarPanel();
            SubmitButton = new Button();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            TopLabel = new Label();
            RepeatPasswordTextBox = new TextBox();
            ErrorLabel = new Label();
            LogInLinkLabel = new LinkLabel();
            BorderRightPanel = new Panel();
            BorderLeftPanel = new Panel();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // TitleBarPanel
            // 
            TitleBarPanel.BackColor = Color.FromArgb(9, 9, 9);
            TitleBarPanel.Dock = DockStyle.Top;
            TitleBarPanel.Location = new Point(0, 0);
            TitleBarPanel.Name = "TitleBarPanel";
            TitleBarPanel.Size = new Size(390, 42);
            TitleBarPanel.TabIndex = 0;
            // 
            // SubmitButton
            // 
            SubmitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SubmitButton.FlatStyle = FlatStyle.Flat;
            SubmitButton.Font = new Font("Segoe UI", 11F);
            SubmitButton.ForeColor = Color.White;
            SubmitButton.Location = new Point(12, 369);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(366, 41);
            SubmitButton.TabIndex = 1;
            SubmitButton.Text = "Sign up";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SignUpButton_Click;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.BackColor = Color.FromArgb(22, 27, 34);
            UsernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            UsernameTextBox.ForeColor = Color.White;
            UsernameTextBox.Location = new Point(73, 139);
            UsernameTextBox.MaxLength = 16;
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.PlaceholderText = "Username";
            UsernameTextBox.Size = new Size(244, 27);
            UsernameTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = Color.FromArgb(22, 27, 34);
            PasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
            PasswordTextBox.ForeColor = Color.White;
            PasswordTextBox.Location = new Point(73, 213);
            PasswordTextBox.MaxLength = 32;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.PlaceholderText = "Password";
            PasswordTextBox.Size = new Size(244, 27);
            PasswordTextBox.TabIndex = 3;
            // 
            // TopLabel
            // 
            TopLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TopLabel.AutoSize = true;
            TopLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TopLabel.ForeColor = Color.White;
            TopLabel.Location = new Point(0, 54);
            TopLabel.MinimumSize = new Size(390, 0);
            TopLabel.Name = "TopLabel";
            TopLabel.Size = new Size(390, 31);
            TopLabel.TabIndex = 4;
            TopLabel.Text = "Registration";
            TopLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RepeatPasswordTextBox
            // 
            RepeatPasswordTextBox.BackColor = Color.FromArgb(22, 27, 34);
            RepeatPasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
            RepeatPasswordTextBox.ForeColor = Color.White;
            RepeatPasswordTextBox.Location = new Point(73, 287);
            RepeatPasswordTextBox.MaxLength = 32;
            RepeatPasswordTextBox.Name = "RepeatPasswordTextBox";
            RepeatPasswordTextBox.PasswordChar = '*';
            RepeatPasswordTextBox.PlaceholderText = "Repeat password";
            RepeatPasswordTextBox.Size = new Size(244, 27);
            RepeatPasswordTextBox.TabIndex = 5;
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.ForeColor = Color.Firebrick;
            ErrorLabel.Location = new Point(70, 97);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(0, 20);
            ErrorLabel.TabIndex = 6;
            // 
            // LogInLinkLabel
            // 
            LogInLinkLabel.ActiveLinkColor = Color.DarkGray;
            LogInLinkLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LogInLinkLabel.AutoSize = true;
            LogInLinkLabel.LinkColor = Color.White;
            LogInLinkLabel.Location = new Point(73, 323);
            LogInLinkLabel.Name = "LogInLinkLabel";
            LogInLinkLabel.Size = new Size(182, 20);
            LogInLinkLabel.TabIndex = 7;
            LogInLinkLabel.TabStop = true;
            LogInLinkLabel.Text = "Already have an account ?";
            LogInLinkLabel.VisitedLinkColor = Color.White;
            LogInLinkLabel.LinkClicked += LogInLinkLabel_LinkClicked;
            // 
            // BorderRightPanel
            // 
            BorderRightPanel.BackColor = Color.FromArgb(27, 35, 48);
            BorderRightPanel.Dock = DockStyle.Right;
            BorderRightPanel.Location = new Point(387, 42);
            BorderRightPanel.Name = "BorderRightPanel";
            BorderRightPanel.Size = new Size(3, 380);
            BorderRightPanel.TabIndex = 8;
            // 
            // BorderLeftPanel
            // 
            BorderLeftPanel.BackColor = Color.FromArgb(27, 35, 48);
            BorderLeftPanel.Dock = DockStyle.Left;
            BorderLeftPanel.Location = new Point(0, 42);
            BorderLeftPanel.Name = "BorderLeftPanel";
            BorderLeftPanel.Size = new Size(2, 380);
            BorderLeftPanel.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 35, 48);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(2, 419);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 3);
            panel1.TabIndex = 10;
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 17, 23);
            ClientSize = new Size(390, 422);
            Controls.Add(panel1);
            Controls.Add(BorderLeftPanel);
            Controls.Add(BorderRightPanel);
            Controls.Add(LogInLinkLabel);
            Controls.Add(ErrorLabel);
            Controls.Add(RepeatPasswordTextBox);
            Controls.Add(TopLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(SubmitButton);
            Controls.Add(TitleBarPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AuthorizationForm";
            Text = "AuthorizationForm";
            Load += AuthorizationForm_Load;
            Shown += AuthorizationForm_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Components.TitleBarPanel TitleBarPanel;
        private Button SubmitButton;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Label TopLabel;
        private TextBox RepeatPasswordTextBox;
        private Label ErrorLabel;
        private LinkLabel LogInLinkLabel;
        private Panel BorderRightPanel;
        private Panel BorderLeftPanel;
        private Panel panel1;
    }
}