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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace Wall.Components
{
    public partial class PublicationPanel : UserControl
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ShowCaret(IntPtr hWnd);

        Publication? Publication;

        public PublicationPanel()
        {
            InitializeComponent();
        }
        //public PublicationPanel(Publication newPublication, string username)
        //{
        //    InitializeComponent();
        //    Publication = newPublication;
        //    PsernameLabel.Text = username + ':';
        //    MessageLabel.Text = Publication.Message;
        //    DateLabel.Text = Publication.Date.ToString();

        //}
        public PublicationPanel(string username,  string message, DateTime? date = null)
        {
            InitializeComponent();
            PsernameLabel.Text = username + ':';
            MessageLabel.Text = message;
            if (date == null )
            {
                DateLabel.Text = DateTime.Now.ToString();
            } 
            else
            {
                DateLabel.Text = date.ToString();
            }
        }
    }
}