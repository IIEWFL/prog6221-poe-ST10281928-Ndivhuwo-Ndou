//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Controls;

//namespace ST10281928_PROG6221_POE
//{
//    public class Task
//    {
//        public string Name { get; set; }
//        public string Description { get; set; }
//        public string Reminder { get; set; }

//        public override string ToString()
//        {
//            return $"Task: Name={Name}, Description={Description}, Reminder={Reminder}";
//        }
//    }
//    class Functionality
//    {
//        private TextBox outputBox;

//        public Functionality(TextBox outputBox)
//        {
//            this.outputBox = outputBox;
//            this.tasks = new List<Task>();
//        }

//        public List<Task> tasks;
//        public Stack<string> log = new Stack<string>();
//        public IDictionary<string, string> task = new Dictionary<string,string>();
//        private int counter;
//        private int stackCounter;
//        public bool inTask = false;
//        public void taskAssistant(string input)
//        {
//            inTask = true;
//             //counter = 0;
//            switch (counter)
//            {
//                case 0:
//                    task = new Dictionary<string, string>();
//                    outputBox.AppendText("What is the name of the task?\n");
//                    counter++;
//                    break;
//                case 1:
//                    task.Add("Name", input);
//                    outputBox.AppendText("What is the description of the task?\n");
//                    counter++;
//                    break;
//                case 2:
//                    task.Add("Description", input);
//                    outputBox.AppendText("Would you like a reminder for the task?\n");
//                    counter++;
//                    break;
//                case 3:
//                    if (input.ToLower() == "yes")
//                    {
//                        //task.Add("Reminder", input);
//                        outputBox.AppendText("Enter the reminder date (yyyy/mm/dd) or day");
//                        counter++;
//                    }
//                    else
//                    {
//                        task.Add("Reminder", "No");
//                        addToList();
//                        inTask = false;
//                    }
//                        break;
//                case 4:
//                    task.Add("Reminder", input);
//                    addToList();
//                    inTask = false;
//                    break;
//                default:
//                    counter = 0;
//                    break;
//            }

//            //if(counter ==3)
//            //{
//            //    if(input.ToLower() == "yes")
//            //    {
//            //        task.Add("Reminder", input);
//            //        counter = 0;
//            //        return;
//            //    }
//            //    task.Add("Reminder", "No");
//            //    counter = 0;
//            //    return;
//            //}
//        }
//        public int listindex;
//        public void addToList()
//        {
//            var newTask = new Task
//            {
//                Name = task["Name"],
//                Description = task["Description"],
//                Reminder = task["Reminder"]
//            };
//            tasks.Insert(listindex,newTask);
//            outputBox.AppendText("Task created successfully!\n");
//            task = new Dictionary<string, string>();
//            listindex++;
//        }

//        public void displayLog()
//        {

