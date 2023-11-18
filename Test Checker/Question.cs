using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Checker
{
    public class Question
    {
        public string Text { get; set; }
        public string[] Choices { get; set; }
        public int CorrectAnswerIndex { get; set; }

        public bool IsAnswerCorrect(int selectedAnswerIndex)
        {
            return selectedAnswerIndex == CorrectAnswerIndex;
        }
    }

}
