using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public abstract class Member
    {
        public int MemberId { get; set; }
        public string Name { get; set; }

        public Member(int memberId, string name)
        {
            this.MemberId = memberId;
            this.Name = name;
        }
        public abstract int MaxBooksAllowed();
    }
    public class StudentMember : Member
    {
        public StudentMember(int id, string name) : base(id, name) { }
        public override int MaxBooksAllowed() => 2;
    }

    public class TeacherMember : Member
    {
        public TeacherMember(int id, string name) : base(id, name) { }
        public override int MaxBooksAllowed() => 3;
    }
}
