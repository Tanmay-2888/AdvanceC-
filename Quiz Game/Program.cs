using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace Quiz_Game_in_Form
{
    public partial class Form1 : Form
    {
 
        // quiz game variables
 
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
 
        public Form1()
        {
            InitializeComponent();
 
            askQuestion(questionNumber);
 
            totalQuestions = 10;
        }
 
        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
 
            int buttonTag = Convert.ToInt32(senderObject.Tag);
 
            if(buttonTag == correctAnswer)
            {
                score++;
            }
 
            if(questionNumber == totalQuestions)
            {
                // work out the percentage
 
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);
 
                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine + 
                    "You have answered " + score + " questions correctly." + Environment.NewLine + 
                    "Your total percentage is " + percentage + "%" + Environment.NewLine + 
                    "Click OK to play again"                 
                    );
 
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
 
            }
 
            questionNumber++;
            askQuestion(questionNumber);
 
        }
 
        private void askQuestion(int qnum)
        {
 
            switch(qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.questions;
 
                    lblQuestion.Text = "Number of primitive data types in Java are?";
 
                    button1.Text = "six";
                    button2.Text = "seven";
                    button3.Text = "Eight";
                    button4.Text = "Nine";
 
                    correctAnswer = 3;
 
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.questions;
 
                    lblQuestion.Text = "Automatic type conversion is possible in which of the possible cases?";
 
                    button1.Text = "byte to int";
                    button2.Text = "int to long";
                    button3.Text = "Long to int";
                    button4.Text = "Short to int";
 
                    correctAnswer = 2;
 
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.csgo;
 
                    lblQuestion.Text = "Arrays in java are-";
 
                    button1.Text = "Object reference";
                    button2.Text = "Object";
                    button3.Text = "Primitive data types";
                    button4.Text = "None";
 
                    correctAnswer = 2;
 
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.fortnite;
 
                    lblQuestion.Text = "When is the object created with new keyword?";
 
                    button1.Text = "At run time";
                    button2.Text = "At compile time";
                    button3.Text = "Depend on the code";
                    button4.Text = "None";
 
                    correctAnswer = 1;
 
                    break;
 
                case 5:
                    pictureBox1.Image = Properties.Resources.gears_of_war;
 
                    lblQuestion.Text = "compareTo() returns";
 
                    button1.Text = "True ";
                    button2.Text = "False";
                    button3.Text = "An int value";
                    button4.Text = "None";
 
                    correctAnswer = 3;
 
                    break;
 
                case 6:
                    pictureBox1.Image = Properties.Resources.halo;
 
                    lblQuestion.Text = "To which of the following does the class string belong to.";
 
                    button1.Text = "Java.Lang";
                    button2.Text = "Java.Awt";
                    button3.Text = "Java.Applet";
                    button4.Text = "Java.string";
 
                    correctAnswer = 1;
 
                    break;
 
                case 7:
                    pictureBox1.Image = Properties.Resources.witcher3;
 
                    lblQuestion.Text = "Identify the return type of a method that does not return any value.";
 
                    button1.Text = "int";
                    button2.Text = "void";
                    button3.Text = "Double";
                    button4.Text = "None";
 
                    correctAnswer = 2;
 
                    break;
 
                case 8:
                    pictureBox1.Image = Properties.Resources.questions;
 
                    lblQuestion.Text = "Where does the system stores parameters and local variables whenever a method is invoked?";
 
                    button1.Text = "Heap";
                    button2.Text = "Stack";
                    button3.Text = "Array";
                    button4.Text = "Tree";
 
                    correctAnswer = 2;
 
                    break;


                case 9:
                    pictureBox1.Image = Properties.Resources.questions;
 
                    lblQuestion.Text = "Identify the modifier which cannot be used for constructor.";
 
                    button1.Text = "public";
                    button2.Text = "private";
                    button3.Text = "protected";
                    button4.Text = "static";
 
                    correctAnswer = 4;
 
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.questions;
 
                    lblQuestion.Text = "What is Runnable?";
 
                    button1.Text = "Abstract class";
                    button2.Text = "interface";
                    button3.Text = "class";
                    button4.Text = "method";
 
                    correctAnswer = 2;
 
                    break;

                
 
 
 
 
            }
 
 
 
        }
 
    }
}
