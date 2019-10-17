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
    public partial class Kolmapäev : ContentPage
    {
        StackLayout skt;
        public Kolmapäev()
        {
            Switch switchControl = new Switch { IsToggled = true };
            skt = new StackLayout()
            {
                Children = { switchControl }
            };
            skt.Spacing = 8;
            this.Content = skt;

        }
    }

   
}