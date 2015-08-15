using System;
namespace Exception_Homework
{
    public class CSharpExam : Exam
    {
        private int score;

        public CSharpExam(int score)
        {
            this.Score = score;
        }

        public int Score
        {
            get
            {
                return score;
            }
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("The score must be between 0 and 100");
                }
                this.score = value;
            }
        }

        public override ExamResult GetExamResultsByScore()
        {
            return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        }
    }
}