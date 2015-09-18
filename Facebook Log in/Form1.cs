using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;

namespace Facebook_Log_in
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string OAuthURL = @"https://www.facebook.com/dialog/oauth?client_id=323356637789373&redirect_uri= https://www.facebook.com/connect/login_success.html&response_type=token";
            webFacebook.Navigate(OAuthURL);
        }

        private void webFacebook_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string url1 = webFacebook.Url.AbsoluteUri;
            string url2 = url1.Substring(url1.IndexOf("access_token") + 13);
            string access_token = url2.Substring(0, url2.IndexOf("&"));
            MessageBox.Show("access_toke = "+ access_token);

            FacebookClient fb = new FacebookClient(access_token);

            dynamic data = fb.Get("/me");

            MessageBox.Show("id="+data.id + Environment.NewLine + "name="+data.name);

        }
    }
}
