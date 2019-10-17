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
    public partial class Esmaspäev : ContentPage
    {
        public Esmaspäev()
        {
            Grid grid = new Grid
            {
                RowDefinitions =
                {
                new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                new RowDefinition{Height=new GridLength(1,GridUnitType.Star)}
                },
                ColumnDefinitions =
                {
                new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)}
                }

            };
            BoxView b1 = new BoxView { Color = Color.WhiteSmoke };
            BoxView b2 = new BoxView { Color = Color.DarkBlue };
            BoxView b3 = new BoxView { Color = Color.Blue };
            BoxView b4 = new BoxView { Color = Color.Gray };
            BoxView b5 = new BoxView { Color = Color.WhiteSmoke };
            BoxView b6 = new BoxView { Color = Color.WhiteSmoke };
            BoxView b7 = new BoxView { Color = Color.WhiteSmoke };
           
            grid.Children.Add(b1, 0, 0);
            grid.Children.Add(b2, 0, 1);
            grid.Children.Add(b3, 0, 2);
            grid.Children.Add(b4, 0, 3);
            grid.Children.Add(b5, 0, 4);
            grid.Children.Add(b6, 0, 5);
            grid.Children.Add(b7, 0, 6);

            BoxView b11 = new BoxView { Color = Color.Pink };
            BoxView b22 = new BoxView { Color = Color.Red };
            BoxView b33 = new BoxView { Color = Color.Blue };
            BoxView b44 = new BoxView { Color = Color.Gray };
            BoxView b55 = new BoxView { Color = Color.WhiteSmoke };
            BoxView b66 = new BoxView { Color = Color.WhiteSmoke };
            BoxView b77 = new BoxView { Color = Color.WhiteSmoke };

            grid.Children.Add(b11, 1, 0);
            grid.Children.Add(b22, 1, 1);
            grid.Children.Add(b33, 1, 2);
            grid.Children.Add(b44, 1, 3);
            grid.Children.Add(b55, 1, 4);
            grid.Children.Add(b66, 1, 5);
            grid.Children.Add(b77, 1, 6);

            BoxView b111 = new BoxView { Color = Color.Gray };
            BoxView b222 = new BoxView { Color = Color.WhiteSmoke };
            BoxView b333 = new BoxView { Color = Color.Blue };
            BoxView b444 = new BoxView { Color = Color.Red };
            BoxView b555 = new BoxView { Color = Color.Yellow };
            BoxView b666 = new BoxView { Color = Color.WhiteSmoke };
            BoxView b777 = new BoxView { Color = Color.WhiteSmoke };

            grid.Children.Add(b111, 2, 0);
            grid.Children.Add(b222, 2, 1);
            grid.Children.Add(b333, 2, 2);
            grid.Children.Add(b444, 2, 3);
            grid.Children.Add(b555, 2, 4);
            grid.Children.Add(b666, 2, 5);
            grid.Children.Add(b777, 2, 6);

            grid.Children.Add(new BoxView { Color = Color.Red }, 3, 0);
            grid.Children.Add(new BoxView { Color = Color.Green }, 3, 1);
            grid.Children.Add(new BoxView { Color = Color.Violet }, 3, 2);
            grid.Children.Add(new BoxView { Color = Color.Red }, 3, 3);
            grid.Children.Add(new BoxView { Color = Color.WhiteSmoke }, 3, 4);
            grid.Children.Add(new BoxView { Color = Color.WhiteSmoke }, 3, 5);
            grid.Children.Add(new BoxView { Color = Color.WhiteSmoke }, 3, 6);

            grid.Children.Add(new BoxView { Color = Color.WhiteSmoke }, 4, 0);
            grid.Children.Add(new BoxView { Color = Color.Purple }, 4, 1);
            grid.Children.Add(new BoxView { Color = Color.Pink }, 4, 2);
            grid.Children.Add(new BoxView { Color = Color.DarkBlue }, 4, 3);
            grid.Children.Add(new BoxView { Color = Color.Purple }, 4, 4);
            grid.Children.Add(new BoxView { Color = Color.WhiteSmoke }, 4, 5);
            grid.Children.Add(new BoxView { Color = Color.WhiteSmoke }, 4, 6);

            grid.Children.Add(new BoxView { Color = Color.Yellow }, 5, 0);
            grid.Children.Add(new BoxView { Color = Color.Violet }, 5, 1);
            grid.Children.Add(new BoxView { Color = Color.Pink }, 5, 2);
            grid.Children.Add(new BoxView { Color = Color.WhiteSmoke }, 5, 3);
            grid.Children.Add(new BoxView { Color = Color.Red }, 5, 4);
            grid.Children.Add(new BoxView { Color = Color.WhiteSmoke }, 5, 5);
            grid.Children.Add(new BoxView { Color = Color.WhiteSmoke }, 5, 6);

            grid.Children.Add(new BoxView { Color = Color.Purple }, 6, 0);
            grid.Children.Add(new BoxView { Color = Color.WhiteSmoke }, 6, 1);
            grid.Children.Add(new BoxView { Color = Color.WhiteSmoke }, 6, 2);
            grid.Children.Add(new BoxView { Color = Color.Blue }, 6, 3);
            grid.Children.Add(new BoxView { Color = Color.Red }, 6, 4);
            grid.Children.Add(new BoxView { Color = Color.WhiteSmoke }, 6, 5);
            grid.Children.Add(new BoxView { Color = Color.WhiteSmoke }, 6, 6);

            Content = grid;
        }
    }
}