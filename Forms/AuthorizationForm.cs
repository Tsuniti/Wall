using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wall.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Wall.Forms
{
    public partial class AuthorizationForm : Form
    {

        public MainForm ParentForm;

        public AuthorizationForm()
        {
            InitializeComponent();
        }
        public AuthorizationForm(string str)
        {
            InitializeComponent();
            if (str == "Log in") LogInPaint();

            else if (str == "Sing up") SignUpPaint();

        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {


            TitleBarPanel.HideMinimizeButton();
            TitleBarPanel.ParentForm = this;
            Button InvisibleAcceptButton = new Button();
            InvisibleAcceptButton.Click += InvisibleAcceptButton_Click;
            this.AcceptButton = InvisibleAcceptButton;

            UsernameTextBox.Focus();
        }
        private void AuthorizationForm_Shown(object sender, EventArgs e)
        {
            UsernameTextBox.Focus();
        }
        private void LogInLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogInPaint();
        }

        private void SignUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpPaint();
        }


        public void LogInPaint()
        {
            ErrorLabel.Text = String.Empty;
            RepeatPasswordTextBox.Visible = false;
            TopLabel.Text = "Log in";
            this.Height = 355;
            SubmitButton.Text = "Login";
            SubmitButton.Click -= SignUpButton_Click;
            SubmitButton.Click += LogInButton_Click;
            LogInLinkLabel.Text = "Don't have an account ?";
            LogInLinkLabel.LinkClicked -= LogInLinkLabel_LinkClicked;
            LogInLinkLabel.LinkClicked += SignUpLinkLabel_LinkClicked;
        }

        public void SignUpPaint()
        {
            RepeatPasswordTextBox.Visible = true;
            TopLabel.Text = "Sign up";
            ErrorLabel.Text = String.Empty;
            this.Height = 422;
            SubmitButton.Text = "Registration";
            SubmitButton.Click -= LogInButton_Click;
            SubmitButton.Click += SignUpButton_Click;
            LogInLinkLabel.Text = "Already have an account ?";
            LogInLinkLabel.LinkClicked -= SignUpLinkLabel_LinkClicked;
            LogInLinkLabel.LinkClicked += LogInLinkLabel_LinkClicked;
        }

        private async void SignUpButton_Click(object sender, EventArgs e)
        {

            if (UsernameTextBox.Text.Length <= 3)
            {
                ErrorLabel.Text = "Username must be longer than 2 characters";
                return;
            }


            try
            {
                if (await ParentForm.MyHubConnection.InvokeAsync<bool>("CheckIsUsernameAvailable", UsernameTextBox.Text))
                {
                    ErrorLabel.Text = "This username already taken";
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            if (PasswordTextBox.Text.Length <= 4)
            {
                ErrorLabel.Text = "Password must be longer than 3 characters";
                return;
            }
            if (PasswordTextBox.Text != RepeatPasswordTextBox.Text)
            {
                ErrorLabel.Text = "Password mismatch";
                return;
            }


            try
            {
                await ParentForm.MyHubConnection.InvokeAsync("RegisterNewUser", UsernameTextBox.Text, PasswordTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LogIn();


        }
        private async void LogInButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == String.Empty)
            {
                ErrorLabel.Text = "Username field can't be empty";
                return;
            }
            if (PasswordTextBox.Text == String.Empty)
            {
                ErrorLabel.Text = "Password field can't be empty";
                return;
            }

            LogIn();
        }
        private async void LogIn()
        {
            try
            {
                ChatUser newUser =
                await ParentForm.MyHubConnection.InvokeAsync<ChatUser>("LogIn", UsernameTextBox.Text, PasswordTextBox.Text);

                if (newUser != null)
                {

                    ParentForm.AuthorizedUser = newUser;

                    ParentForm.UserLogIn(newUser.Username);

                    Close();
                }
                else ErrorLabel.Text = "Wrong username or password";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InvisibleAcceptButton_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = String.Empty;
            if (ActiveControl == UsernameTextBox)
            {
                PasswordTextBox.Focus();
                return;
            }
            if (ActiveControl == PasswordTextBox)
            {

                if (TopLabel.Text == "Log in")
                {

                    LogInButton_Click(this, new EventArgs());
                    return;
                }
                else
                {

                    RepeatPasswordTextBox.Focus();
                    return;
                }
            }
            if (ActiveControl == RepeatPasswordTextBox && TopLabel.Text == "Sign up")
            {

                SignUpButton_Click(this, new EventArgs());
                return;
            }
        }


    }
}

