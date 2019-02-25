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

namespace flag_game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            intro.Text = "*Welcome* \n *Rules*";
        }

        

        private void launch_easy(object sender, RoutedEventArgs e)
        {
            //Window1 myWindow = new Window1();
            EasyGame eg = new EasyGame();
            //Window eg = new Window();
            eg.Show();
            this.Close();
        }

    }
}
