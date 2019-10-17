using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Nädal
{
    public partial class MainPage : ContentPage
    {
        Button btn;
        Button btn1;
        Button btn2;
        Button btn3;
        Button btn4;
        Button btn5;
        Button btn6;
  
        public MainPage()
        {
            btn = new Button()
            {
                Text="Esmaspäev"
            };
            btn1 = new Button()
            {
                Text = "Teisipäev"
            }; 
            btn2 = new Button()
            {
                Text = "Kolmapäev"
            };
            btn3 = new Button()
            {
                Text = "Neljapäev"
            };
            btn4 = new Button()
            {
                Text = "Reede"
            };
            btn5 = new Button()
            {
                Text = "Lauapäev"
            };
            btn6 = new Button()
            {
                Text = "Pühapäev"
            };


            StackLayout stackLayout = new StackLayout()
            {
                Children = { btn, btn1, btn2, btn3, btn4, btn5, btn6 }
            };
            stackLayout.Spacing = 8;
            this.Content = stackLayout;

            btn.Clicked += Btn_Clicked;
            btn1.Clicked += Btn1_Clicked;
            btn2.Clicked += Btn2_Clicked;
            btn3.Clicked += Btn3_Clicked;
            btn4.Clicked += Btn4_Clicked;
            btn5.Clicked += Btn5_Clicked;
            btn6.Clicked += Btn6_Clicked;
            
        }

        private async void Btn6_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pühapäev());
        }

        private async void Btn5_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lauapäev());
        }

        private async void Btn4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Reede());
        }

        private async void Btn3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Neljapäev());
        }

        private async void Btn2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Kolmapäev());
        }

        private async void Btn1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Teisipäev());
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Esmaspäev());
        }
    }
    
}
