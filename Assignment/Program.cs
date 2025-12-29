using Assignment.DAL;
using Assignment.Model;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DbContext db = new DbContext();

            Console.WriteLine("lOGIN PAGE!");
            Console.WriteLine("Enter your choice");
            Console.WriteLine("1.Login Page");
            Console.WriteLine("2.Sign Up Page");
            Console.WriteLine("3.Forgot Password");
            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:

                    User userCheck = new User();
                    Console.WriteLine("Enter Your User Name");
                    userCheck.UserName = Console.ReadLine();
                    Console.WriteLine("Enter Your Password");
                    userCheck.Password = Console.ReadLine();

                    int row = db.checkUser(userCheck);
                    if (row > 0)
                    {
                        Console.WriteLine($"Welcome {userCheck.UserName}");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect UserName/Password");
                    }


                    break;

                case 2:
                    User insertUser = new User();
                    Console.WriteLine("Enter Your Name");
                    insertUser.Name = Console.ReadLine();
                    Console.WriteLine("Enter your UserName");
                    insertUser.UserName = Console.ReadLine();
                    Console.WriteLine("Enter your Password");
                    insertUser.Password = Console.ReadLine();

                    int rows = db.InsertUser(insertUser);

                    if (rows > 0)
                    {
                        Console.WriteLine("User Has been Created Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Unable to Create User");
                    }
                    break;
                case 3:
                    User updateUser = new User();

                    Console.WriteLine("Enter your UserName");
                    updateUser.UserName = Console.ReadLine();
                    Console.WriteLine("Enter your New Password");
                    updateUser.Password = Console.ReadLine();

                    int upRow = db.UpdateUser(updateUser);

                    if (upRow > 0)
                    {
                        Console.WriteLine("Password Has been Updated Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Unable to Find UserName");
                    }


                    break;

                default:
                    break;

            }

        }
    }
}