using csharp_biblioteca;
using System.Reflection;

// New library
Library bestLibraryEver = new Library();

// Welcome
Console.WriteLine($"Welcome to the best library of the world, we have {bestLibraryEver.documents.Count} documents available for rent.");
Console.WriteLine("Before using our system you must register a valid user");

// User registration
Console.Write("What's your role(admin or user: ");
string roleInput = Console.ReadLine();
Role? role = roleInput.ToLower() == "admin" ? Role.admin : Role.user;

Console.Write("Inser your first name: ");
string? firstName = Console.ReadLine();

Console.Write("Inser your last name: ");
string? lastName = Console.ReadLine();

Console.Write("Inser your email: ");
string? email = Console.ReadLine();

Console.Write("Inser your password: ");
string? password = Console.ReadLine();

Console.Write("Inser your phone number: ");
string? phoneNumber = Console.ReadLine();

User newUser = new User(firstName ?? "First name",
                        lastName ?? "Last name",
                        email ?? "test@me.com",
                        password ?? "12345678",
                        phoneNumber ?? "+39333121212",
                        role ?? Role.user
                        );

bestLibraryEver.users.Add(newUser);

Console.WriteLine("Thank you for your registration!");
Console.WriteLine(newUser.getUserData());


if (newUser.UserRole == Role.user)
{
    Document[] matches = Utils.PerformSearch(bestLibraryEver);
    Utils.PerformRent(bestLibraryEver, matches, newUser);
}
else
{
    Console.WriteLine("Choose an action:");
    Console.WriteLine("1 See all rents");
    Console.WriteLine("2 See all users");
    Console.WriteLine("3 See all documents");
    Console.WriteLine("4 Search for a document");

    string userSelection = Console.ReadLine();

    switch (userSelection)
    {
        case "1":
            bestLibraryEver.getAllRents();
            break;
        case "2":
            bestLibraryEver.getAllUsers();
            break;
        case "3":
            bestLibraryEver.getAllDocuments();
            break;
        case "4":
            Document[] matches = Utils.PerformSearch(bestLibraryEver);
            Utils.PerformRent(bestLibraryEver, matches, newUser);
            break;
        default:
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1 See all rents");
            Console.WriteLine("2 See all users");
            Console.WriteLine("3 See all documents");
            Console.WriteLine("4 Search for a document");
            break;
    }
}




