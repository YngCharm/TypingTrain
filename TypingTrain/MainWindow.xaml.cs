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
using System.Windows.Threading;

namespace TypingTrain
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isCapsLockOn;
        private bool isShiftPressed;

        public MainWindow()
        {
            InitializeComponent();

            this.KeyDown += MainWindow_KeyDown;
            this.KeyUp += MainWindow_KeyUp;
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.CapsLock)
            {
                isCapsLockOn = !isCapsLockOn;
            }

            if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
            {
                isShiftPressed = true;
            }

            UpdateButtonText();
        }

        private void MainWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
            {
                isShiftPressed = false;
            }

            UpdateButtonText();
        }

        private void UpdateButtonText()
        {
            firstButton.Content = isCapsLockOn ? (isShiftPressed ? "Q" : "q") : (isShiftPressed ? "q" : "Q");
            secondButton.Content = isCapsLockOn ? (isShiftPressed ? "W" : "w") : (isShiftPressed ? "w" : "W");
            thirdButton.Content = isCapsLockOn ? (isShiftPressed ? "E" : "e") : (isShiftPressed ? "e" : "E");
            fourthtButton.Content = isCapsLockOn ? (isShiftPressed ? "R" : "r") : (isShiftPressed ? "r" : "R");
        }
    

    private void Start_Button_Click(object sender, RoutedEventArgs e)
        {
            outputText.Text = null;
            startButton.IsEnabled = false;
            start();
        }
        private void Stop_Button_Click(object sender, RoutedEventArgs e)
        {
            startButton.IsEnabled = true;
            firstButton.IsEnabled = false;
            secondButton.IsEnabled = false;
            thirdButton.IsEnabled = false;
            fourthtButton.IsEnabled = false;
            stopButton.IsEnabled = false;
        }
        public void start()
        {
            firstButton.IsEnabled = true;
            secondButton.IsEnabled = true;
            thirdButton.IsEnabled = true;
            fourthtButton.IsEnabled = true;
            stopButton.IsEnabled = true;
            
        }

        private void First_Button_Click(object sender, RoutedEventArgs e)
        {
            if (isCapsLockOn)
            {
                outputText.Text += isShiftPressed ? "Q" : "q";
            }
            else
            {
                outputText.Text += isShiftPressed ? "q" : "Q";
            }
        }

        private void Second_Button_Click(object sender, RoutedEventArgs e)
        {
            if (isCapsLockOn)
            {
                outputText.Text += isShiftPressed ? "W" : "w";
            }
            else
            {
                outputText.Text += isShiftPressed ? "w" : "W";
            }
        }

        private void Third_Button_Click(object sender, RoutedEventArgs e)
        {
            if (isCapsLockOn)
            {
                outputText.Text += isShiftPressed ? "E" : "e";
            }
            else
            {
                outputText.Text += isShiftPressed ? "e" : "E";
            }
        }

        private void Fourth_Button_Click(object sender, RoutedEventArgs e)
        {
            if (isCapsLockOn)
            {
                outputText.Text += isShiftPressed ? "R" : "r";
            }
            else
            {
                outputText.Text += isShiftPressed ? "r" : "R";
            }
        }
    }
}
