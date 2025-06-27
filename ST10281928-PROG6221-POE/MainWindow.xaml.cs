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
        public string userName;
        private int count;
        private Responses resp;
        private Functionality func;
        public MainWindow()
        {
            InitializeComponent();
            resp = new Responses(output, func);
            output.AppendText(art());
            greeting();
            output.ScrollToEnd();
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
        public string art()
        {
            string art = @"                                                    
                                                    
                  .              ...                
                  +    .=:.     .-:. =              
                  +     .--.  .-:.   =              
                  +     .--. :=..    =              
        ......+=    .:..*++:::=:.    .              
         ...  ::  .:=+-=-..-=-+=-.                  
              :: .++:. ..::.. .:++.   .=-.          
              :-==+* .+:=-==:*. *+.   :=..          
              .---+*:+=-*++*-=+-*+:..===.           
        .:::::   .+#-+=-=++=-=+-*+::+....           
          -=+++++++#:=..=-==..=-*+. -.              
          ..-. ...*#.=#:*==*.#+.**. -.              
            :.    ---..=#***+..---.   .....         
                 .:=+=:.     :=*+=-                 
                .::=-:+=-==-=+=*:.-.                
                .+:.  ..:==:..:*#*. -:              
        .........=. .=: .-=. =*%:   -:              
             ...:+. .=: .==.  .-=   -:              
               .:=. .=: .==.        -:              
                    ...  ..         ..              
                                                    
                                                    
                                                    
                                                    
                                                    
                                                    ";
            return art;
        }

        public void greeting()
        {
            output.AppendText("Hi I am a cyber security chatbot.\nI am here to assist you with learning more\n" +
                "about cyber security and being safe online.\n" +
                "Why don't we start off by you telling me your name?\n");
        }
        private void send_input_Click(object sender, RoutedEventArgs e)
        {
            if (count == 0)
            {
                userName = input.Text;
                output.AppendText($"{userName} nice to meet you. Welcome, I hope I will be of great help to you\nAsk me anything\n" +
                $"Type 'exit' to stop the chatbot\n");
                output.ScrollToEnd();
                input.Text = "";
                count++;
            }
            else
            {


                output.AppendText($"{input.Text}\n");
                resp.Basic_Responses(input.Text);
                output.ScrollToEnd();
                input.Text = "";
            }
        }

    }
}
