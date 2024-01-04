public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
    public int Id { get; set; }

    public User(string name, int age, string city, int id)
    {
        Name = name;
        Age = age;
        City = city;
        Id = id;
    }
}

public class UsersDatabase
{
    public static List<User> InitializeUsers()
    {
        return new List<User>
        {
            new User("Peter Parker", 25, "New York", 1),
            new User("Clark Kent", 35, "Metropolis", 2),
            new User("Bruce Wayne", 40, "Gotham", 3),
            new User("Diana Prince", 500, "Themyscira", 4),
            new User("Bruce Banner", 42, "New York", 5),
            new User("Steve Rogers", 100, "New York", 6),
            new User("Tony Stark", 40, "New York", 7),
            new User("Thor Odinson", 1500, "Asgard", 8),
            new User("Natasha Romanoff", 35, "New York", 9),
            new User("Clint Barton", 43, "New York", 10),
            new User("Scott Lang", 41, "San Francisco", 11),
            new User("T'challa", 39, "Wakanda", 12),
            new User("Nick Fury", 50, "Huntsville", 13),
            new User("Barry Allen", 33, "Central City", 14),
            new User("Oliver Queen", 40, "New York", 15),
            new User("James Gordon", 47, "Gotham", 16),
            new User("Selina Kyle", 35, "New York", 17),
            new User("Maria Hill", 35, "New York", 18),
            new User("Scott Summers", 35, "New York", 19),
            new User("Jean Grey", 35, "New York", 20),
            new User("Lois Lane", 35, "Metropolis", 21),
            new User("Miles Morales", 35, "New York", 22),
            new User("Wade Wilson", 35, "New York", 23),
            new User("Hal Jordan", 30, "Coast City", 24),
            new User("Okoye", 27, "Wakanda", 25),
            new User("Hank Pim", 70, "San Francisco", 26),
            new User("Arthur Curry", 35, "Atlantis", 27),
            new User("Jane Foster", 35, "New York", 28),
            new User("Harley Quinn", 30, "Gothan", 29),
            new User("Lex Luthor", 45, "Metropolis", 30),
            new User("Barbara Gordon", 30, "Gotham", 31),
            new User("Jimmy Olsen", 30, "Metropolis", 32),
            new User("Wanda Maximoff", 32, "New York", 33),
            new User("Reed Richards", 43, "New York", 34),
            new User("Talia al Ghul", 35, "New York", 35),
            new User("Johnny Storm", 33, "New York", 36),
            new User("Jubilation Lee", 22, "Los Angeles", 37)
        };
    }
}
