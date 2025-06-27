using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ST10281928_PROG6221_POE
{
    class Functionality
    {
        private TextBox outputBox;

        public Functionality(TextBox outputBox)
        {
            this.outputBox = outputBox;
        }

        public Stack<string> log = new Stack<string>();
        public IDictionary<string, string> task = new Dictionary<string,string>();
        private int counter;
        private int stackCounter;
        public void taskAssistant(string input)
        {
             counter = 0;
            switch (counter)
            {
                case 0:
                    outputBox.AppendText("What is the name of the task?\n");
                    counter++;
                    break;
                case 1:
                    task.Add("Name", input);
                    outputBox.AppendText("What is the description of the task?\n");
                    counter++;
                    break;
                case 2:
                    task.Add("Description", input);
                    outputBox.AppendText("Would you like a reminder for the task?\n");
                    counter++;
                    break;
                default:
                    break;
            }

            if(counter ==3)
            {
                if(input == "yes")
                {
                    task.Add("Reminder", input);
                    counter = 0;
                    
                }
                task.Add("Reminder", "No");
                counter = 0;
            }
        }

        public void displayLog()
        {
            
            if (stackCounter <= 5)
            {
                foreach (var item in log)
                {
                    outputBox.AppendText($"{item}\n");
                    stackCounter++;
                }
            }
            {
                stackCounter = 0;
                log.Clear();
            }
        }
    }
}
