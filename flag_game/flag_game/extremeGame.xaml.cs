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
    /// Interaction logic for extremeGame.xaml
    /// </summary>
    public partial class extremeGame : Window
    {
        
        public extremeGame()
        {
           // this.map = map;
            InitializeComponent();

            map.Source = new BitmapImage(new Uri("../../Images/eu.jpg", UriKind.Relative));

            
          

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
