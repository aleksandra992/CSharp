namespace School
{
    using System;
    public class Discipline:IComments
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercise;
        private string comment;
        public Discipline(string name, int numberOfLectures, int numberOfExercise)
        {
            this.Name = name;
            this.NumberOfExercise = numberOfExercise;
            this.NumberOfLectures = numberOfLectures;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("The name of the discipline cannot be null or empty");
                this.name = value;
            }
        }
        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The number of lectures cannot be negative");
                }
                this.numberOfLectures = value;
            }
        }
        public int NumberOfExercise
        {
            get
            {
                return this.NumberOfExercise;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The number of lectures cannot be negative");
                }
                this.numberOfExercise = value;
            }
        }
        public override string ToString()
        {
            return String.Format(this.Name);
        }

        public string Comment
        {
            get
            {
                if (string.IsNullOrEmpty(this.comment))
                {
                    return "No comment";
                }
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }
    }
}
