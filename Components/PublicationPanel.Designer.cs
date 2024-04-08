namespace Wall.Components
{
    partial class PublicationPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernameLabel = new Label();
            dateLabel = new Label();
            messagePanel = new Panel();
            messageLabel = new Label();
            messagePanel.SuspendLayout();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 12F);
            usernameLabel.ForeColor = Color.White;
            usernameLabel.Location = new Point(3, 10);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(142, 28);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "usernameLabel";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.ForeColor = Color.FromArgb(132, 141, 151);
            dateLabel.Location = new Point(461, 17);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(120, 20);
            dateLabel.TabIndex = 2;
            dateLabel.Text = "hh:mm dd:mm:ss";
            // 
            // messagePanel
            // 
            messagePanel.BorderStyle = BorderStyle.FixedSingle;
            messagePanel.Controls.Add(messageLabel);
            messagePanel.Location = new Point(28, 42);
            messagePanel.Name = "messagePanel";
            messagePanel.Size = new Size(562, 77);
            messagePanel.TabIndex = 3;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Font = new Font("Segoe UI", 10F);
            messageLabel.Location = new Point(3, 0);
            messageLabel.MaximumSize = new Size(562, 75);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(560, 46);
            messageLabel.TabIndex = 0;
            messageLabel.Text = "messageLabel messageLabel messageLabel messageLabel messageLabel messageLabel messageLabel messageLabel messageLabel messageLabel ";
            // 
            // PublicationPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 17, 23);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(messagePanel);
            Controls.Add(dateLabel);
            Controls.Add(usernameLabel);
            ForeColor = Color.White;
            Name = "PublicationPanel";
            Size = new Size(599, 123);
            messagePanel.ResumeLayout(false);
            messagePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernameLabel;
        private Label dateLabel;
        private Panel messagePanel;
        private Label messageLabel;
    }
}
