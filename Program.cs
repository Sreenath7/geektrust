using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set1Problem
{
    enum Gender
    {
        None,
        Male,
        Female
    }

    enum Relations
    {
        Son,
        Daughter,
        Siblings,
        PaternalUncle,
        MaternalUncle,
        PaternalAunt,
        MaternalAunt,
        BrotherInLaw,
        SisterInLaw,
    }

    class FamilyMember
    {
        public FamilyMember()
        {

        }
        public FamilyMember(string name, Gender gender, string motherName, string fatherName, string spouseName = null, List<string> children = null)
        {
            Name = name;
            GenderInfo = gender;
            MotherName = motherName;
            FatherName = fatherName;
            SpouseName = spouseName;
            Children = children ?? new List<string>();
        }
        
        public string Name { get; set; }
        public Gender GenderInfo { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }
        public string SpouseName { get; set; }
        public List<string> Children { get; set; }

        public override string ToString()
        {
            var displayStr = "";
            displayStr += "Name: "+(!string.IsNullOrEmpty(Name) ? Name : "NULL")+"\n";
            displayStr += "Gender: " + GenderInfo.ToString() + "\n";
            displayStr += "Mother Name: " + (!string.IsNullOrEmpty(MotherName) ? MotherName : "NULL") + "\n";
            displayStr += "Father Name: " + (!string.IsNullOrEmpty(FatherName) ? FatherName : "NULL") + "\n";
            displayStr += "Spouse Name: " + (!string.IsNullOrEmpty(SpouseName) ? SpouseName : "NULL") + "\n";
            displayStr += "Children: " + (Children != null && Children.Count > 0 ? string.Join(",", Children) : "NULL") + "\n------------------------------------------------";
            return displayStr;
        }

    }
    class Program
    {
        public static List<FamilyMember> FamilyMembers;
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello world!!");
            GetFamily();
            char choice = ' ';
            //do
            //{
            //    var input = Console.ReadLine().Split();
            //    if (input[0] == "ADD_CHILD")
            //    {
            //        AddChild(input[1], input[2], input[3]);
            //    }else if(input[0]== "GET_RELATIONSHIP")
            //    {

            //    }
            //    Console.WriteLine("Do you wish to continue?(Y/N)");
            //    choice = char.Parse(Console.ReadLine());
            //} while (choice=='Y'||choice=='y');

            // while(true)
            // {
            //  var input = Console.ReadLine().Split();
            //     if (input[0] == "ADD_CHILD")
            //     {
            //         AddChild(input[1], input[2], input[3]);
            //     }
            //     else if (input[0] == "GET_RELATIONSHIP")
            //     {
            //         GetRelationship(input[1], input[2]);
            //     }   
            // }
            for (int i = 0; i < 3; i++)
            {
                var input = Console.ReadLine().Split();
                if (input[0] == "ADD_CHILD")
                {
                    AddChild(input[1], input[2], input[3]);
                }
                else if (input[0] == "GET_RELATIONSHIP")
                {
                    GetRelationship(input[1], input[2]);
                }
            }

            //Display();
        }

        public static void GetFamily()
        {
            FamilyMembers = new List<FamilyMember>();
            FamilyMembers.Add(new FamilyMember("King Shan", Gender.Male, null, null, "Queen Anga", new List<string>() { "Chit", "Ish", "Vich", "Aras", "Satya" }));
            FamilyMembers.Add(new FamilyMember("Queen Anga", Gender.Female, null, null, "King Shan", new List<string>() { "Chit", "Ish", "Vich", "Aras", "Satya" }));
                //----------------------------------------------------------------------------------------------------------------------------------------------------
                FamilyMembers.Add(new FamilyMember("Chit", Gender.Male, "Queen Anga", "King Shan", "Amba", new List<string>() { "Dritha", "Tritha", "Vritha" }));
                FamilyMembers.Add(new FamilyMember("Amba", Gender.Female, null, null, "Chit", new List<string>() { "Dritha", "Tritha", "Vritha" }));

                FamilyMembers.Add(new FamilyMember("Dritha", Gender.Female, "Amba", "Chit", "Jaya", new List<string>() { "Yodhan" }));
                FamilyMembers.Add(new FamilyMember("Jaya", Gender.Male, null,null, "Dritha", new List<string>() { "Yodhan" }));
                FamilyMembers.Add(new FamilyMember("Yodhan", Gender.Male, "Dritha", "Jaya"));

                FamilyMembers.Add(new FamilyMember("Tritha", Gender.Female, "Amba", "Chit"));

                FamilyMembers.Add(new FamilyMember("Vritha", Gender.Male, "Amba", "Chit"));
                //----------------------------------------------------------------------------------------------------------------------------------------------------

            FamilyMembers.Add(new FamilyMember("Ish", Gender.Male, "Queen Anga", "King Shan"));
            FamilyMembers.Add(new FamilyMember("Vich", Gender.Male, "Queen Anga", "King Shan", "Lika", new List<string>() { "Vila", "Chika" }));
            FamilyMembers.Add(new FamilyMember("Lika", Gender.Female, null, null, "Vich", new List<string>() { "Vila", "Chika" }));
                FamilyMembers.Add(new FamilyMember("Vila", Gender.Female, "Lika", "Vich"));
                FamilyMembers.Add(new FamilyMember("Chika", Gender.Female, "Lika", "Vich"));
            //----------------------------------------------------------------------------------------------------------------------------------------------------
            FamilyMembers.Add(new FamilyMember("Aras", Gender.Male, "Queen Anga", "King Shan", "Chitra", new List<string>() { "Jnki", "Ahit" }));
            FamilyMembers.Add(new FamilyMember("Chitra", Gender.Female, null, null, "Aras", new List<string>() { "Jnki", "Ahit" }));

                FamilyMembers.Add(new FamilyMember("Jnki", Gender.Female, "Chitra", "Aras", "Arit", new List<string>() { "Laki", "Lavnya" }));
                FamilyMembers.Add(new FamilyMember("Arit", Gender.Male, null, null, "Jnki", new List<string>() { "Laki", "Lavnya" }));

                    FamilyMembers.Add(new FamilyMember("Laki", Gender.Male, "Jnki", "Arit"));
                    FamilyMembers.Add(new FamilyMember("Lavnya", Gender.Female, "Jnki", "Arit"));

                FamilyMembers.Add(new FamilyMember("Ahit", Gender.Male, "Chitra", "Aras"));
            //----------------------------------------------------------------------------------------------------------------------------------------------------
            FamilyMembers.Add(new FamilyMember("Satya", Gender.Female, "Queen Anga", "King Shan", "Vyan", new List<string>() { "Asva", "Vyas", "Atya" }));
            FamilyMembers.Add(new FamilyMember("Vyan", Gender.Male, null,null, "Satya", new List<string>() { "Asva", "Vyas", "Atya" }));

                FamilyMembers.Add(new FamilyMember("Asva", Gender.Male, "Satya", "Vyan", "Satvy", new List<string>() { "Vasa" }));
                FamilyMembers.Add(new FamilyMember("Satvy", Gender.Female, null, null, "Asva", new List<string>() { "Vasa" }));
                    FamilyMembers.Add(new FamilyMember("Vasa", Gender.Female, "Satvy", "Asva"));

                FamilyMembers.Add(new FamilyMember("Vyas", Gender.Male, "Satya", "Vyan", "Krpi", new List<string>() { "Kriya","Krithi" }));
                FamilyMembers.Add(new FamilyMember("Krpi", Gender.Female, null, null, "Vyas", new List<string>() { "Kriya", "Krithi" }));
                    FamilyMembers.Add(new FamilyMember("Kriya", Gender.Male, "Krpi", "Vyas"));
                    FamilyMembers.Add(new FamilyMember("Krithi", Gender.Female, "Krpi", "Vyas"));

                FamilyMembers.Add(new FamilyMember("Atya", Gender.Female, "Satya", "Vyan"));
        }
        public static void AddChild(string motherName,string childName,string gender)
        {
            var isChildAdded = false;
            var mother = GetMemberInfo(motherName);
            if (mother != null)
            {
                if(mother.GenderInfo == Gender.Female)
                {
                    var genderInfo = gender == "Male" ? Gender.Male : Gender.Female;
                    mother.Children.Add(childName);
                    var father = GetMemberInfo(mother.SpouseName);
                    if (father != null)
                    {
                        father.Children.Add(childName);
                        FamilyMembers.Add(new FamilyMember(childName, genderInfo, motherName, mother.SpouseName));
                        isChildAdded = true;
                    }
                }

                if (isChildAdded)
                {
                    Console.WriteLine("CHILD_ADDITION_SUCCEEDED");
                }
                else
                {
                    Console.WriteLine("CHILD_ADDITION_FAILED");
                }
            }
            else
            {
                Console.WriteLine("PERSON_NOT_FOUND");
            }
        }

        public static FamilyMember GetMemberInfo(string name)
        {
            var member = FamilyMembers.FirstOrDefault(m => m.Name == name);
            return member;
        }

        public static void GetRelationship(string memberName,string relation)
        {
            var relatives = new List<string>();
            var relKey = relation.Replace("-", string.Empty);
            Relations relationship;
            if(Enum.TryParse(relKey,out relationship))
            {
                switch (relationship)
                {
                    case Relations.Son:
                        relatives = GetChildren(memberName, Gender.Male);
                        break;
                    case Relations.Daughter:
                        relatives = GetChildren(memberName, Gender.Female);
                        break;
                    case Relations.Siblings:
                        relatives = GetSiblings(memberName);
                        break;
                    case Relations.PaternalUncle:
                        relatives = GetAuntOrUncle(memberName, Gender.Male, Gender.Male);
                        break;
                    case Relations.MaternalUncle:
                        relatives = GetAuntOrUncle(memberName, Gender.Female, Gender.Male);
                        break;
                    case Relations.PaternalAunt:
                        relatives = GetAuntOrUncle(memberName, Gender.Male,Gender.Female);
                        break;
                    case Relations.MaternalAunt:
                        relatives = GetAuntOrUncle(memberName, Gender.Female, Gender.Female);
                        break;
                    case Relations.BrotherInLaw:
                        relatives = GetInLaws(memberName, Gender.Male);
                        break;
                    case Relations.SisterInLaw:
                        relatives = GetInLaws(memberName, Gender.Female);
                        break;
                    default:
                        break;
                }
            }

            if(relatives==null)
            {
                Console.WriteLine("PERSON_NOT_FOUND");
            }
            else
            {
                if (relatives.Count == 0)
                {
                    Console.WriteLine("NONE");
                }
                else
                {
                    Console.WriteLine("Result: " + string.Join(" ", relatives));
                }
            }
            
            
        }

        public static List<string> GetChildren(string memberName,Gender gender)
        {
            var member = GetMemberInfo(memberName);
            if (member != null)
            {
                var children = member.Children;
                if (children != null && children.Count > 0)
                {
                    var childList = FamilyMembers.Where(fm => children.Contains(fm.Name) && fm.GenderInfo == gender).Select(mem => mem.Name).ToList();
                    return childList;
                }
                return new List<string>();
            }
            return null;
        }

        public static List<string> GetSiblings(string memberName,Gender gender = Gender.None)
        {
            var member = GetMemberInfo(memberName);
            if (member != null)
            {
                var mother = GetMemberInfo(member.MotherName);
                if (mother != null)
                {
                    if (gender == Gender.None)
                    {
                        return mother.Children.Where(c => c != memberName).ToList();
                    }
                    else
                    {
                        var siblings = new List<string>();
                        var children = mother.Children;
                        foreach (var child in children)
                        {
                            if (child != memberName)
                            {
                                var childInfo = GetMemberInfo(child);
                                if (childInfo?.GenderInfo == gender)
                                {
                                    siblings.Add(child);
                                }
                            }
                        }
                        return siblings;
                    }
                }
            }
            return null;
        }

        public static List<string> GetAuntOrUncle(string memberName,Gender memberGender, Gender siblingGender)
        {
            var member = GetMemberInfo(memberName);
            if (member != null)
            {
                var parentSiblings = GetSiblings(memberGender == Gender.Male ? member.FatherName : member.MotherName, siblingGender);
                //var auntUncles = new List<string>();
                //foreach (var sibling in parentSiblings)
                //{
                //    var siblingInfo = GetMemberInfo(sibling);
                //    if (siblingInfo?.GenderInfo == siblingGender)
                //    {
                //        auntUncles.Add(sibling);
                //    }
                //}
                //return auntUncles;
                return parentSiblings;
            }
            return null;
        }

        public static List<string> GetInLaws(string memberName, Gender inLawsGender)
        {
            var member = GetMemberInfo(memberName);
            if (member != null)
            {
                var inLaws = new List<string>();
                var spouseName = member.SpouseName;
                if (!string.IsNullOrEmpty(spouseName))
                {
                    //spouse siblings
                    var spouseSiblings = GetSiblings(spouseName, inLawsGender);
                    inLaws.AddRange(spouseSiblings);
                }

                //sibling's spouses
                var siblings = GetSiblings(memberName);
                var siblingGender = inLawsGender == Gender.Male ? Gender.Female : Gender.Male;
                if(siblings!=null && siblings.Count > 0) 
                {
                    foreach (var sibling in siblings)
                    {
                        var siblingInfo = GetMemberInfo(sibling);

                        if (siblingInfo != null && siblingInfo.GenderInfo == siblingGender)
                        {
                            inLaws.Add(siblingInfo.SpouseName);
                        }
                    }
                }
                return inLaws;
            }
            return null;
        }

        public static void Display()
        {
            foreach (var member in FamilyMembers)
            {
                Console.WriteLine(member.ToString());
            }
        }
    }
}