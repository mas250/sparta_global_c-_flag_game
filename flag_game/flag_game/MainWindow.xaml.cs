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
            intro.Text = "Rules:You will have 30 seconds to match flags with their name! You have three lives - lose them all and its game over!";    
        }

        private void launch_easy(object sender, RoutedEventArgs e)
        {
            makeFlags mf = new makeFlags();
            Flag[] allFlags = mf.createFlags();
            EasyGame eg = new EasyGame(allFlags);
            eg.Show();
            this.Close();
           
        }

        private void HardButton_Click(object sender, RoutedEventArgs e)
        {
            makeFlags mf = new makeFlags();
            Flag[] allFlags = mf.createFlags();
            hardGame hg = new hardGame(allFlags);
            hg.Show();
            this.Close();
        }

       

        
    }
}
