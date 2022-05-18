using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calc_bDs
{
    public partial class MainPage : ContentPage
    {
        string[] TextButtons = new string[19] {"c", "del", "%", "/",
                                                "7", "8", "9", "*",
                                                "4", "5", "6", "-",
                                                "1", "2", "3", "+",
                                                 "0", ",", "="};

        public MainPage()
        {
            int row = 1; int column = 0;
            Grid grid = new Grid();
            var ResultView = new Label
            {
                Text = "Рабotает!!",
                FontSize = 38,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.End
            };
            Grid.SetRow(ResultView, 0);
            Grid.SetColumn(ResultView, 0);
            Grid.SetColumnSpan(ResultView, 4);
            grid.Children.Add(ResultView);

            for (int i = 0; i < TextButtons.Length; i++)
            {
                Button FuncButton = new Button
                {
                    Text = TextButtons[i]
                };
                FuncButton.Clicked += Logic.DefineButton;
                Grid.SetRow(FuncButton, row);
                Grid.SetColumn(FuncButton, column);
                grid.Children.Add(FuncButton);
                column++;
                if (column > 3)
                {
                    column = 0;
                    row++;
                }
                if (column == 0 && row == 5)
                {
                    column++;
                }
            }

            this.Content = grid;
        }
    }
}