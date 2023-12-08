using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using System.Windows.Threading;

namespace TypingTrain
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isShiftPressed = false;

        private bool regist = false;

        public MainWindow()
        {
            InitializeComponent();

            stopBtn.IsEnabled = false;

            /*this.KeyDown += MainWindow_KeyDown;
            this.KeyUp += MainWindow_KeyUp;*/
        }

        private void Start_Button_Click(object sender, RoutedEventArgs e)
        {
            stopBtn.IsEnabled = true;
            startBtn.IsEnabled = false;

            randowSymbols();
            outputBlock.Focusable = true;
            outputBlock.Focus();

        }

        private void Stop_Button_Click(object sender, RoutedEventArgs e)
        {
            stopBtn.IsEnabled = false;
            startBtn.IsEnabled = true;

        }

        private void Button_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void outputBlock_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.LeftShift || e.Key == Key.RightShift)
            {
                if (regist)
                {
                    blockQ.Text = blockQ.Text.ToLower();
                    blockU.Text = blockU.Text.ToLower();
                    blockX.Text = blockX.Text.ToLower();
                    blockR.Text = blockR.Text.ToLower();

                    regist = false;
                }
                else
                {
                    blockQ.Text = blockQ.Text.ToUpper();
                    blockU.Text = blockU.Text.ToUpper();
                    blockX.Text = blockX.Text.ToUpper();
                    blockR.Text = blockR.Text.ToUpper();
                    regist = true;
                }

            }


            if (e.Key == Key.Q )
            {
                outputBlock.Text += blockQ.Text;
                keyOne.Background = new SolidColorBrush(Colors.White);
            }
            if (e.Key == Key.U)
            {
                outputBlock.Text += blockU.Text;
                keyTwo.Background = new SolidColorBrush(Colors.White);

            }
            if (e.Key == Key.X)
            {
                outputBlock.Text += blockX.Text;
                keyThree.Background = new SolidColorBrush(Colors.White);
            }
            if (e.Key == Key.R)
            {
                outputBlock.Text += blockR.Text;
                keyFour.Background = new SolidColorBrush(Colors.White);
            }
            if(e.Key == Key.CapsLock)
            {
                if (regist)
                {
                    blockQ.Text = blockQ.Text.ToLower();
                    blockU.Text = blockU.Text.ToLower();
                    blockX.Text = blockX.Text.ToLower();
                    blockR.Text = blockR.Text.ToLower();

                    regist = false;
                }
                else
                {
                    blockQ.Text = blockQ.Text.ToUpper();
                    blockU.Text = blockU.Text.ToUpper();
                    blockX.Text = blockX.Text.ToUpper();
                    blockR.Text = blockR.Text.ToUpper();
                    regist = true;
                }
            }

            if (e.Key == Key.Back && !outputBlock.Text.Equals(""))
            {
                outputBlock.Text = outputBlock.Text.Remove(outputBlock.Text.Length - 1);
            }
        }

        private void outputBlock_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
            {
                if (regist)
                {
                    blockQ.Text = blockQ.Text.ToLower();
                    blockU.Text = blockU.Text.ToLower();
                    blockX.Text = blockX.Text.ToLower();
                    blockR.Text = blockR.Text.ToLower();

                    regist = false;
                }
                else
                {
                    blockQ.Text = blockQ.Text.ToUpper();
                    blockU.Text = blockU.Text.ToUpper();
                    blockX.Text = blockX.Text.ToUpper();
                    blockR.Text = blockR.Text.ToUpper();
                    regist = true;
                }

            }

            if (e.Key == Key.Q)
            {
                keyOne.Background = new SolidColorBrush(Colors.LightGreen);
            }
            if (e.Key == Key.U)
            {
                keyTwo.Background = new SolidColorBrush(Colors.LightBlue);
            }
            if (e.Key == Key.X)
            {
                keyThree.Background = new SolidColorBrush(Colors.LemonChiffon);
            }
            if (e.Key == Key.R)
            {
                keyFour.Background = new SolidColorBrush(Colors.LightPink);
            }
           
        }

        public void randowSymbols()
        {
            inputBLock.Text = null;
            char[] chars = { 'q', 'u', 'Q', 'U', 'x', 'X', 'r', 'R' };
            Random random = new Random();
            for(int i=0; i<chars.Length; i++) {
            int rndChar = random.Next(0, 7);
            inputBLock.Text += chars[rndChar];
            }
        }

        public void checkSymbols()
        {
            for (int i = 0; i < 8; i++)
            {
                if (inputBLock.Text[i] != outputBlock.Text[i])
                {
                    outputBlock.Background = new SolidColorBrush(Colors.Red);
                }
            }
        }
    }
}
