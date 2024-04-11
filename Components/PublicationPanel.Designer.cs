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
            PsernameLabel = new Label();
            DateLabel = new Label();
            MessagePanel = new Panel();
            MessageLabel = new Label();
            MessagePanel.SuspendLayout();
            SuspendLayout();
            // 
            // PsernameLabel
            // 
            PsernameLabel.AutoSize = true;
            PsernameLabel.Font = new Font("Segoe UI", 12F);
            PsernameLabel.ForeColor = Color.White;
            PsernameLabel.Location = new Point(3, 10);
            PsernameLabel.Name = "PsernameLabel";
            PsernameLabel.Size = new Size(142, 28);
            PsernameLabel.TabIndex = 0;
            PsernameLabel.Text = "usernameLabel";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.ForeColor = Color.FromArgb(132, 141, 151);
            DateLabel.Location = new Point(461, 17);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(120, 20);
            DateLabel.TabIndex = 2;
            DateLabel.Text = "hh:mm dd:mm:ss";
            // 
            // MessagePanel
            // 
            MessagePanel.BackColor = Color.FromArgb(22, 27, 34);
            MessagePanel.BorderStyle = BorderStyle.FixedSingle;
            MessagePanel.Controls.Add(MessageLabel);
            MessagePanel.Location = new Point(28, 42);
            MessagePanel.Name = "MessagePanel";
            MessagePanel.Size = new Size(572, 82);
            MessagePanel.TabIndex = 3;
            // 
            // MessageLabel
            // 
            MessageLabel.AutoSize = true;
            MessageLabel.Font = new Font("Segoe UI", 10F);
            MessageLabel.Location = new Point(3, 0);
            MessageLabel.MaximumSize = new Size(562, 75);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new Size(560, 46);
            MessageLabel.TabIndex = 0;
            MessageLabel.Text = "messageLabel messageLabel messageLabel messageLabel messageLabel messageLabel messageLabel messageLabel messageLabel messageLabel ";
            // 
            // PublicationPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 17, 23);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(MessagePanel);
            Controls.Add(DateLabel);
            Controls.Add(PsernameLabel);
            ForeColor = Color.White;
            Name = "PublicationPanel";
            Size = new Size(599, 123);
            MessagePanel.ResumeLayout(false);
            MessagePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PsernameLabel;
        private Label DateLabel;
        private Panel MessagePanel;
        private Label MessageLabel;
    }
}
