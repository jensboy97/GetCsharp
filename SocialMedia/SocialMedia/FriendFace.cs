using System.ComponentModel.Design;
using System.Diagnostics;

namespace SocialMedia;

public class FriendFace
{
    private List<Character> userList = new List<Character>();
    private Character _user;
    public void MediaUsers()
    {
        userList.Add(new Character(0002, "Sam", 27, "bartender", "single"));
        userList.Add(new Character(0003, "Terje", 21, "fisker", "engaged"));
        userList.Add(new Character(0004, "Terje", 38, "snekker", "married"));
        userList.Add(new Character(0005, "Terje", 96, "code guru","finally single"));
        userList.Add(new Character(0006, "Jonas", 54, "diktator", "unhappily married"));
        userList.Add(new Character(0007, "Erna", 62, "youtuber", "enke"));
        userList.Add(new Character(0008, "Emma", 24, "maskinfører", "single"));
        userList.Add(new Character(0009, "Amalie", 23, "sykepleier", "single"));
        userList.Add(new Character(0010, "Bob", 28, "advokat", "single"));
        userList.Add(new Character(0011, "Geir olav", 66, "uføre", "harem"));
        userList.Add(new Character(0012, "Bernt", 25, "lege", "single"));
        userList.Add(new Character(0013, "Maria", 25, "lærer", "singel"));
        userList.Add(new Character(0014, "Sara", 22, "ingeniør", "engasjert"));
        userList.Add(new Character(0015, "Ingrid", 29, "snekker", "gift"));
        userList.Add(new Character(0016, "Maja", 24, "dataviter", "singel"));
        userList.Add(new Character(0017, "Nina", 28, "artist", "gift"));
        userList.Add(new Character(0018, "Lisa", 26, "designer", "singel"));
        userList.Add(new Character(0019, "Julie", 23, "sykepleier", "singel"));
        userList.Add(new Character(0020, "Hanna", 30, "advokat", "gift"));
        userList.Add(new Character(0021, "Malin", 27, "entreprenør", "singel"));
        userList.Add(new Character(0022, "Camilla", 31, "musiker", "singel"));
        Register();
    }
    private void Register()
    {
        Console.WriteLine("Hei velkommen til FriendFace!");
        int userID = 0001;
        Console.WriteLine("Hva heter du?");
        string userName = Console.ReadLine();
        Console.WriteLine("Hvor gammel er du?");
        int userAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hva jobber du med?");
        string userWork = Console.ReadLine();
        Console.WriteLine("sivil status?");
        string userStatus = Console.ReadLine();
        _user = new Character(userID, userName, userAge, userWork, userStatus);
        
    }
    public void Menu()
    {
        Console.WriteLine($"innlogget som:{_user.Name}\n" +
                          $"FriendFace\n" +
                          $"tast 1 for å se din profil\n" +
                          $"tast 2 for å se dine venner\n" +
                          $"tast 3 for å se andre FriendFacere \n");
                        
        char choice = Console.ReadKey().KeyChar;
        switch (choice)
        { 
            case '1' :
                MyProfile();
                break;
            case '2':
                _user.MyFriends();
                break;
             case '3':
                AllUsers();
                 break;
            default:
                Console.WriteLine("ugyldig nr, prøv igjen!");
                return;
        }
    }

        private void MyProfile()
        {
         _user.UserDetails();
         Console.ReadKey();
        }
        
        private void AllUsers()
        {
            Console.WriteLine("List of FriendFace users");
            foreach (var user in userList)
            {
                user.UserIds();
            }
            Console.WriteLine("skriv inn brukerens ID for å se profilen deres");
            var selectedUser = TargetUser();
                     selectedUser.UserDetails();
                     
            UserAction(selectedUser);
        }

        private void UserAction(Character selectedUser)
        {
            Console.WriteLine("tast 1 for å legge til personen\n" +
                              "tast 2 for å gå tilbake til start");
            char option = Console.ReadKey().KeyChar;
            switch (option)
            { 
                case '1':
                    _user.AddFriend(selectedUser);
                    break;
                case '2':
                    Menu();
                    break;
                default:
                    Console.WriteLine("ugyldig valg! prøv igjen");
                    UserAction(selectedUser);
                    break;
            }
        }

        private Character TargetUser()
        {
            int userID = Convert.ToInt32(Console.ReadLine());
            var selectedUser = userList.FirstOrDefault(u => u.UserId == userID);
            if (selectedUser == null)
            {
                Console.WriteLine("ugyldig bruker ID!prøv igjen");
                return TargetUser();
            }

            return selectedUser;
        }
        
        
}
