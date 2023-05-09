namespace LINQ;

public class Exercises
{
    #region Fields
    private List<Person> people = new()
    {
        new() { Name = "John Doe", Age = 25, City = "New York", Occupation = "Engineer", Salary = 75000 },
        new() { Name = "Jane Smith", Age = 32, City = "Los Angeles", Occupation = "Teacher", Salary = 60000 },
        new() { Name = "Bob Johnson", Age = 48, City = "Chicago", Occupation = "Sales Manager", Salary = 100000 },
        new() { Name = "Fernando Miguel Cortez", Age = 48, City = "Chicago", Occupation = "Engineer", Salary = 100000 },
        new()
        {
            Name = "Sarah Lee", Age = 29, City = "San Francisco", Occupation = "Software Developer", Salary = 90000
        },
        new() { Name = "Mike Brown", Age = 37, City = "Houston", Occupation = "Business Analyst", Salary = 80000 },
        new() { Name = "Lisa Kim", Age = 26, City = "Miami", Occupation = "Graphic Designer", Salary = 55000 },
        new() { Name = "David Lee", Age = 41, City = "Seattle", Occupation = "Product Manager", Salary = 120000 },
        new() { Name = "Karen Chen", Age = 34, City = "Boston", Occupation = "Financial Analyst", Salary = 95000 },
        new()
        {
            Name = "Steve Johnson", Age = 28, City = "Washington DC", Occupation = "Marketing Manager", Salary = 70000
        },
        new() { Name = "Emily Wong", Age = 31, City = "San Diego", Occupation = "UX Designer", Salary = 85000 },
        new() { Name = "Tom Williams", Age = 39, City = "Denver", Occupation = "Project Manager", Salary = 110000 },
        new() { Name = "Amy Davis", Age = 27, City = "Dallas", Occupation = "Copywriter", Salary = 60000 },
        new() { Name = "Brian Chang", Age = 43, City = "Atlanta", Occupation = "Operations Manager", Salary = 105000 },
        new() { Name = "Cathy Nguyen", Age = 36, City = "Portland", Occupation = "Data Scientist", Salary = 95000 },
        new()
        {
            Name = "Mark Rodriguez", Age = 33, City = "Phoenix", Occupation = "Sales Representative", Salary = 70000
        },
        new() { Name = "Rachel Garcia", Age = 30, City = "Austin", Occupation = "Web Developer", Salary = 80000 },
        new() { Name = "James Lee", Age = 44, City = "Las Vegas", Occupation = "Real Estate Agent", Salary = 120000 },
        new()
        {
            Name = "Megan Martin", Age = 29, City = "Philadelphia", Occupation = "Social Media Manager", Salary = 65000
        },
        new() { Name = "Kevin Kim", Age = 35, City = "San Antonio", Occupation = "IT Manager", Salary = 90000 },
        new() { Name = "Jenny Chen", Age = 26, City = "Minneapolis", Occupation = "Video Producer", Salary = 55000 },
        new()
        {
            Name = "Patrick Davis", Age = 40, City = "New Orleans", Occupation = "Restaurant Manager", Salary = 85000
        },
        new() { Name = "Julia Kim", Age = 32, City = "Salt Lake City", Occupation = "HR Manager", Salary = 95000 },
        new() { Name = "Sam Lee", Age = 27, City = "Raleigh", Occupation = "Account Executive", Salary = 70000 },
        new() { Name = "Lauren Johnson", Age = 31, City = "Nashville", Occupation = "Event Planner", Salary = 65000 },
        new()
        {
            Name = "Michael Nguyen", Age = 38, City = "Kansas City", Occupation = "Business Development Manager",
            Salary = 100000
        },
        new()
        {
            Name = "Stephanie Chen", Age = 29, City = "Orlando", Occupation = "Public Relations Specialist",
            Salary = 75000
        },
        new()
        {
            Name = "Scott Wilson", Age = 42, City = "St. Louis", Occupation = "Operations Analyst", Salary = 95000
        },
        new() { Name = "Melissa Kim", Age = 28, City = "Charlotte", Occupation = "Interior Designer", Salary = 60000 },
        new() { Name = "Evan Lee", Age = 36, City = "Tucson", Occupation = "Software Engineer", Salary = 90000 },
        new()
        {
            Name = "Christine Davis", Age = 33, City = "Oklahoma City", Occupation = "Marketing Coordinator",
            Salary = 65000
        },
        new()
        {
            Name = "Adam Brown", Age = 45, City = "Albuquerque", Occupation = "Financial Advisor", Salary = 110000
        },
        new() { Name = "Samantha Kim", Age = 30, City = "Honolulu", Occupation = "Art Director", Salary = 80000 },
        new() { Name = "George Johnson", Age = 37, City = "Louisville", Occupation = "Engineer", Salary = 85000 },
        new() { Name = "Linda Chen", Age = 25, City = "Boise", Occupation = "Journalist", Salary = 55000 },
        new()
        {
            Name = "Matthew Davis", Age = 41, City = "Madison", Occupation = "Operations Coordinator", Salary = 90000
        },
        new()
        {
            Name = "Emily Kim", Age = 34, City = "Richmond", Occupation = "Digital Marketing Specialist", Salary = 75000
        },
        new() { Name = "Jason Lee", Age = 39, City = "Columbus", Occupation = "Sales Director", Salary = 105000 },
        new() { Name = "Amanda Brown", Age = 26, City = "Anchorage", Occupation = "UX Researcher", Salary = 60000 },
        new() { Name = "Erica Johnson", Age = 43, City = "Charleston", Occupation = "HR Specialist", Salary = 100000 },
        new() { Name = "Daniel Kim", Age = 31, City = "Des Moines", Occupation = "Data Analyst", Salary = 75000 },
        new() { Name = "Jessica Lee", Age = 28, City = "Asheville", Occupation = "Content Strategist", Salary = 65000 },
        new() { Name = "Sean Davis", Age = 37, City = "Indianapolis", Occupation = "Logistics Manager", Salary = 90000 }
    };
    #endregion