//            if (stackCounter <= 10)
//            {
//                foreach (var item in log)
//                {
//                    outputBox.AppendText($"{item}\n");
//                    stackCounter++;
//                }
//            }
//            {
//                stackCounter = 0;
//                log.Clear();
//            }
//        }
//        //public IDictionary<string, string> quizQuestions = new Dictionary<string, string>()
//        //{
//        //    {"Question 1:",""},
//        //};
//        private int quizCounter;
//        public bool quizMode = false;
//        public int score;
//        public void quiz(string input)
//        {
//            quizMode = true;
//            switch (quizCounter)
//            {
//                case 0:
//                    outputBox.AppendText("Question 1: Which one is not a Cyber security topic?:\n" +
//                        "A. Phishing\n" +
//                        "B. Password Safety\n" +
//                        "C. Cyber bullying\n" +
//                        "D. Privacy\n");
//                    quizCounter++;
//                    break;
//                case 1:
//                    quizResponse(quizCounter-1,input);
//                    outputBox.AppendText("Question 2: What do you call somone who hacks with malicious intent?:\n" +
//                        "A. Black Hat Hacker\n" +
//                        "B. Grey Hat Hacker\n" +
//                        "C. White Hat Hacker\n" +
//                        "D. None of the above\n");
//                    quizCounter++;
//                    break;
//                case 2:
//                    quizResponse(quizCounter - 1, input);
//                    outputBox.AppendText("Question 3: Phishing is a for of social engineering?:\n" +
//                        "True\n" +
//                        "False\n");
//                    quizCounter++;
//                    break;
//                case 3:
//                    quizResponse(quizCounter - 1, input);
//                    outputBox.AppendText("Question 4: What is a sign that you are on a secured browser?:\n" +
//                        "A. Privacy:\n" +
//                        "B. A link to another page\n" +
//                        "C. Ads\n" +
//                        "D. HTTPS:\n");
//                    quizCounter++;
//                    break;
//                case 4:
//                    quizResponse(quizCounter - 1, input);
//                    outputBox.AppendText("Question 5: Social Engineering can be someone faking an identity?:\n" +
//                        "False\n" +
//                        "True\n");
//                    quizCounter++;
//                    break;
//                case 5:
//                    quizResponse(quizCounter - 1, input);
//                    outputBox.AppendText("Question 6: What should you do if you receive a link a suspicious email?:\n" +
//                        "A. Click it\n" +
//                        "B. Ignore it\n" +
//                        "C. Forward it\n" +
//                        "D. None of the Above\n");
//                    quizCounter++;
//                    break;
//                case 6:
//                    quizResponse(quizCounter - 1, input);
//                    outputBox.AppendText("Question 7: Its safe to save your passwords on your phone?:\n" +
//                        "True\n" +
//                        "False\n");
//                    quizCounter++;
//                    break;
//                case 7:
//                    quizResponse(quizCounter - 1, input);
//                    outputBox.AppendText("Question 8: Having your birthday as your password is safe?:\n" +
//                        "True\n" +
//                        "False\n");
//                    quizCounter++;
//                    break;
//                case 8:
//                    quizResponse(quizCounter - 1, input);
//                    outputBox.AppendText("Question 9: Which one is a violation of privacy?:\n" +
//                        "A. Stealing of passwords\n" +
//                        "B. Sharing someones personal information\n" +
//                        "C. Accessing somones online accounts\n" +
//                        "D. All of the above\n");
//                    quizCounter++;
//                    break;
//                case 9:
//                    quizResponse(quizCounter - 1, input);
//                    outputBox.AppendText("Question 10: Someone impersonating your boss to get your information\n" +
//                        "is a form of social engineering?:\n" +
//                        "True\n" +
//                        "False\n");
//                    quizCounter++;
//                    break;
//                case 10:
//                    quizResponse(quizCounter - 1, input);
//                    checkScore(score);
//                    outputBox.AppendText("\nLets continue with our chat. What can I help you with?\n");
//                    quizMode = false;
//                    break;
//                default:
//                    quizCounter = 0;
//                    break;
//            }
//        }

