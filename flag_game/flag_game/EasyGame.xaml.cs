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
using System.Windows.Shapes;

namespace flag_game
{
    /// <summary>
    /// Interaction logic for EasyGame.xaml
    /// </summary>
    public partial class EasyGame : Window
    {
        public EasyGame()
        {
            InitializeComponent();
            Mast.Source = new BitmapImage(new Uri("../../Images/UK.jpg", UriKind.Relative));
            String[] countries = new String[] { "UK", "France", "Japan", "Sweden" };

            ans1.Content = countries[3];
            ans2.Content = countries[1];
            ans3.Content = countries[2];
            ans4.Content = countries[0];
        }
    }
}
