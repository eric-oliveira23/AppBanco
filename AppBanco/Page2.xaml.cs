using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBanco
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2(string user)
        {
            InitializeComponent();
            lbl_username.Text = user;
            lbl_username.FontSize = 25;
            lblcard_user.Text = user;
            lblcard_user.FontSize = 20;
            lblSaldo.Text = saldo.ToString("C");
            lblSaldo.FontSize = 20;
        }

        double saldo = 1220.89; 

        private void btn_hide(object sender, EventArgs e)
        {
            if (lblSaldo.Text == "--------")
            {
                lblSaldo.Text = saldo.ToString("C");
            }
            else
            {
                lblSaldo.Text = "--------";
            }     
        }

        private async void btn_back(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}