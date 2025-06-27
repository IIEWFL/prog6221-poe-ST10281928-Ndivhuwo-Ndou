using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace ST10281928_PROG6221_POE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Responses resp;
        private Functionality func;
        public MainWindow()
        {
            InitializeComponent();
            resp = new Responses(output, func);
            Play_Audio();
        }

        public void Play_Audio()
        {
            //This is a SoundPlayer object which will be used to call the wav audio
            //The audio is located in the bin> Debug
            SoundPlayer welcome = new SoundPlayer(@"IntroAudio.wav");
            welcome.Load();
            welcome.Play();
        }
        private void send_input_Click(object sender, RoutedEventArgs e)
        {
            //input.Text = "";
            resp.Basic_Responses(input.Text);
            output.ScrollToEnd();
            input.Text = "";
        }

        private void send_Click(object sender, RoutedEventArgs e)
        {
            input.Text = "";
            resp.Basic_Responses(input.Text);
        }
    }
}
