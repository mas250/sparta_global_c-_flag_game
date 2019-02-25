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
    /// 
   
    public partial class EasyGame : Window
    {
    Flag[] allFlags;
    public EasyGame(Flag[] allflags)
        {
            InitializeComponent();

            this.allFlags = allFlags;


           string a = allflags[0].Path;
           string b = allflags[0].Name;
            // Randomizer.Randomize(allFlags);//


            Mast.Source = new BitmapImage(new Uri(a, UriKind.Relative));//

            string[] anwsers = new string[] { allflags[0].Name, allflags[1].Name, allflags[2].Name, allflags[3].Name };
            rand.Randomizer.Randomize(anwsers);
            //string correctAnswer = allFlags[0].Name;
            ans1.Content = anwsers[0];
            ans2.Content = anwsers[1];
            ans3.Content = anwsers[2];
            ans4.Content = anwsers[3];


        }
        

        private void Ans1_Click(object sender, RoutedEventArgs e)
        {
            //if (ans1.Content.ToString() == correctAnswer)
            {

            }
        }
    }
}
