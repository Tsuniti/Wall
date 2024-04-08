using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wall.Entities;
using Wall.Databases;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Wall.Components
{
    public partial class PublicationPanel : UserControl
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ShowCaret(IntPtr hWnd);

        Publication? publication;

        public PublicationPanel()
        {
            InitializeComponent();
        }
        public PublicationPanel(Publication newPublication, string username)
        {
            InitializeComponent();
            publication = newPublication;
            usernameLabel.Text = username + ':'; // не уверен
            messageLabel.Text = publication.message;
            dateLabel.Text = publication.date.ToString();

        }

    }
}