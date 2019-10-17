using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nädal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Teisipäev : ContentPage
    {
        public Teisipäev()
        {

            StackLayout stackLayout = new StackLayout();

            Button button = new Button
            {
                Text = "Нажми!",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            button.Clicked += OnButtonClicked;
            stackLayout.Children.Add(button);
            this.Content = stackLayout;
        }

        private void OnButtonClicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = "Нажато!";
            button.BackgroundColor = Color.Red;
        }

    }

        
    

}