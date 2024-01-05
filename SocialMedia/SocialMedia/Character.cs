using System.ComponentModel.Design;

namespace SocialMedia;

public class Character
{
    public List<Character> friendList = new List<Character>();
    public int UserId { get; private set; }
    public string Name { get; private set;}
    public int Age { get; private set;}
    public string Work { get; private set;}
    public string Status { get; private set;}
    
    public Character(int userID, string name, int age, string work, string status)
    {
        UserId = userID;
        Name = name;
        Age = age;
        Work = work;
        Status = status;
    }

    public void UserIds()
    {
        Console.WriteLine($"ID: {UserId}. " +
                          $"Navn: {Name}. " );
    }
    public void UserDetails()
    {
        Console.WriteLine($"ID: {UserId}. " +
                          $"Navn: {Name}. " +
                          $"Alder: {Age}. " +
                          $"jobb: {Work}. " +
                          $"Sivil Status:{Status}.");
    }
    
    public void MyFriends()
    {
        foreach (var user in friendList)
        {
            user.UserDetails();
        }
        Console.WriteLine("trykk 1 for å slett en venn.\n" +
                          "trykk 2 for å gå tilbake til start.");
        char option = Console.ReadKey().KeyChar;
        switch (option)
        {
            case '1':
                Console.WriteLine("skriv ID på vennen du vil slette");
                
                RemoveFriend(TargetFriend());
                break;
            case '2':
                return;
            default:
                Console.WriteLine("ugyldig svar! prøv igjen");
                MyFriends();
                break;
        }
    }

    public void AddFriend( Character personAdd)
    {
        if (!friendList.Contains(personAdd))
        {
            friendList.Add(personAdd);
            Console.WriteLine($"du er nå venn med {personAdd.Name}");
            
        }
        else 
        {
            Console.WriteLine($"venneforespørsel mislykket! prøv igjen");
        }
    }
    
    private Character TargetFriend()
    {
        
        int userID = Convert.ToInt32(Console.ReadLine());
        var selectedUser = friendList.FirstOrDefault(u => u.UserId == userID);
        if (selectedUser == null)
        {
            Console.WriteLine("ugyldig bruker ID!prøv igjen");
            return TargetFriend();
        }

        return selectedUser;
        
    }
    
    private void RemoveFriend( Character personAdd)
    {
        if (friendList.Contains(personAdd))
        {
            friendList.Remove(personAdd);
            Console.WriteLine($"du er nå venn med {personAdd.Name}");
            
        }
        else 
        {
            Console.WriteLine($"venneforespørsel mislykket! prøv igjen");
        }
    }
    
}