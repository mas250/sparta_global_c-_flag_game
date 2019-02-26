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
            Flag[] allFlags = createFlags();
            EasyGame eg = new EasyGame(allFlags);
            eg.Show();
            this.Close();
        }

        private Flag[] createFlags() {
            Flag uk = new Flag();
            uk.Name = "UK";
            uk.Path = "../../Images/UK.jpg";

            Flag france = new Flag();
            france.Name = "France";
            france.Path = "../../Images/france.jpg";

            Flag japan = new Flag();
            japan.Name = "Japan";
            japan.Path = "../../Images/japan.jpg";

            Flag china = new Flag();
            china.Name = "China";
            china.Path = "../../Images/china.jpg";

            //add more flags
            Flag[] allFlags = new Flag[] { uk, france, japan, china };
            rand.Randomizer.Randomize(allFlags);
            
            //place shuffled list in a list of length 4

            return allFlags;
        }

    }
}