    #region Public members
    public void Exercise1()
    {
        // Find all people who live in a city that starts with the letter "S", and sort them by their age in descending order.
        var ex1 = people.Where(person => person.City.StartsWith("S"))
            .OrderByDescending(p => p.Age);

        Console.WriteLine();
        Console.WriteLine("====== Exercise 1 =======");
        foreach (var res in ex1)        
        {
            Console.WriteLine($"{res.Name}: City={res.City}, Age={res.Age}");
        }
        
    }

    public void Exercise2()
    {
        // Write a LINQ query that finds the person who has the longest name and is also an engineer.
        var ex2 = people.Where(person => person.Occupation == "Engineer")
            .OrderByDescending(p => p.Name.Length)
            .First();

            Console.WriteLine();
            Console.WriteLine("====== Exercise 2 =======");
            Console.WriteLine($"{ex2.Name}: {ex2.Occupation}");           
    }

    public void Exercise3()
    {
        // Find all people whose age is between 30 and 40, and sort them by name in alphabetical order.
        var ex3 = people.Where(person => person.Age >= 30 && person.Age <= 40)
            .OrderBy(p => p.Name);

        Console.WriteLine();
        Console.WriteLine("====== Exercise 3 =======");
        foreach (var res in ex3)
        {
            Console.WriteLine($"{res.Name}: Age = {res.Age}");
        }
        
    }

    public void Exercise4()
    {
        // Find the top 5 highest paid people who live in a city that starts with the letter "C".
        var ex4 = people.Where(p => p.City.StartsWith("C"))
            .OrderByDescending(p => p.Salary)
            .Take(5);

        Console.WriteLine();
        Console.WriteLine("====== Exercise 4 =======");
        foreach (var res in ex4)
        {
            Console.WriteLine($"{res.Name}: City= {res.City}, Salary= {res.Salary}");
        }
    }

    public void Exercise5()
    {
        // Find the top 3 cities by the total salary earned by people who live in those cities.
        var ex5 = people.GroupBy(p => p.City)
            .Select(c => new { City = c.Key, TotalSalary = c.Sum(p => p.Salary) })
            .OrderByDescending(c => c.TotalSalary)
            .Take(3);
        
        Console.WriteLine();
        Console.WriteLine("====== Exercise 5 =======");
        foreach (var res in ex5)
        {
            Console.WriteLine($"{res.City}: Total= {res.TotalSalary}");
        }
    }
    

    public void Exercise6()
    {
        // Find all people whose name contains the letter "a", group them by the first letter of their occupation,
        // and sort the groups in descending order by the number of people in each group.
        var ex6 = people.Where(p => p.Name.Contains("a"))
            .GroupBy(p => p.Occupation.First())
            .OrderByDescending(p => p.Count());

        Console.WriteLine();
        Console.WriteLine("====== Exercise 6 =======");
        foreach (var group in ex6)
        {
            Console.WriteLine(group.Key + ": ");
            foreach (var res in group)
            {
                Console.WriteLine($"   {res.Occupation} --> {res.Name}");
            }
        }
    }
    #endregion

    #region Nested Types
    public class Person
    {
        #region Properties and Indexers
        public int Age { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public string Occupation { get; set; }
        public double Salary { get; set; }
        #endregion
    }
    #endregion
}