//        public void quizResponse(int counter,string input)
//        {
//            switch (counter)
//            {
//                case 0:
//                    if(input.ToLower() == "c")
//                    {
//                        outputBox.AppendText("You got it RIGHT!!!\n");
//                        score++;
//                    }
//                    else
//                    {
//                        outputBox.AppendText("The correct answer is C. Although the name Cyber Bullying seems like it is a Cyber\n" +
//                            "security topic, it is not. Cyber Bullying has to do with the use of cyber spaces\n" +
//                            "such as social media to bullying someone else not about your safety on the cyber space.\n");
//                    }
//                        break;
//                case 1:
//                    if (input.ToLower() == "a")
//                    {
//                        outputBox.AppendText("You got it RIGHT!!!\n");
//                        score++;
//                    }
//                    else
//                    {
//                        outputBox.AppendText("The correct answer is A. A black hat hacker is someone who hacks with malicious intent.\n" +
//                            "A grey hat hacker is someone who hacks without permission but they are doing it for themselves.\n" +
//                            "A white hat hacker is someone hired to test the secuirty of a system and they are given permission\n ");
//                    }
//                        break;
//                case 2:
//                    if (input.ToLower() == "true")
//                    {
//                        outputBox.AppendText("You got it RIGHT!!!\n");
//                        score++;
//                    }
//                    else
//                    {
//                        outputBox.AppendText("The correct answer is True. Phishing inlvoves emails or messages that might look legit\n" +
//                            "and coming from a real entity or person but it is fake. That is why it is Social Engineering because they \n" +
//                            "faking their identity.\n");
//                    }
//                        break;
//                case 3:
//                    if (input.ToLower() == "d")
//                    {
//                        outputBox.AppendText("You got it RIGHT!!!\n");
//                        score++;
//                    }
//                    else
//                    {
//                        outputBox.AppendText("The correct answer is D. HTTPS is an internet protocol and an extension\n" +
//                            "of HTTP. The 'S' stands for secured and that means that the domain is registered and protected\n");
//                    }
//                    break;
//                case 4:
//                    if (input.ToLower() == "true")
//                    {
//                        outputBox.AppendText("You got it RIGHT!!!\n");
//                        score++;
//                    }
//                    else
//                    {
//                        outputBox.AppendText("The correct answer is TRUE. Social Engineering is when someone learns about a specific\n" +
//                            "individual usually those with more access to information, and use their identity to gain information\n");
//                    }
//                        break;
//                case 5:
//                    if (input.ToLower() == "b")
//                    {
//                        outputBox.AppendText("You got it RIGHT!!!\n");
//                        score++;
//                    }
//                    else
//                    {
//                        outputBox.AppendText("The correct answer is B. It best you ignore these links and DO NOT forward them to someone\n" +
//                            "else because you will be liable for distributing a malicious link. You never know what these link have or lead to\n");
//                    }
//                        break;
//                case 6:
//                    if (input.ToLower() == "false")
//                    {
//                        outputBox.AppendText("You got it RIGHT!!!\n");
//                        score++;
//                    }
//                    else
//                    {
//                        outputBox.AppendText("The correct answer is FALSE. Storing passwords to your accounts on your phone is very dangerous\n" +
//                            "because if someone steals it or opens it they will access that information. To make it safer encrypt the document\n" +
//                            "where you stpre such information so that it becomes difficult to access it.\n");
//                    }
//                        break;
//                case 7:
//                    if (input.ToLower() == "false")
//                    {
//                        outputBox.AppendText("You got it RIGHT!!!\n");
//                        score++;
//                    }
//                    else
//                    {
//                        outputBox.AppendText("The correct answer is FALSE. The reason for this is because if someone tries to hack you the first password\n" +
//                            "they will try is your birthday. To combat this try having a complex password by incorporating special characters and numbers.\n");
//                    }
//                        break;
//                case 8:
//                    if (input.ToLower() == "d")
//                    {
//                        outputBox.AppendText("You got it RIGHT!!!\n");
//                        score++;
//                    }
//                    else
//                    {
//                        outputBox.AppendText("The correct answer is D. All of these are a violation of privacy especially if you were not given the permission\n" +
//                            "always ask for permission before you do something that involves someone else and their information, never assume. \n");
//                    }
//                        break;
//                case 9:
//                    if (input.ToLower() == "true")
//                    {
//                        outputBox.AppendText("You got it RIGHT!!!\n");
//                        score++;
//                    }
//                    else
//                    {
//                        outputBox.AppendText("The correct answer is TRUE. That is true because with Social Engineering the attacker is trying to access the information\n" +
//                            "that an individual has so they will impersonate them to get the information that they have.\n");
//                    }
//                        break;
//                default:
//                    break;
//            }
//        }

