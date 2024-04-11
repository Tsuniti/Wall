namespace Wall;
using Wall.Components;

partial class MainForm
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
        AllMessagesPanel = new Panel();
        WriteMessagePanel = new Panel();
        SendButton = new Button();
        NewMessageTextBox = new TextBox();
        TitleBarPanel = new TitleBarPanel();
        UsernameLabel = new Label();
        LogInButton = new Button();
        SignUpButton = new Button();
        LogOutLinkLabel = new LinkLabel();
        WriteMessagePanel.SuspendLayout();
        SuspendLayout();
        // 
        // AllMessagesPanel
        // 
        AllMessagesPanel.AutoScroll = true;
        AllMessagesPanel.BackColor = Color.FromArgb(13, 17, 23);
        AllMessagesPanel.BorderStyle = BorderStyle.FixedSingle;
        AllMessagesPanel.Location = new Point(12, 109);
        AllMessagesPanel.Name = "AllMessagesPanel";
        AllMessagesPanel.Size = new Size(663, 450);
        AllMessagesPanel.TabIndex = 0;
        // 
        // WriteMessagePanel
        // 
        WriteMessagePanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        WriteMessagePanel.BackColor = Color.FromArgb(13, 17, 23);
        WriteMessagePanel.Controls.Add(SendButton);
        WriteMessagePanel.Controls.Add(NewMessageTextBox);
        WriteMessagePanel.Location = new Point(12, 568);
        WriteMessagePanel.Name = "WriteMessagePanel";
        WriteMessagePanel.Size = new Size(651, 125);
        WriteMessagePanel.TabIndex = 1;
        // 
        // SendButton
        // 
        SendButton.BackColor = Color.FromArgb(33, 38, 45);
        SendButton.Enabled = false;
        SendButton.FlatStyle = FlatStyle.Popup;
        SendButton.ForeColor = Color.White;
        SendButton.Location = new Point(571, 24);
        SendButton.Name = "SendButton";
        SendButton.Size = new Size(72, 77);
        SendButton.TabIndex = 2;
        SendButton.Text = "Send";
        SendButton.UseVisualStyleBackColor = false;
        SendButton.Click += sendButton_Click;
        // 
        // NewMessageTextBox
        // 
        NewMessageTextBox.BackColor = Color.FromArgb(22, 27, 34);
        NewMessageTextBox.BorderStyle = BorderStyle.FixedSingle;
        NewMessageTextBox.Enabled = false;
        NewMessageTextBox.Font = new Font("Segoe UI", 9F);
        NewMessageTextBox.ForeColor = Color.White;
        NewMessageTextBox.Location = new Point(3, 24);
        NewMessageTextBox.MaxLength = 195;
        NewMessageTextBox.Multiline = true;
        NewMessageTextBox.Name = "NewMessageTextBox";
        NewMessageTextBox.Size = new Size(562, 77);
        NewMessageTextBox.TabIndex = 1;
        NewMessageTextBox.KeyDown += NewMessageTextBox_KeyDown;
        // 
        // TitleBarPanel
        // 
        TitleBarPanel.BackColor = Color.FromArgb(9, 9, 9);
        TitleBarPanel.Dock = DockStyle.Top;
        TitleBarPanel.Location = new Point(0, 0);
        TitleBarPanel.Name = "TitleBarPanel";
        TitleBarPanel.Size = new Size(675, 44);
        TitleBarPanel.TabIndex = 2;
        // 
        // UsernameLabel
        // 
        UsernameLabel.AutoSize = true;
        UsernameLabel.Font = new Font("Segoe UI", 14F);
        UsernameLabel.ForeColor = Color.White;
        UsernameLabel.Location = new Point(16, 59);
        UsernameLabel.Name = "UsernameLabel";
        UsernameLabel.Size = new Size(177, 32);
        UsernameLabel.TabIndex = 3;
        UsernameLabel.Text = "UsernameLabel";
        // 
        // LogInButton
        // 
        LogInButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(8, 34, 86);
        LogInButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 19, 48);
        LogInButton.FlatStyle = FlatStyle.Flat;
        LogInButton.Font = new Font("Segoe UI", 10F);
        LogInButton.ForeColor = Color.White;
        LogInButton.Location = new Point(561, 62);
        LogInButton.Name = "LogInButton";
        LogInButton.Size = new Size(94, 41);
        LogInButton.TabIndex = 4;
        LogInButton.Text = "Log in";
        LogInButton.UseVisualStyleBackColor = true;
        LogInButton.Click += LogInButton_Click;
        // 
        // SignUpButton
        // 
        SignUpButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(8, 34, 86);
        SignUpButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 19, 48);
        SignUpButton.FlatStyle = FlatStyle.Flat;
        SignUpButton.Font = new Font("Segoe UI", 10F);
        SignUpButton.ForeColor = Color.White;
        SignUpButton.Location = new Point(461, 62);
        SignUpButton.Name = "SignUpButton";
        SignUpButton.Size = new Size(94, 41);
        SignUpButton.TabIndex = 5;
        SignUpButton.Text = "Sign up";
        SignUpButton.UseVisualStyleBackColor = true;
        SignUpButton.Click += SignUpButton_Click;
        // 
        // LogOutLinkLabel
        // 
        LogOutLinkLabel.ActiveLinkColor = Color.WhiteSmoke;
        LogOutLinkLabel.AutoSize = true;
        LogOutLinkLabel.LinkColor = Color.Gray;
        LogOutLinkLabel.Location = new Point(579, 73);
        LogOutLinkLabel.Name = "LogOutLinkLabel";
        LogOutLinkLabel.Size = new Size(60, 20);
        LogOutLinkLabel.TabIndex = 6;
        LogOutLinkLabel.TabStop = true;
        LogOutLinkLabel.Text = "Log out";
        LogOutLinkLabel.Visible = false;
        LogOutLinkLabel.VisitedLinkColor = Color.Gray;
        LogOutLinkLabel.LinkClicked += LogOutLinkLabel_LinkClicked;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        BackColor = Color.FromArgb(1, 4, 9);
        ClientSize = new Size(675, 705);
        Controls.Add(LogOutLinkLabel);
        Controls.Add(SignUpButton);
        Controls.Add(LogInButton);
        Controls.Add(UsernameLabel);
        Controls.Add(WriteMessagePanel);
        Controls.Add(AllMessagesPanel);
        Controls.Add(TitleBarPanel);
        FormBorderStyle = FormBorderStyle.None;
        Name = "MainForm";
        Text = "MainForm";
        Load += MainForm_Load;
        Shown += MainForm_Shown;
        WriteMessagePanel.ResumeLayout(false);
        WriteMessagePanel.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel AllMessagesPanel;
    private Panel WriteMessagePanel;
    private TextBox NewMessageTextBox;
    private Button SendButton;
    private TitleBarPanel TitleBarPanel;
    private Label UsernameLabel;
    private Button LogInButton;
    private Button SignUpButton;
    private LinkLabel LogOutLinkLabel;
}
