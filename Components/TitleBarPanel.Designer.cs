namespace Wall.Components;

partial class TitleBarPanel
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleBarPanel));
        MinimizeButton = new Button();
        CloseButton = new Button();
        SuspendLayout();
        // 
        // MinimizeButton
        // 
        MinimizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        MinimizeButton.FlatAppearance.BorderSize = 0;
        MinimizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(58, 58, 58);
        MinimizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
        MinimizeButton.FlatStyle = FlatStyle.Flat;
        MinimizeButton.Image = (Image)resources.GetObject("MinimizeButton.Image");
        MinimizeButton.Location = new Point(439, 0);
        MinimizeButton.Name = "MinimizeButton";
        MinimizeButton.Size = new Size(56, 44);
        MinimizeButton.TabIndex = 1;
        MinimizeButton.UseVisualStyleBackColor = true;
        MinimizeButton.Click += MinimizeButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        CloseButton.FlatAppearance.BorderSize = 0;
        CloseButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(148, 19, 32);
        CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(205, 26, 43);
        CloseButton.FlatStyle = FlatStyle.Flat;
        CloseButton.Image = (Image)resources.GetObject("CloseButton.Image");
        CloseButton.Location = new Point(492, 0);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(56, 44);
        CloseButton.TabIndex = 0;
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // TitleBarPanel
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(9, 9, 9);
        Controls.Add(CloseButton);
        Controls.Add(MinimizeButton);
        Name = "TitleBarPanel";
        Size = new Size(548, 44);
        MouseDown += TitleBarPanel_MouseDown;
        ResumeLayout(false);
    }

    #endregion
    private Button MinimizeButton;
    private Button CloseButton;
}
