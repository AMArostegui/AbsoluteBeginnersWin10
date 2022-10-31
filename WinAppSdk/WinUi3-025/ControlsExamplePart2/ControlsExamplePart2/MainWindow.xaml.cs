using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ControlsExamplePart2
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private string[] selectionItems = new string[] { "Ferdinand", "Frank", "Frida", "Nigel", "Tag", "Tanya", "Tanner", "Todd" };

        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void MyCalendarView_SelectedDatesChanged(CalendarView sender, CalendarViewSelectedDatesChangedEventArgs args)
        {
            var selectedDates = sender.SelectedDates.Select(p => p.Date.Month.ToString() + "/" + p.Date.Day.ToString()).ToArray();
            var values = string.Join(", ", selectedDates);
            CalendarViewResultTextBlock.Text = values;
        }

        private void InnerFlyoutButton_Click(object sender, RoutedEventArgs e)
        {
            MyFlyout.Hide();
        }

        private void MyAutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            var autoSuggestBox = (AutoSuggestBox)sender;
            var filtered = selectionItems.Where(p => p.StartsWith(autoSuggestBox.Text)).ToArray();
            autoSuggestBox.ItemsSource = filtered;
        }
    }
}
