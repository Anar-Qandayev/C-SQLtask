using System;
using System.Data.SqlClient;

namespace AdoNet
{
    class Program
    {
        private static string connectionString = @"Server=213-8;Database=Cinema;Trusted_Connection=True; ";
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            CreateCustomers("Elvin","Mirzeyev");
            // GetCustomersById(10);
            //GetHallById(4);
            //GetActorsById(4);
            //GetGenresById(4);
           // GetSeansById(2);
            //GetTicketsById(1);

            //DeleteCustomers(3);
        }
        static void GetCustomersById(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"select Name from Customers where Id={id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    string result = comm.ExecuteScalar().ToString();
                    Console.WriteLine(result);
                }
            }
        }
        static void GetHallById(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"select Name from Hall where Id={id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    string result = comm.ExecuteScalar().ToString();
                    Console.WriteLine(result);
                }
            }
        }
        static void GetActorsById(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"select Name from Actors where Id={id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    string result = comm.ExecuteScalar().ToString();
                    Console.WriteLine(result);
                }
            }
        }
        static void GetGenresById(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"select Name from Genres where Id={id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    string result = comm.ExecuteScalar().ToString();
                    Console.WriteLine(result);
                }
            }
        }
        static void GetSeansById(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"select Time from Seans where Id={id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    string result = comm.ExecuteScalar().ToString();
                    Console.WriteLine(result);
                }
            }
        }
        static void GetTicketsById(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"select SoldDate,Price from Tickets where Id={id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    string result = comm.ExecuteScalar().ToString();
                    
                    Console.WriteLine(result);
                }
            }
        }
        static void CreateCustomers(string Name, string Surname)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"INSERT INTO Customers values(N'{Name}',N'{Surname}')";
                SqlCommand comm = new SqlCommand(command, conn);

                //using (SqlCommand comm = new SqlCommand(command, conn))
                //{
                       //string result = comm.ExecuteScalar().ToString();
                       //Console.WriteLine(comm.ExecuteNonQuery());
                //    //if (comm.ExecuteNonQuery() > 0)
                //    //{
                //    //    Console.WriteLine("Customer CREATED"); 
                //    //}
                //    //else
                //    //{
                //    //    Console.WriteLine("Something went wrong");
                //    //}
                //}
            }
        }
        //static void DeleteCustomers(int id)
        //{
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        conn.Open();
        //        string command = $"DELETE  Customers where Id={id}";
        //        using (SqlCommand comm = new SqlCommand(command, conn))
        //        {
        //            try
        //            {
        //                if (comm.ExecuteNonQuery() > 0)
        //                {
        //                    Console.WriteLine("Customer deleted");
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Somethin went wrong");
        //                }

        //            }
        //            catch (NullReferenceException)
        //            {

        //                Console.WriteLine("Customers not found");
        //            }


        //        }
        //    }
        //}
    }
}