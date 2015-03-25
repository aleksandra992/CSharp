
namespace _9.StudentGroups
{
    using System;
   

    public class Group
    {
        
        public int GroupNumber { get; set; }
        public string  DepartmentName { get; set; }
        public Group(int gn,string dn)
        {
            this.GroupNumber = gn;
            this.DepartmentName = dn;
        }
    }
}
