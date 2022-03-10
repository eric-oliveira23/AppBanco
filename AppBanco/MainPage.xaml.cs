using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppBanco
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void btn_login(object sender, EventArgs e)
        {
            try
            {
                string username = ent_User.Text;
                int pass = int.Parse(ent_Pass.Text);             

                if (ent_User.Text.Length <= 0 || ent_Pass.Text.Length < 4)
                {
                    await DisplayAlert("Alerta", "Dados inválidos.", "OK");
                }
                else
                {
                    await Navigation.PushAsync(new Page2(ent_User.Text));
                }
                
            }

            catch (Exception)
            {
               await DisplayAlert("Alerta", "Erro desconhecido.", "OK");
            }
           
        }
         
        

        }

    }

