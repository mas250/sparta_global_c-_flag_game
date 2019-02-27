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

        private void HardButton_Click(object sender, RoutedEventArgs e)
        {
            Flag[] allFlags = createFlags();
            hardGame hg = new hardGame(allFlags);
            hg.Show();
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

            Flag afghanistan = new Flag();
            afghanistan.Name = "Afghanistan";
            afghanistan.Path = "../../Images/afghanistan.jpg";

            Flag antigua = new Flag();
            antigua.Name = "Antigua";
            antigua.Path = "../../Images/antigua.jpg";

            Flag argentina = new Flag();
            argentina.Name = "Argentina";
            argentina.Path = "../../Images/argentina.jpg";

            Flag armenia = new Flag();
            armenia.Name = "Armenia";
            armenia.Path = "../../Images/armenia.jpg";

            Flag angola = new Flag();
            angola.Name = "Angola";
            angola.Path = "../../Images/angola.jpg";

            Flag australia = new Flag();
            australia.Name = "Australia";
            australia.Path = "../../Images/australia.jpg";

            Flag austria = new Flag();
            austria.Name = "Austria";
            austria.Path = "../../Images/austria.jpg";

            Flag azerbaijan = new Flag();
            azerbaijan.Name = "Azerbaijan";
            azerbaijan.Path = "../../Images/azerbaijan.jpg";

            Flag bahamas = new Flag();
            bahamas.Name = "Bahamas";
            bahamas.Path = "../../Images/bahamas.jpg";

            Flag bahrain = new Flag();
            bahrain.Name = "Baharin";
            bahrain.Path = "../../Images/bahrain.jpg";

            Flag bangladesh = new Flag();
            bangladesh.Name = "Bangladesh";
            bangladesh.Path = "../../Images/bangladesh.jpg";

            Flag barbados = new Flag();
            barbados.Name = "Barbados";
            barbados.Path = "../../Images/barbados.jpg";

            Flag belarus = new Flag();
            belarus.Name = "Belarus";
            belarus.Path = "../../Images/belarus.jpg";

            Flag belgium = new Flag();
            belgium.Name = "Belgium";
            belgium.Path = "../../Images/belgium.jpg";

            Flag belize = new Flag();
            belize.Name = "Belize";
            belize.Path = "../../Images/belize.jpg";

            //add more flags#


            Flag[] allFlags = new Flag[] { uk, france, japan, china, afghanistan, antigua, argentina,
                armenia, angola, australia, austria, azerbaijan, bahamas, bahrain, bangladesh, barbados,
                belarus, belgium, belize };
            rand.Randomizer.Randomize(allFlags);
            
            //place shuffled list in a list of length 4

            return allFlags;
        }

        
    }
}
