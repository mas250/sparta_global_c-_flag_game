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
        int lives = 3;

        public EasyGame(Flag[] allflags)
        {
            InitializeComponent();

            this.allFlags = allFlags;   //flag list AllFlags created at page load

            
            makeQuestion(allflags);
            

        }
        private void Ans1_Click(object sender, RoutedEventArgs e)
        {
            if (lives != 0)
            {
                if (ans1.Content.ToString() == allFlags[0].Name.ToString())
                {
                    MessageBox.Show("yes!");
                    makeQuestion(allFlags);
                }
                else
                {
                    MessageBox.Show("haha, no!");
                    lives = lives - 1;
                    makeQuestion(allFlags);
                }
            }
            else
            {
                MessageBox.Show("you lose :-(");
                MainWindow mw = new MainWindow();
                mw.Show();
                this.Close();
            }
            
        }
        private void Ans2_Click(object sender, RoutedEventArgs e)
        {
            if (ans2.Content.ToString() == allFlags[0].Name.ToString())
            {
                MessageBox.Show("yes!");
                makeQuestion(allFlags);
            }
            else
            {
                MessageBox.Show("haha, no!");
                makeQuestion(allFlags);
            }
        }
        private void Ans3_Click(object sender, RoutedEventArgs e)
        {
            if (ans3.Content.ToString() == allFlags[0].Name.ToString())
            {
                MessageBox.Show("yes!");
                makeQuestion(allFlags);
            }
            else
            {
                MessageBox.Show("haha, no!");
                makeQuestion(allFlags);
            }
        }
        private void Ans4_Click(object sender, RoutedEventArgs e)
        {
            if (ans4.Content.ToString() == allFlags[0].Name.ToString())
            {
                MessageBox.Show("yes!");
                makeQuestion(allFlags);
            }
            else
            {
                MessageBox.Show("haha, no!");
                makeQuestion(allFlags);
            }
        }

        private void makeQuestion(Flag[] allflags)
        {
            rand.Randomizer.Randomize(allflags);
            Mast.Source = new BitmapImage(new Uri(allflags[0].Path, UriKind.Relative));//

            string[] anwsers = new string[] { allflags[0].Name, allflags[1].Name, allflags[2].Name, allflags[3].Name };
            rand.Randomizer.Randomize(anwsers);

            ans1.Content = anwsers[0];
            ans2.Content = anwsers[1];
            ans3.Content = anwsers[2];
            ans4.Content = anwsers[3];

            allFlags = allflags; //convert to global variable

            
        }
        
    }
}
