using AccountManagementData;
using AccountManagementModels;
using AccountManagementServices;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UserGetServices getServices = new UserGetServices();

            //var users = getServices.GetUsersByStatus(1);

            //foreach (var item in users)
            //{
            //    Console.WriteLine(item.username);
            //    Console.WriteLine(item.password);
            //}

            SqlDbData db = new SqlDbData();

            List<User> users = db.GetUsers();

            Console.WriteLine("Existing Users:");
            foreach (User user in users)
            {
                Console.WriteLine(user.username);
            }

            string newUsername = "Carlos";
            string newPassword = "Bote";
            int addUserResult = db.AddUser(newUsername, newPassword);

            if (addUserResult > 0)
            {
                Console.WriteLine($"User '{newUsername}' added successfully!");
            }
            else
            {
                Console.WriteLine("Failed to add new user.");
            }

        }
    }
}