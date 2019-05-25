using System.Collections.Generic;

public enum Gender
{
    Male,
    Female
}

public class FamilyMember
{
    public string Name { get; set; }
    public Gender Gender { get; set; }
    public List<string> Children { get; set; }
    
    
}