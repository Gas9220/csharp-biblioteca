using csharp_biblioteca;

// New library
Library bestLibraryEver = new Library();

// Create some books
Book lordOfTheRingBook = new Book(Random.Shared.Next(0, 1000),
                      "Lord of the rings",
                       "1968",
                       Subject.fantasy,
                       Random.Shared.Next(1, 100).ToString(),
                       new Author("John Ronald Reuel", "Tolkien"),
                       529
                       );
Book iamThor = new Book(Random.Shared.Next(0, 1000),
                      "I'am Thor",
                       "2022",
                       Subject.Comics,
                       Random.Shared.Next(1, 100).ToString(),
                       new Author("Stan", "Lee"),
                       529
                       );
Book wordWarII = new Book(Random.Shared.Next(0, 1000),
                      "World War II: The Definitive Visual History: From Blitzkrieg to the Atom Bomb",
                       "2011",
                       Subject.history,
                       Random.Shared.Next(1, 100).ToString(),
                       new Author("Ferdie", "McDonald"),
                       529
                       );
// Create some DVD
Dvd avatar = new Dvd(Random.Shared.Next(0, 1000),
                      "Avatar: The Way of Water",
                       "2022",
                       Subject.fantasy,
                       Random.Shared.Next(1, 100).ToString(),
                       new Author("James", "Cameron"),
                       192
                       );
Dvd batman = new Dvd(Random.Shared.Next(0, 1000),
                      "Batman: The Dark Knight",
                       "2012",
                       Subject.Comics,
                       Random.Shared.Next(1, 100).ToString(),
                       new Author("Christopher", "Nolan"),
                       164
                       );
Dvd planetLife = new Dvd(Random.Shared.Next(0, 1000),
                      "David Attenborough: A Life on Our Planet",
                       "2020",
                       Subject.Comics,
                       Random.Shared.Next(1, 100).ToString(),
                       new Author("David ", "Attenborough"),
                       200
                       );

// Add to library documents list
bestLibraryEver.documents.Add(lordOfTheRingBook);
bestLibraryEver.documents.Add(iamThor);
bestLibraryEver.documents.Add(wordWarII);
bestLibraryEver.documents.Add(avatar);
bestLibraryEver.documents.Add(batman);
bestLibraryEver.documents.Add(planetLife);

// Welcome
Console.WriteLine($"Welcome to the best library of the world, we have {bestLibraryEver.documents.Count} documents available for rent.");
Console.WriteLine("Before using our system you must register a valid user");

// User registration
Console.Write("Inser your first name: ");
string? firstName = Console.ReadLine();

Console.Write("Inser your last name: ");
string? lastName = Console.ReadLine();

Console.Write("Inser your email: ");
string? email = Console.ReadLine();

Console.Write("Inser your password: ");
string? password= Console.ReadLine();

Console.Write("Inser your phone number: ");
string? phoneNumber = Console.ReadLine();

User newUser = new User(firstName ?? "First name",
                        lastName ?? "Last name",
                        email ?? "test@me.com",
                        password ?? "12345678",
                        phoneNumber ?? "+39333121212");

bestLibraryEver.users.Add(newUser);

Console.WriteLine("Thank you for your registration!");
Console.WriteLine(newUser.getUserData());




