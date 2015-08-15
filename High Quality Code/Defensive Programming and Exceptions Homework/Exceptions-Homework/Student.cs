using System;
using System.Linq;
using System.Collections.Generic;
namespace Exception_Homework
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private IList<Exam> exams;

        public Student(string firstName, string lastName, IList<Exam> exams = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            if (exams == null)
            {
                this.exams = new List<Exam>();
            }
            else
            {
                this.exams = exams;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The firstname cannot be null");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The lastname cannot be null");
                }
                this.lastName = value;
            }
        }

        public IList<ExamResult> GetExamsResult()
        {
            IList<ExamResult> results = new List<ExamResult>();
            for (int i = 0; i < this.exams.Count; i++)
            {
                results.Add(this.exams[i].GetExamResultsByScore());
            }

            return results;
        }


        public double CalcAverageExamResultInPercents()
        {
            if (this.exams.Count == 0)
            {
                // No exams --> return 0;
                return 0;
            }

            double[] examScore = new double[this.exams.Count];
            IList<ExamResult> examResults = GetExamsResult();
            for (int i = 0; i < examResults.Count; i++)
            {
                examScore[i] =
                    ((double)examResults[i].Grade - examResults[i].MinGrade) /
                    (examResults[i].MaxGrade - examResults[i].MinGrade);
            }

            return examScore.Average();
        }
    }
}