//        public void checkScore(int num)
//        {
//            if (num<=4)
//            {
//                outputBox.AppendText("Do not be discouraged it just meanst you have to learn more and luck for you\n" +
//                    "you have me.\n");
//            }else if (num>4 && num<8)
//            {
//                outputBox.AppendText("You did quite well you just need to polish up on some topics.\n");
//            }
//            else
//            {
//                outputBox.AppendText("Excellent!! You ight as well teach me :)\n");
//            }
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace ST10281928_PROG6221_POE
{
    public class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Reminder { get; set; }

        public override string ToString()
        {
            return $"Task: Name={Name}, Description={Description}, Reminder={Reminder}";
        }
    }

    class Functionality
    {
        private TextBox outputBox;

        public Functionality(TextBox outputBox)
        {
            this.outputBox = outputBox;
            this.tasks = new List<Task>();
        }

        public List<Task> tasks;
        public Stack<string> log = new Stack<string>();
        public IDictionary<string, string> task = new Dictionary<string, string>();
        private int counter;
        private int stackCounter;
        public bool inTask = false;

        public void taskAssistant(string input)
        {
            try
            {
                // Handle task deletion
                if (input.ToLower().StartsWith("delete ") && counter == 0)
                {
                    if (int.TryParse(input.Substring(7), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
                    {
                        tasks.RemoveAt(taskNumber - 1);
                        outputBox.AppendText($"Task {taskNumber} deleted successfully.\n");
                    }
                    else
                    {
                        outputBox.AppendText("Invalid task number. Please enter a valid task number (e.g., 'delete 1').\n");
                    }
                    outputBox.ScrollToEnd();
                    return;
                }

                // Handle empty or invalid input at any stage
                if (string.IsNullOrWhiteSpace(input))
                {
                    outputBox.AppendText("Error: Input cannot be empty. Please try again.\n");
                    if (counter > 0)
                    {
                        outputBox.AppendText("Restarting task creation. What is the name of the task?\n");
                        counter = 0;
                        task = new Dictionary<string, string>();
                        inTask = true;
                    }
                    outputBox.ScrollToEnd();
                    return;
                }

                inTask = true;
                switch (counter)
                {
                    case 0:
                        task = new Dictionary<string, string>();
                        outputBox.AppendText("What is the name of the task?\n");
                        counter = 1;
                        break;
                    case 1:
                        task["Name"] = input.Trim();
                        outputBox.AppendText($"Task name set to: {input}\n");
                        outputBox.AppendText("What is the description of the task?\n");
                        counter = 2;
                        break;
                    case 2:
                        task["Description"] = input.Trim();
                        outputBox.AppendText($"Task description set to: {input}\n");
                        outputBox.AppendText("Would you like a reminder for the task? (yes/no)\n");
                        counter = 3;
                        break;
                    case 3:
                        if (input.ToLower().Trim() == "yes")
                        {
                            if (task.ContainsKey("Name") && task.ContainsKey("Description"))
                            {
                                outputBox.AppendText("Enter the reminder date (yyyy/MM/dd) or day:\n");
                                counter = 4;
                            }
                            else
                            {
                                outputBox.AppendText("Error: Task name or description missing. Restarting task creation.\n");
                                outputBox.AppendText("What is the name of the task?\n");
                                counter = 0;
                                task = new Dictionary<string, string>();
                            }
                        }
                        else if (input.ToLower().Trim() == "no")
                        {
                            if (task.ContainsKey("Name") && task.ContainsKey("Description"))
                            {
                                task["Reminder"] = "No";
                                if (task.ContainsKey("Name") && task.ContainsKey("Description") && task.ContainsKey("Reminder"))
                                {
                                    addToList();
                                    log.Push($"Task: Name={task["Name"]}, Description={task["Description"]}, Reminder={task["Reminder"]}");
                                    outputBox.AppendText("Task creation completed.\n");
                                    counter = 0;
                                    task = new Dictionary<string, string>();
                                    inTask = false;
                                }
                                else
                                {
                                    outputBox.AppendText("Error: Incomplete task data. Restarting task creation.\n");
                                    outputBox.AppendText("What is the name of the task?\n");
                                    counter = 0;
                                    task = new Dictionary<string, string>();
                                }
                            }
                            else
                            {
                                outputBox.AppendText("Error: Task name or description missing. Restarting task creation.\n");
                                outputBox.AppendText("What is the name of the task?\n");
                                counter = 0;
                                task = new Dictionary<string, string>();
                            }
                        }
                        else
                        {
                            outputBox.AppendText("Error: Please enter 'yes' or 'no'.\n");
                            outputBox.ScrollToEnd();
                        }
                        break;
                    case 4:
                        if (task.ContainsKey("Name") && task.ContainsKey("Description"))
                        {
                            task["Reminder"] = input.Trim();
                            if (task.ContainsKey("Name") && task.ContainsKey("Description") && task.ContainsKey("Reminder"))
                            {
                                addToList();
                                log.Push($"Task: Name={task["Name"]}, Description={task["Description"]}, Reminder={task["Reminder"]}");
                                outputBox.AppendText("Task creation completed.\n");
                                counter = 0;
                                task = new Dictionary<string, string>();
                                inTask = false;
                            }
                            else
                            {
                                outputBox.AppendText("Error: Incomplete task data. Restarting task creation.\n");
                                outputBox.AppendText("What is the name of the task?\n");
                                counter = 0;
                                task = new Dictionary<string, string>();
                            }
                        }
                        else
                        {
                            outputBox.AppendText("Error: Task name or description missing. Restarting task creation.\n");
                            outputBox.AppendText("What is the name of the task?\n");
                            counter = 0;
                            task = new Dictionary<string, string>();
                        }
                        break;
                    default:
                        outputBox.AppendText("Error: Invalid state. Restarting task creation.\n");
                        outputBox.AppendText("What is the name of the task?\n");
                        counter = 0;
                        task = new Dictionary<string, string>();
                        inTask = true;
                        break;
                }
                outputBox.ScrollToEnd();
            }
            catch (Exception ex)
            {
                outputBox.AppendText($"Error in taskAssistant: {ex.Message}\n");
                outputBox.AppendText("Restarting task creation. What is the name of the task?\n");
                counter = 0;
                task = new Dictionary<string, string>();
                inTask = true;
                outputBox.ScrollToEnd();
            }
        }

        public int listindex;
        public void addToList()
        {
            var newTask = new Task
            {
                Name = task["Name"],
                Description = task["Description"],
                Reminder = task["Reminder"]
            };
            tasks.Insert(listindex, newTask);
            outputBox.AppendText("Task created successfully!\n");
            task = new Dictionary<string, string>();
            listindex++;
        }
        //Doisplay the activity log
        public void displayLog()
        {
            if (stackCounter <= 10)
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

        private int quizCounter;
        public bool quizMode = false;
        public int score;
        public void quiz(string input)
        {
            quizMode = true;
            switch (quizCounter)
            {
                case 0:
                    outputBox.AppendText("Question 1: Which one is not a Cyber security topic?:\n" +
                        "A. Phishing\n" +
                        "B. Password Safety\n" +
                        "C. Cyber bullying\n" +
                        "D. Privacy\n");
                    quizCounter++;
                    break;
                case 1:
                    //I used quizCounter-1 to keep to in track with the question and so that it doesnt give wrong answers
                    quizResponse(quizCounter - 1, input);
                    outputBox.AppendText("Question 2: What do you call someone who hacks with malicious intent?:\n" +
                        "A. Black Hat Hacker\n" +
                        "B. Grey Hat Hacker\n" +
                        "C. White Hat Hacker\n" +
                        "D. None of the above\n");
                    quizCounter++;
                    break;
                case 2:
                    quizResponse(quizCounter - 1, input);
                    outputBox.AppendText("Question 3: Phishing is a form of social engineering?:\n" +
                        "True\n" +
                        "False\n");
                    quizCounter++;
                    break;
                case 3:
                    quizResponse(quizCounter - 1, input);
                    outputBox.AppendText("Question 4: What is a sign that you are on a secured browser?:\n" +
                        "A. Privacy\n" +
                        "B. A link to another page\n" +
                        "C. Ads\n" +
                        "D. HTTPS\n");
                    quizCounter++;
                    break;
                case 4:
                    quizResponse(quizCounter - 1, input);
                    outputBox.AppendText("Question 5: Social Engineering can be someone faking an identity?:\n" +
                        "False\n" +
                        "True\n");
                    quizCounter++;
                    break;
                case 5:
                    quizResponse(quizCounter - 1, input);
                    outputBox.AppendText("Question 6: What should you do if you receive a link in a suspicious email?:\n" +
                        "A. Click it\n" +
                        "B. Ignore it\n" +
                        "C. Forward it\n" +
                        "D. None of the Above\n");
                    quizCounter++;
                    break;
                case 6:
                    quizResponse(quizCounter - 1, input);
                    outputBox.AppendText("Question 7: Is it safe to save your passwords on your phone?:\n" +
                        "True\n" +
                        "False\n");
                    quizCounter++;
                    break;
                case 7:
                    quizResponse(quizCounter - 1, input);
                    outputBox.AppendText("Question 8: Having your birthday as your password is safe?:\n" +
                        "True\n" +
                        "False\n");
                    quizCounter++;
                    break;
                case 8:
                    quizResponse(quizCounter - 1, input);
                    outputBox.AppendText("Question 9: Which one is a violation of privacy?:\n" +
                        "A. Stealing of passwords\n" +
                        "B. Sharing someone's personal information\n" +
                        "C. Accessing someone's online accounts\n" +
                        "D. All of the above\n");
                    quizCounter++;
                    break;
                case 9:
                    quizResponse(quizCounter - 1, input);
                    outputBox.AppendText("Question 10: Someone impersonating your boss to get your information\n" +
                        "is a form of social engineering?:\n" +
                        "True\n" +
                        "False\n");
                    quizCounter++;
                    break;
                case 10:
                    quizResponse(quizCounter - 1, input);
                    checkScore(score);
                    outputBox.AppendText("\nLet's continue with our chat. What can I help you with?\n");
                    quizMode = false;
                    break;
                default:
                    quizCounter = 0;
                    break;
            }
        }
        //This method is where the responses of the quiz will come from
        public void quizResponse(int counter, string input)
        {
            switch (counter)
            {
                case 0:
                    if (input.ToLower() == "c")
                    {
                        outputBox.AppendText("You got it RIGHT!!!\n");
                        score++;
                    }
                    else
                    {
                        outputBox.AppendText("The correct answer is C. Although the name Cyber Bullying seems like it is a Cyber\n" +
                            "security topic, it is not. Cyber Bullying has to do with the use of cyber spaces\n" +
                            "such as social media to bully someone else, not about your safety in cyber space.\n");
                    }
                    break;
                case 1:
                    if (input.ToLower() == "a")
                    {
                        outputBox.AppendText("You got it RIGHT!!!\n");
                        score++;
                    }
                    else
                    {
                        outputBox.AppendText("The correct answer is A. A black hat hacker is someone who hacks with malicious intent.\n" +
                            "A grey hat hacker is someone who hacks without permission but for their own purposes.\n" +
                            "A white hat hacker is someone hired to test the security of a system with permission.\n");
                    }
                    break;
                case 2:
                    if (input.ToLower() == "true")
                    {
                        outputBox.AppendText("You got it RIGHT!!!\n");
                        score++;
                    }
                    else
                    {
                        outputBox.AppendText("The correct answer is True. Phishing involves emails or messages that might look legit\n" +
                            "and seem to come from a real entity or person but are fake. This is a form of social engineering.\n");
                    }
                    break;
                case 3:
                    if (input.ToLower() == "d")
                    {
                        outputBox.AppendText("You got it RIGHT!!!\n");
                        score++;
                    }
                    else
                    {
                        outputBox.AppendText("The correct answer is D. HTTPS is an internet protocol and an extension\n" +
                            "of HTTP. The 'S' stands for secure, indicating that the domain is registered and protected.\n");
                    }
                    break;
                case 4:
                    if (input.ToLower() == "true")
                    {
                        outputBox.AppendText("You got it RIGHT!!!\n");
                        score++;
                    }
                    else
                    {
                        outputBox.AppendText("The correct answer is TRUE. Social engineering involves learning about an individual,\n" +
                            "usually someone with access to information, and using their identity to gain information.\n");
                    }
                    break;
                case 5:
                    if (input.ToLower() == "b")
                    {
                        outputBox.AppendText("You got it RIGHT!!!\n");
                        score++;
                    }
                    else
                    {
                        outputBox.AppendText("The correct answer is B. It’s best to ignore suspicious links and DO NOT forward them,\n" +
                            "as you could be liable for distributing a malicious link.\n");
                    }
                    break;
                case 6:
                    if (input.ToLower() == "false")
                    {
                        outputBox.AppendText("You got it RIGHT!!!\n");
                        score++;
                    }
                    else
                    {
                        outputBox.AppendText("The correct answer is FALSE. Storing passwords on your phone is dangerous\n" +
                            "because if someone steals or accesses it, they can get that information. Encrypt such documents\n" +
                            "to make it harder to access.\n");
                    }
                    break;
                case 7:
                    if (input.ToLower() == "false")
                    {
                        outputBox.AppendText("You got it RIGHT!!!\n");
                        score++;
                    }
                    else
                    {
                        outputBox.AppendText("The correct answer is FALSE. Using your birthday as a password is unsafe\n" +
                            "because it’s one of the first things hackers try. Use complex passwords with special characters and numbers.\n");
                    }
                    break;
                case 8:
                    if (input.ToLower() == "d")
                    {
                        outputBox.AppendText("You got it RIGHT!!!\n");
                        score++;
                    }
                    else
                    {
                        outputBox.AppendText("The correct answer is D. All of these are violations of privacy, especially without permission.\n" +
                            "Always ask for consent before handling someone else’s information.\n");
                    }
                    break;
                case 9:
                    if (input.ToLower() == "true")
                    {
                        outputBox.AppendText("You got it RIGHT!!!\n");
                        score++;
                    }
                    else
                    {
                        outputBox.AppendText("The correct answer is TRUE. Social engineering involves attackers impersonating someone\n" +
                            "to access information, such as pretending to be your boss.\n");
                    }
                    break;
                default:
                    break;
            }
        }
        //This method is to check the score of the user and give them an appropriate response
        public void checkScore(int num)
        {
            if (num <= 4)
            {
                outputBox.AppendText("Do not be discouraged, it just means you have to learn more, and luckily you have me.\n");
            }
            else if (num > 4 && num < 8)
            {
                outputBox.AppendText("You did quite well, you just need to polish up on some topics.\n");
            }
            else
            {
                outputBox.AppendText("Excellent!! You might as well teach me :)\n");
            }
        }
    }
}