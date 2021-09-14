using MoreEverything.Console;
using MoreEverything.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<User> userQueue = new Queue<User>();
            userQueue.Enqueue(new User()
            {
                Username = "Test"
            });

            Dictionary<string, Action> actions = new Dictionary<string, Action>();
            actions.Add("Add user", () =>
            {
                User user = new User()
                {
                    Username = ConsoleEx.GetInput<string>("Username: ", false)
                };

                userQueue.Enqueue(user);
                Console.WriteLine("User added to queue!");
            });

            actions.Add("Delete user", () =>
            {
                string username = ConsoleEx.GetInput<string>("Write the username of the user you wish to remove from the queue: ", false);

                var users = userQueue.FindAllToList(m => m.Username.Equals(username));
                if (users.Count > 0)
                {
                    if (users.Count > 1)
                        Console.WriteLine("More than 1 users with that username, manual deletion is required.");
                    else
                    {
                        userQueue = new Queue<User>(userQueue.Where(u => !u.Username.Equals(username)));
                        Console.WriteLine("User removed!");
                    }
                }
                else
                    Console.WriteLine($"Could not find a user with the username: {username}");
            });

            actions.Add("Show the number of users", () => Console.WriteLine(userQueue.Count));
            actions.Add("Show the min and max of users", () => Console.WriteLine($"First user: {userQueue.ElementAt(0).Username}\r\nLast user: {userQueue.ElementAt(userQueue.Count - 1).Username}"));
            actions.Add("Find an user", () =>
            {
                string input = ConsoleEx.GetInput<string>("Who would you like to find?");

                var users = userQueue.FindAllToList(u => u.Username.Equals(input));
                if (users.Count > 0)
                {
                    users.ForEach(u => Console.WriteLine(u.Username));
                }
            });
            actions.Add("Print all users", () => userQueue.ForEach(u => Console.WriteLine(u.Username)));
            actions.Add("Exit", () => Environment.Exit(0));

            SinglePageNavigationMenu menu = new SinglePageNavigationMenu(actions);

            while (true)
            {
                Console.Clear();

                Console.WriteLine("==================================================\r\n" +
                                  "             H1 Queue Operations Menu\r\n" +
                                  "==================================================");

                int i = 1;
                actions.ForEach(s => Console.WriteLine($"{i++}. {s.Key}"));

                var input = ConsoleEx.GetInput<int>("Enter your choice: ", false) - 1;

                Console.Clear();
                actions.ElementAt(input).Value.Invoke();
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }

        }
    }
}
