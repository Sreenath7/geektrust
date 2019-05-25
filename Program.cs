using System;
using System.Collections.Generic;
using System.Linq;

namespace geektrust
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var familyMembers =  new List<FamilyMember>();
        }

        public void AddChild(List<FamilyMember> familyMembers, string mother,string child,Gender gender)
        {
            

        }

        public FamilyMember GetMember(List<FamilyMember> familyMembers,string memberName)
        {
            var memberInfo = familyMembers.FirstOrDefault(f=>f.Name==memberName);

            return memberInfo;
        }
    }
}
