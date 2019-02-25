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
            Flag uk = new Flag( );
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

            String[] flags = new String[] {uk.Path, france.Path, japan.Path, china.Path };
            String[] countries = new String[] { uk.Name, france.Name, japan.Name, china.Name };
           // Flag[] allFlags = new Flag[]

            Randomizer.Randomize(flags);
            Randomizer.Randomize(countries);
            Mast.Source = new BitmapImage(new Uri(flags[0], UriKind.Relative));

            //anwser = flags[0].Name;

            ans1.Content = countries[0];
            ans2.Content = countries[1];
            ans3.Content = countries[2];
            ans4.Content = countries[3];


        }
        public class Randomizer
        {
            public static void Randomize<T>(T[] items)
            {
                Random rand = new Random();

                // For each spot in the array, pick
                // a random item to swap into that spot.
                for (int i = 0; i < items.Length - 1; i++)
                {
                    int j = rand.Next(i, items.Length);
                    T temp = items[i];
                    items[i] = items[j];
                    items[j] = temp;
                }
            }
        }

    }
}
