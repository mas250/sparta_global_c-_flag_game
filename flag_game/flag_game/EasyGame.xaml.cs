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
    /// Interaction logic for EasyGame.xaml
    /// </summary>
    /// 

    public partial class EasyGame : Window
    {
        Flag[] allFlags;
        System.Timers.Timer aTimer = new System.Timers.Timer();
        int lives = 3;

        public EasyGame(Flag[] allflags)
        {
            InitializeComponent();
            this.allFlags = allFlags;   //flag list AllFlags created at page load

            makeQuestion(allflags);
            makeTimer();
            
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
        private void Ans1_Click(object sender, RoutedEventArgs e)
        {
            
                if (ans1.Content.ToString() == allFlags[0].Name.ToString())
                {
                    correctAnswer();
                }
                else
                {
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
                correctAnswer();
            }
            else
            {
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
                correctAnswer();
            }
            else
            {
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
                correctAnswer();
            }
            else
            {
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

        private void makeQuestion(Flag[] allflags)
        {
            livesLabel.Content = "lives: " + lives;
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

        private void correctAnswer()
        {
            MessageBox.Show("yes!");
            makeQuestion(allFlags);
        }

        private void wrongAnwser()
        {
            MessageBox.Show("haha, no!");
            lives = lives - 1;
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

        private void makeTimer()
        {
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 30000;
            aTimer.Enabled = true;
            timerLabel.Content = aTimer.ToString();

        }
       

        private  void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            timeUp();
        }
       
    }
}
