using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace StupendousStyles
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class CoffeePage : Page
    {
        private string _roast;
        private string _sweetener;
        private string _cream;

        public CoffeePage()
        {
            this.InitializeComponent();
        }

        private void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            if (sender == ItemRoastDark)
            {
                _roast = "Dark";
            }
            else if (sender == ItemRoastMedium)
            {
                _roast = "Medium";
            }
            else if (sender == ItemRoastNone)
            {
                _roast = null;
            }
            else if (sender == ItemSweetenerNone)
            {
                _sweetener = "No Sweetener";
            }
            else if (sender == ItemSweetenerSugar)
            {
                _sweetener = "Sugar";
            }
            else if (sender == ItemCreamNone)
            {
                _cream = "No Cream";
            }
            else if (sender == ItemCream2Milk)
            {
                _cream = "2% Milk";
            }
            else if (sender == ItemCreamWholeMilk)
            {
                _cream = "Whole Milk";
            }

            if (string.IsNullOrEmpty(_roast))
            {
                OrderText.Text = "Coffee:";
                return;
            }

            OrderText.Text = $"Coffee:     {_roast}    {_sweetener}    {_cream}";
        }
    }
}
