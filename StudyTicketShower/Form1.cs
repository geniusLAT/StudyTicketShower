using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace StudyTicketShower
{
    public partial class Form1 : Form
    {
        pair Curpair= new pair("That is allright","How do you do?");

        List<pair> Original = new List<pair>();

        List<pair> CurList= new List<pair>();
        List<pair> positive = new List<pair>();
        List<pair> negative = new List<pair>();
        int counter = 0;
        int Rounds=0;

        void LoadDefaultFile()
        {
            LoadFromFile("topics/cur.txt");
        }
        void LoadFromFile(string path)
        {
            //answerLabel.Text 
            string FileText = File.ReadAllText(path);
            Original = new List<pair>();
            string[] answers = FileText.Split('$');
            foreach(string answer in answers)
            {
                string[] parts = answer.Split('#');
                if (parts.Length==2) Original.Add(new pair(parts[1], parts[0]));
            }
            LoadMatch();
        }



        void ShowStatistics()
        {
            StatisticsLabel.Text="question "+counter.ToString()+"/"+CurList.Count.ToString()+" positive:"+positive.Count.ToString()
                +"  negative:"+negative.Count.ToString()+"   Round:"+Rounds;
        }

        void LoadMatch()
        {
            Rounds = 0;
            counter = 0;
            CurList = Original;
            LoadRound();
        }
        void LoadRound()
        {
            if (negative.Count > 0)
            {
                CurList = negative;
                negative = new List<pair>();
                positive = new List<pair>();

            }
            else
            {
                if(Rounds > 0)
                {
                    //win
                    StatisticsLabel.Text = "Victory";
                }
            }
            counter = 0;
            Rounds++;
            LoadPair();
           
        }
        void LoadPair()
        {
            if (counter == CurList.Count) LoadRound();
            else
            {
                LoadPairToGUI(CurList[counter]);
                counter++;
                ShowStatistics();
            }
            
        }

        public class pair
        {
            public string Answer;
            public string question;
            public pair(string Answer, string question)
            {
                this.Answer = Answer;
                this.question = question;   
            }
        }
        public Form1()
        {
            InitializeComponent();
            Original = new List<pair> { new pair("a", "b"), new pair("c", "d") };
            //LoadMatch();
            LoadDefaultFile();
        }

        void LoadPairToGUI(pair p)
        {
            Curpair = p;
            questionLabel.Text = p.question;
            answerLabel.Text = "";
            showAnswerButton.Enabled = true;
            PositiveButton.Enabled = NegativeButton.Enabled = false;

        }


        private void showAnswerButton_Click(object sender, EventArgs e)
        {
            //answerLabel.Text = Curpair.Answer;
            answerLabel.Text = Curpair.Answer.Replace("\t","       ");
            showAnswerButton.Enabled = false;
            PositiveButton.Enabled = NegativeButton.Enabled = true;
        }

        private void PositiveButton_Click(object sender, EventArgs e)
        {
            positive.Add(Curpair);
            LoadPair();
        }

        private void NegativeButton_Click(object sender, EventArgs e)
        {
            negative.Add(Curpair);
            LoadPair();
        }

        private void answerLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
