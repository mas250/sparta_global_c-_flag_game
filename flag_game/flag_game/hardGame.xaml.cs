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
using System.Timers;
using System.Threading;

namespace flag_game
{
    /// <summary>
    /// Interaction logic for hardGame.xaml
    /// </summary>
    public partial class hardGame : Window
    {
        Flag[] allFlags;
        int lives = 3;
        System.Timers.Timer aTimer = new System.Timers.Timer();
        public hardGame(Flag[] allflags)
        {
            InitializeComponent();
            this.allFlags = allFlags;

            mast1.Source = new BitmapImage(new Uri(allflags[0].Path, UriKind.Relative));
            makeQuestion(allflags);
            makeTimer();

        }

        private void makeQuestion(Flag[] allflags)
        {
            livesLabel.Content = "lives: " + lives;
            rand.Randomizer.Randomize(allflags);
            mainFlag.Text = allflags[0].Name;


            
            Flag[] anwsers = new Flag[] { allflags[0], allflags[1], allflags[2], allflags[3] };
            rand.Randomizer.Randomize(anwsers);

            ans1.Background = Brushes.Wheat;
            ans2.Background = Brushes.Wheat;
            ans3.Background = Brushes.Wheat;
            ans4.Background = Brushes.Wheat;

            ans1.Content = anwsers[0].Name;
            ans2.Content = anwsers[3].Name;
            ans3.Content = anwsers[1].Name;
            ans4.Content = anwsers[2].Name;

            mast1.Source = new BitmapImage(new Uri(anwsers[0].Path, UriKind.Relative));
            mast2.Source = new BitmapImage(new Uri(anwsers[1].Path, UriKind.Relative));
            mast3.Source = new BitmapImage(new Uri(anwsers[2].Path, UriKind.Relative));
            mast4.Source = new BitmapImage(new Uri(anwsers[3].Path, UriKind.Relative));

            allFlags = allflags; //convert to global variable
        }

        private void Ans1_Click(object sender, RoutedEventArgs e)
        {

            if (ans1.Content.ToString() == allFlags[0].Name.ToString())
            {
                ans1.Background = Brushes.LightGreen;
                ans1.Foreground = Brushes.LightGreen;
                correctAnswer();
            }
            else
            {
                ans1.Background = Brushes.Red;
                ans1.Foreground = Brushes.Red;
                wrongAnwser();


                if (lives != 0)
                {
                    makeQuestion(allFlags);
                }
                else
                {

                    gameOver();
                }
            }
        }
        private void Ans2_Click(object sender, RoutedEventArgs e)
        {
            if (ans2.Content.ToString() == allFlags[0].Name.ToString())
            {
                ans2.Background = Brushes.LightGreen;
                ans2.Foreground = Brushes.LightGreen;
                correctAnswer();
            }
            else
            {
                ans2.Background = Brushes.Red;
                ans2.Foreground = Brushes.Red;
                wrongAnwser();
                if (lives != 0)
                {
                    makeQuestion(allFlags);
                }
                else
                {
                    gameOver();
                }
            }
        }
        private void Ans3_Click(object sender, RoutedEventArgs e)
        {
            if (ans3.Content.ToString() == allFlags[0].Name.ToString())
            {
                ans3.Background = Brushes.LightGreen;
                ans3.Foreground = Brushes.LightGreen;
                correctAnswer();
            }
            else
            {
                ans3.Background = Brushes.Red;
                ans3.Foreground = Brushes.Red;
                wrongAnwser();
                if (lives != 0)
                {
                    makeQuestion(allFlags);
                }
                else
                {
                    gameOver();
                }
            }
        }
        private void Ans4_Click(object sender, RoutedEventArgs e)
        {
            if (ans4.Content.ToString() == allFlags[0].Name.ToString())
            {
                ans4.Background = Brushes.LightGreen;
                ans4.Foreground = Brushes.LightGreen;
                correctAnswer();
            }
            else
            {
                ans4.Background = Brushes.Red;
                ans4.Foreground = Brushes.Red;
                wrongAnwser();
                if (lives != 0)
                {
                    makeQuestion(allFlags);
                }
                else
                {
                    gameOver();
                }
            }
        }

        private void correctAnswer()
        {
            MessageBox.Show("yes!");
            makeQuestion(allFlags);
        }
        private void wrongAnwser()
        {
            MessageBox.Show("haha, no!");
            Thread.Sleep(250);
            lives = lives - 1;
        }
        private void gameOver()
        {
            aTimer.Enabled = false;
            MessageBox.Show("you lose :-(");
            Task.Factory.StartNew(() =>     //dispatcher used to manage threads
            {
                InvokeMethodExample();
            });

        }

        private void InvokeMethodExample()
        {
            Thread.Sleep(500);
            Dispatcher.Invoke(() =>
            {

                MainWindow mw = new MainWindow();
                mw.Show();
                this.Close();           //Timer runs on its own threads
            });
        }




        private void makeTimer()
        {
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 30000;
            aTimer.Enabled = true;
        }
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            timeUp();
        }
        private void timeUp()
        {
            aTimer.Enabled = false;
            MessageBox.Show("You Win :-D");
            Task.Factory.StartNew(() =>     //dispatcher used to manage threads
            {
                InvokeMethodExample();
            });
        }
    }
}
