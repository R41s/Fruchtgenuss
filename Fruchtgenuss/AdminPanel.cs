using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Fruchtgenuss
{
    class AdminPanel : GroupBox
    {
        private string secretPassphrase = "Kaufomat";
        private bool isLoggedIn = false;
        private TextBox passphraseTextBox;
        private Button login;

        public AdminPanel()
        {
            passphraseTextBox = new TextBox();
            passphraseTextBox.Parent = this;
            passphraseTextBox.Width = 90;
            passphraseTextBox.Left = 10;
            passphraseTextBox.Top = 20;
            passphraseTextBox.UseSystemPasswordChar = true;

            login = new Button();
            login.Parent = this;
            login.Width = 90;
            login.Left = 10;
            login.Top = 40;
            login.Text = "Login";
            login.Click += Login_Click;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            isLoggedIn = !isLoggedIn && passphraseTextBox.Text == secretPassphrase;
            login.Text = isLoggedIn ? "Logout" : "Login";
            passphraseTextBox.Clear();
        }

        public bool isLogged()
        {
            return isLoggedIn;
        }
    }
}
