
using Wall.Entities;
using Wall.Components;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Wall.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Wall
{
    public partial class MainForm : Form
    {

        PublicationPanel? PreviousPublicationPanel;

        AuthorizationForm? AuthorizationForm;
        public ChatUser? AuthorizedUser;
        //List<Publication> Publications;
        //public UserToPublicationsDB db = new UserToPublicationsDB();

        public HubConnection MyHubConnection;

        public MainForm()
        {

            InitializeComponent();

            MyHubConnection = new HubConnectionBuilder()
                .WithUrl("https://localhost:7005/chat")
                .Build();
            //hubConnection.Closed += HubConnection_Closed;

            MyHubConnection.On<string, string, DateTime>("Receive", (user, message, date) =>
            {

                Task.Run(() =>
                {
                    Invoke(new Action(() =>
                    {
                        ShowMessage(user, message, date);
                    }));
                });
            });


        }

        //private async Task HubConnection_Closed(Exception? arg)
        //{
        //    await Task.Delay(new Random().Next(0, 5) * 1000);     // idk how to use it
        //    await MyHubConnection.StartAsync();
        //}
        private void ShowMessage(string user, string message, DateTime? date = null)
        {
            bool IsScrollBottom = (AllMessagesPanel.VerticalScroll.Value + AllMessagesPanel.VerticalScroll.LargeChange >= AllMessagesPanel.VerticalScroll.Maximum);
            var publicationPanel =
                 new PublicationPanel(user, message, date);
            if (PreviousPublicationPanel != null)
            {
                publicationPanel.Location = new System.Drawing.Point(12,
                    PreviousPublicationPanel.Location.Y + PreviousPublicationPanel.Height + 3);
            }
            else
            {
                publicationPanel.Location = new System.Drawing.Point(12, 340);
            }
            PreviousPublicationPanel = publicationPanel;

            AllMessagesPanel.Controls.Add(publicationPanel);

            if (IsScrollBottom)
            {
                AllMessagesPanel.ScrollControlIntoView(publicationPanel);
            }

        }
        private async void MainForm_Load(object sender, EventArgs e)
        {
            TitleBarPanel.ParentForm = this;

            try
            {
                // подключемс€ к хабу
                await MyHubConnection.StartAsync();
                ShowMessage("System", "Connection started.");
            }
            catch (Exception ex)
            {
                ShowMessage("System", ex.Message);
            }

            try
            {
                await MyHubConnection.InvokeAsync("ReceiveAll");
            }
            catch (Exception ex)
            {
                ShowMessage("System", ex.Message);
            }

            if (AuthorizedUser != null)
            {
                UsernameLabel.Text = "Guest";
                NewMessageTextBox.Enabled = false;
            }
            AllMessagesPanel.VerticalScroll.Value = AllMessagesPanel.VerticalScroll.Maximum;


        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
            // ѕочему-то до этого фокусировка была на CloseButton и при нажатии Enter форма закрывалась
            UsernameLabel.Focus();      
        }
        private async void sendButton_Click(object sender, EventArgs e)
        {
            if (NewMessageTextBox.Text != string.Empty)
            {


                try
                {
                    await MyHubConnection.InvokeAsync("Send", AuthorizedUser, NewMessageTextBox.Text);
                }
                catch (Exception ex)
                {
                    ShowMessage("System", ex.Message);
                }
                AllMessagesPanel.VerticalScroll.Value = AllMessagesPanel.VerticalScroll.Maximum;
                NewMessageTextBox.Text = String.Empty;
            }
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            AuthorizationForm = new AuthorizationForm("Log in");
            AuthorizationForm.ParentForm = this;
            AuthorizationForm.ShowDialog();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            AuthorizationForm = new AuthorizationForm();
            AuthorizationForm.ParentForm = this;
            AuthorizationForm.ShowDialog();
        }

        private void LogOutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AuthorizedUser = null;
            UsernameLabel.Text = String.Empty;
            SignUpButton.Visible = true;
            LogInButton.Visible = true;
            LogOutLinkLabel.Visible = false;
            NewMessageTextBox.Enabled = false;
            SendButton.Enabled = false;
        }
        public void UserLogIn(string username)
        {
            UsernameLabel.Text = username;
            NewMessageTextBox.Enabled = true;
            SendButton.Enabled = true;
            LogInButton.Visible = false;
            SignUpButton.Visible = false;
            LogOutLinkLabel.Visible = true;
        }

        private void NewMessageTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                sendButton_Click(this, new EventArgs());
            }

        }


    }
}
