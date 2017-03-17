using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool open;
        public MainWindow()
        {
            InitializeComponent();
            open = true;
        }

        private void MenuBtn_OnClick(object sender, RoutedEventArgs e)
        {
            if (open)
            {
                sideBarColumn.Width = new GridLength(0.05, GridUnitType.Star);
                open = false;
            }
            else
            {
                sideBarColumn.Width = new GridLength(0.2, GridUnitType.Star);
                open = true;
            }
        }

        private void EventSetter_OnHandler(object sender, MouseEventArgs e)
        {
            Label t = (Label) sender;
            t.Background = new SolidColorBrush(Colors.Aqua);
            Cursor = Cursors.Hand;
        }

        private void EventSetters_OnHandler(object sender, MouseEventArgs e)
        {
            Label t = (Label)sender;
            t.Background = new SolidColorBrush(Colors.Transparent);
            Cursor = Cursors.Arrow;
        }
    }
}
