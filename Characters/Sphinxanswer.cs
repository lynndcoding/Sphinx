using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    public class Sphinxanswer
    {
        //fields
        //No fields because the info does NOT need biz rules

        //properties
        public string Riddle { get; set; }
        public string Answer { get; set; }

        //ctor
        public Sphinxanswer()
        {
            string[] RiddleandAnswer = GetAnswer();
            Riddle = RiddleandAnswer[0];
            Answer = RiddleandAnswer[1];
        }//end method 


        //method
        private static string[] GetAnswer()
        {
            string[] riddle = new string[22];//declare array to hold questions from Sphinx monster
            {
                riddle[0] = "I am the beginning of everything, the end of everywhere.I’m the beginning of eternity, the end of time and space. What am I?";
                riddle[1] = "Forward I am heavy, but backward I am not. What am I?";
                riddle[2] = "I’m tall when I’m young, and I’m short when I’m old. What am I?";
                riddle[3] = "What month of the year has 28 days? ";
                riddle[4] = "What has many keys but can’t open a single lock? ";
                riddle[5] = "What has lots of eyes, but can’t see?";
                riddle[6] = "What has one eye, but can’t see?";
                riddle[7] = "What has hands, but can’t clap?";
                riddle[8] = "What has legs, but doesn’t walk?";
                riddle[9] = "What has one head, one foot and four legs?";
                riddle[10] = "What can you catch, but not throw? ";
                riddle[11] = "I am an odd number. Take away a letter and I become even. What number am I";
                riddle[12] = "If two’s company, and three’s a crowd, what are four and five?";
                riddle[13] = "What five-letter word becomes shorter when you add two letters to it?";
                riddle[14] = "Two in a corner, one in a room, zero in a house, but one in a shelter.";
                riddle[15] = "I am a word of letters three; add two and fewer there will be. What word am I?";
                riddle[16] = "What is the end of everything?";
                riddle[17] = "What is so fragile that saying its name breaks it?";
                riddle[18] = "What can run but never walks, has a mouth but never talks, has a head but never weeps, has a bed but never sleeps?";
                riddle[19] = "What can fill a room but takes up no space?";
                riddle[20] = "What is the answer to the Ultimate Question of Life, the Universe, and Everything?";
                riddle[21] = "What goes on four feet in the morning, two feet at noon, and three feet in the evening?";
            };

            string[] answerSphinx = new string[22];//declare array to hold answers to questions from Sphinx monster
            {
                answerSphinx[0] = "e";
                answerSphinx[1] = "ton";
                answerSphinx[2] = "candle";
                answerSphinx[3] = "all";
                answerSphinx[4] = "piano";
                answerSphinx[5] = "potato";
                answerSphinx[6] = "needle";
                answerSphinx[7] = "clock";
                answerSphinx[8] = "table";
                answerSphinx[9] = "bed";
                answerSphinx[10] = "cold";
                answerSphinx[11] = "seven";
                answerSphinx[12] = "9";
                answerSphinx[13] = "short";
                answerSphinx[14] = "r";
                answerSphinx[15] = "few";
                answerSphinx[16] = "g";
                answerSphinx[17] = "silence";
                answerSphinx[18] = "river";
                answerSphinx[19] = "light";
                answerSphinx[20] = "42";
                answerSphinx[21] = "person";
            };
            Random rand = new Random(); //create a random number generator
            int index = rand.Next(answerSphinx.Length); //set an index value equal to the length of the array to loop through randomly
            string[] answerAndSolution = { riddle[index], answerSphinx[index] };//create a string to hold both the riddle and the answer - linked by the index (both have same number of values in each array)
            return answerAndSolution; // return string that holds the answer and the solution
        }//end method answerSphinx

    }//end class
}//end namespace