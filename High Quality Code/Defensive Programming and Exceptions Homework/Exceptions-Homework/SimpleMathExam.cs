using System;
namespace Exception_Homework
{
    public class SimpleMathExam : Exam
    {
        private int problemsSolved;
        public int ProblemsSolved
        {
            get
            {

                return this.problemsSolved;
            }
            private set
            {
                if (value < 0)
                {
                    this.problemsSolved = 0;
                }
                if (value > 10)
                {
                    this.problemsSolved = 10;
                }
            }
        }

        public SimpleMathExam(int problemsSolved)
        {
            this.ProblemsSolved = problemsSolved;
        }

        public override ExamResult GetExamResultsByScore()
        {
            if (ProblemsSolved == 0)
            {
                return new ExamResult(2, 2, 6, "Bad result: nothing done.");
            }
            else if (ProblemsSolved == 1)
            {
                return new ExamResult(4, 2, 6, "Average result: nothing done.");
            }
            else if (ProblemsSolved == 2)
            {
                return new ExamResult(6, 2, 6, "Average result: nothing done.");
            }

            return new ExamResult(0, 0, 0, "Invalid number of problems solved!");
        }
    }
}