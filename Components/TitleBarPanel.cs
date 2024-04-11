using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wall.Components;

public partial class TitleBarPanel : UserControl
{

    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static bool ReleaseCapture();
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static int SendMessage(System.IntPtr hWnd,
                                int Msg, int wParam, int lParam);

    public Form ParentForm { get; set; }
    public TitleBarPanel()
    {
        InitializeComponent();
    }

    private void TitleBarPanel_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(ParentForm.Handle, 0x112, 0xf012, 0);
        }
    }

    private void CloseButton_Click(object sender, EventArgs e)
    {
        ParentForm.Close();
    }

    private void MinimizeButton_Click(object sender, EventArgs e)
    {
        ReleaseCapture();
        SendMessage(ParentForm.Handle, 0x112, 0xf020, 0);
    }
    public void HideMinimizeButton()
    {
        MinimizeButton.Visible = false;
    }
}
