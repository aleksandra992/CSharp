namespace Students
{
    using System;
    using System.Text;

 public class Student : ICloneable, IComparable<Student>
    {

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string Address { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public Speciality StudentSpeciality { get; set; }
        public University StudentUnivesity { get; set; }
        public Faculty StudentFaculty { get; set; }
        #region constructors
        public Student(string firstName, string middleName, string lastName, string course, Speciality speciality,
          University university, Faculty faculty, string ssn, string address, string mobilePhone, string email)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.StudentSpeciality = speciality;
            this.StudentUnivesity = university;
            this.StudentFaculty = faculty;
        }
        public Student(string firstName, string middleName, string lastName, string course, Speciality speciality,
            University university, Faculty faculty, string ssn)
            : this(firstName, middleName, lastName, course, speciality, university, faculty, ssn, null, null, null)
        {

        }
        public Student(Student s)
            : this(s.FirstName, s.MiddleName, s.LastName, s.Course, s.StudentSpeciality, s.StudentUnivesity, s.StudentFaculty, s.SSN, s.Address, s.MobilePhone, s.Email)
        {

        }
        #endregion

        #region methods
        public override bool Equals(object obj)
        {
            
            Student student = obj as Student;
            if (student == null || this==null)
            {
                return false;
            }
            bool firstName = this.FirstName.Equals(student.FirstName);
            bool lastName = this.LastName.Equals(student.LastName);
            bool middleName = this.MiddleName.Equals(student.MiddleName);
            bool SSN = this.SSN.Equals(student.SSN);
            bool address = Object.Equals(this.Address, student.Address);
            bool mobilePhone = Object.Equals(this.MobilePhone, student.MobilePhone);
            bool email = Object.Equals(this.Email, student.Email);
            bool course = this.Course.Equals(student.Course);
            bool studentSpeciality = this.StudentSpeciality.Equals(student.StudentSpeciality);
            bool studentUniversity = this.StudentUnivesity.Equals(student.StudentUnivesity);
            bool studentFaculty = this.StudentFaculty.Equals(student.StudentFaculty);

            if (firstName && lastName && middleName && SSN && address && mobilePhone && email && course && studentFaculty && studentUniversity && studentSpeciality)
            {
                return true;
            }
            else return false;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("First Name   Middle Name  Last Name");
            result.AppendLine(string.Format("{0,-12} {1,-12} {2,-12}", this.FirstName, this.MiddleName, this.LastName));
            result.AppendLine(String.Format("SSN: {0}", this.SSN));
            result.AppendLine(String.Format("Address: {0}", this.Address));
            result.AppendLine(String.Format("Phone: {0}", this.MobilePhone));
            result.AppendLine(String.Format("Email: {0}", this.Email));
            result.AppendLine(String.Format("University:{0}, Faculty: {1}, Speciality: {2}, Course {3}",
                this.StudentUnivesity, this.StudentFaculty, this.StudentSpeciality, this.Course));
            return result.ToString();
        }
        public override int GetHashCode()
        {


            return this.FirstName.GetHashCode() ^ this.Email.GetHashCode();

        }
        public object Clone()
        {
            Student cloneStudent = new Student(this);
            return cloneStudent;
        }
        public int CompareTo(Student other)
        {
            if (this.FirstName.CompareTo(other.FirstName) == 0)
            {
                  return this.SSN.CompareTo(other.SSN);
            }
            else
            {
                return this.FirstName.CompareTo(other.FirstName);
            }
        }
        #endregion

        #region operators
        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals( student1,student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !Student.Equals(student1, student2);
        }


        #endregion





    }

}
