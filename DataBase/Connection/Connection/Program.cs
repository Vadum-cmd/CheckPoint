using System;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Runtime.Remoting.Messaging;
using System.IO;

namespace Connection
{

    class Program
    {
        static void Main()
        {
            string theConnectionString = ConfigurationManager.ConnectionStrings["MainConnection"].ToString();
            MySqlConnection connection = new MySqlConnection(theConnectionString);

            var scriptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "scriptToGenerateDB.sql");
            string sqlScript = File.ReadAllText(scriptPath);

            try
            {
                connection.Open();
                if (connection.Ping())
                {
                    Console.WriteLine("Connected to database.");
                    Console.WriteLine("Press any key to proceed...");
                }

                MySqlCommand command = new MySqlCommand(sqlScript, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Database created successfully!");

                bool running = true;
                while (running)
                {
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("Write your command: ");
                    String input = Console.ReadLine();
                    String tableName;

                    switch (input)
                    {
                        case "exit":
                            running = false;
                            break;

                        case "get_table":
                            Console.Write("Write the name of the needed table: ");
                            tableName = Console.ReadLine();
                            GetTable(connection, tableName);
                            break;

                        case "insert_table":
                            Console.Write("Write the name of the needed table: ");
                            tableName = Console.ReadLine();
                            InsertTable(connection, tableName);
                            break;

                        default:
                            Console.WriteLine("Invalid command!");
                            break;
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.ReadKey();
            }
            finally
            {
                connection.Close();
                Console.WriteLine("Connection closed.");
            }
        }
        public static void GetTable(MySqlConnection connection, String tableName)
        {
            String sql = "SELECT * FROM " + tableName + " LIMIT 100";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            String col1, col2, col3, col4, col5, col6, col7, col8;

            switch (tableName)
            {
                case "action":
                    Console.Write("id" + "\t");
                    Console.Write("product_id" + "\t");
                    Console.Write("discount" + "\t");
                    Console.Write("date_from" + "\t");
                    Console.Write("date_to" + "\t");
                    Console.Write("amount" + "\n");

                    while (reader.Read())
                    {
                        col1 = $"{reader.GetString("id")}";
                        col2 = $"{reader.GetString("product_id")}";
                        col3 = $"{reader.GetString("discount")}";
                        col4 = $"{reader.GetString("date_from")}";
                        col5 = $"{reader.GetString("date_to")}";
                        col6 = $"{reader.GetString("amount")}";
                        Console.Write(col1 + "\t");
                        Console.Write(col2 + "\t");
                        Console.Write(col3 + "\t");
                        Console.Write(col4 + "\t");
                        Console.Write(col5 + "\t");
                        Console.Write(col6 + "\n");
                    }
                    break;
                case "employee":
                    Console.Write("id" + "\t");
                    Console.Write("name" + "\t");
                    Console.Write("surname" + "\t");
                    Console.Write("position" + "\t");
                    Console.Write("login" + "\t");
                    Console.Write("password" + "\t");
                    Console.Write("employee_permission_id" + "\n");

                    while (reader.Read())
                    {
                        col1 = $"{reader.GetString("id")}";
                        col2 = $"{reader.GetString("name")}";
                        col3 = $"{reader.GetString("surname")}";
                        col4 = $"{reader.GetString("position")}";
                        col5 = $"{reader.GetString("login")}";
                        col6 = $"{reader.GetString("password")}";
                        col7 = $"{reader.GetString("employee_permission_id")}";
                        Console.Write(col1 + "\t");
                        Console.Write(col2 + "\t");
                        Console.Write(col3 + "\t");
                        Console.Write(col4 + "\t");
                        Console.Write(col5 + "\t");
                        Console.Write(col6 + "\t");
                        Console.Write(col7 + "\n");
                    }
                    break;
                case "employee_permission":
                    Console.Write("id" + "\t");
                    Console.Write("title" + "\t");
                    Console.Write("acts" + "\n");

                    while (reader.Read())
                    {
                        col1 = $"{reader.GetString("id")}";
                        col2 = $"{reader.GetString("title")}";
                        col3 = $"{reader.GetString("acts")}";
                        Console.Write(col1 + "\t");
                        Console.Write(col2 + "\t");
                        Console.Write(col3 + "\n");
                    }
                    break;
                case "employee_session":
                    Console.Write("id" + "\t");
                    Console.Write("employee_id" + "\t");
                    Console.Write("time" + "\n");

                    while (reader.Read())
                    {
                        col1 = $"{reader.GetString("id")}";
                        col2 = $"{reader.GetString("employee_id")}";
                        col3 = $"{reader.GetString("time")}";
                        Console.Write(col1 + "\t");
                        Console.Write(col2 + "\t");
                        Console.Write(col3 + "\n");
                    }
                    break;
                case "invoice":
                    Console.Write("id" + "\t");
                    Console.Write("date_of" + "\t");
                    Console.Write("provider" + "\t");
                    Console.Write("total_price" + "\n");

                    while (reader.Read())
                    {
                        col1 = $"{reader.GetString("id")}";
                        col2 = $"{reader.GetString("total_price")}";
                        col3 = $"{reader.GetString("total_price")}";
                        col4 = $"{reader.GetString("date_of")}";
                        Console.Write(col1 + "\t");
                        Console.Write(col2 + "\t");
                        Console.Write(col3 + "\t");
                        Console.Write(col4 + "\n");
                    }
                    break;
                case "product":
                    Console.Write("id" + "\t");
                    Console.Write("name" + "\t");
                    Console.Write("price" + "\t");
                    Console.Write("category" + "\t");
                    Console.Write("description" + "\t");
                    Console.Write("date_manufacture" + "\t");
                    Console.Write("date_expiration" + "\t");
                    Console.Write("in_stock" + "\n");

                    while (reader.Read())
                    {
                        col1 = $"{reader.GetString("id")}";
                        col2 = $"{reader.GetString("name")}";
                        col3 = $"{reader.GetString("price")}";
                        col4 = $"{reader.GetString("category")}";
                        col5 = $"{reader.GetString("description")}";
                        col6 = $"{reader.GetString("date_manufacture")}";
                        col7 = $"{reader.GetString("date_expiration")}";
                        col8 = $"{reader.GetString("in_stock")}";
                        Console.Write(col1 + "\t");
                        Console.Write(col2 + "\t");
                        Console.Write(col3 + "\t");
                        Console.Write(col4 + "\t");
                        Console.Write(col5 + "\t");
                        Console.Write(col6 + "\t");
                        Console.Write(col7 + "\t");
                        Console.Write(col8 + "\n");
                    }
                    break;
                case "product_invoice":
                    Console.Write("invoice_id" + "\t");
                    Console.Write("product_id" + "\t");
                    Console.Write("amount" + "\n");

                    while (reader.Read())
                    {
                        col1 = $"{reader.GetString("invoice_id")}";
                        col2 = $"{reader.GetString("product_id")}";
                        col3 = $"{reader.GetString("amount")}";
                        Console.Write(col1 + "\t");
                        Console.Write(col2 + "\t");
                        Console.Write(col3 + "\n");
                    }
                    break;
                case "product_receipt":
                    Console.Write("receipt_id" + "\t");
                    Console.Write("product_id" + "\t");
                    Console.Write("amount" + "\t");
                    Console.Write("price" + "\t");
                    Console.Write("action_id" + "\n");

                    while (reader.Read())
                    {
                        col1 = $"{reader.GetString("receipt_id")}";
                        col2 = $"{reader.GetString("product_id")}";
                        col3 = $"{reader.GetString("amount")}";
                        col4 = $"{reader.GetString("price")}";
                        col5 = $"{reader.GetString("action_id")}";
                        Console.Write(col1 + "\t");
                        Console.Write(col2 + "\t");
                        Console.Write(col3 + "\t");
                        Console.Write(col4 + "\t");
                        Console.Write(col5 + "\n");
                    }
                    break;
                case "receipt":
                    Console.Write("id" + "\t");
                    Console.Write("total_price" + "\t");
                    Console.Write("date_of" + "\n");

                    while (reader.Read())
                    {
                        col1 = $"{reader.GetString("id")}";
                        col2 = $"{reader.GetString("total_price")}";
                        col3 = $"{reader.GetString("date_of")}";
                        Console.Write(col1 + "\t");
                        Console.Write(col2 + "\t");
                        Console.Write(col3 + "\n");
                    }
                    break;
                case "sale_statistic":
                    Console.Write("id" + "\t");
                    Console.Write("product_id" + "\t");
                    Console.Write("sold_out" + "\t");
                    Console.Write("sale_date" + "\t");
                    Console.Write("expired" + "\n");

                    while (reader.Read())
                    {
                        col1 = $"{reader.GetString("id")}";
                        col2 = $"{reader.GetString("product_id")}";
                        col3 = $"{reader.GetString("sold_out")}";
                        col4 = $"{reader.GetString("sale_date")}";
                        col5 = $"{reader.GetString("expired")}";
                        Console.Write(col1 + "\t");
                        Console.Write(col2 + "\t");
                        Console.Write(col3 + "\t");
                        Console.Write(col4 + "\t");
                        Console.Write(col5 + "\n");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid table name!");
                    break;
            }
            reader.Close();
        }

        public static void InsertTable(MySqlConnection connection, String tableName)
        {

            MySqlCommand command = connection.CreateCommand();
            String col1, col2, col3, col4, col5, col6, col7, col8;

            switch (tableName)
            {
                
                case "action":
                    command.CommandText = "INSERT INTO employee(id,product_id,discount,date_from,date_to,amount) " +
                        "VALUES(?id,?product_id,?discount,?date_from,?date_to,?amount)";
                    col1 = Console.ReadLine();
                    col2 = Console.ReadLine();
                    col3 = Console.ReadLine();
                    col4 = Console.ReadLine();
                    col5 = Console.ReadLine();
                    col6 = Console.ReadLine();
                    command.Parameters.AddWithValue("?id", col1);
                    command.Parameters.AddWithValue("?product_id", col2);
                    command.Parameters.AddWithValue("?discount", col3);
                    command.Parameters.AddWithValue("?date_from", col4);
                    command.Parameters.AddWithValue("?date_to", col5);
                    command.Parameters.AddWithValue("?amount", col6);
                    command.ExecuteNonQuery();
                    break;
                case "employee":
                    command.CommandText = "INSERT INTO employee(id,name,surname,position,login,password,employee_permission_id) " +
                        "VALUES(?id,?name,?surname,?position,?login,?password,?employee_permission_id)";
                    col1 = Console.ReadLine();
                    col2 = Console.ReadLine();
                    col3 = Console.ReadLine();
                    col4 = Console.ReadLine();
                    col5 = Console.ReadLine();
                    col6 = Console.ReadLine();
                    col7 = Console.ReadLine();
                    command.Parameters.AddWithValue("?id", col1);
                    command.Parameters.AddWithValue("?name", col2);
                    command.Parameters.AddWithValue("?surname", col3);
                    command.Parameters.AddWithValue("?position", col4);
                    command.Parameters.AddWithValue("?login", col5);
                    command.Parameters.AddWithValue("?password", col6);
                    command.Parameters.AddWithValue("?employee_permission_id", col7);
                    command.ExecuteNonQuery();
                    break;
                case "employee_permission":
                    command.CommandText = "INSERT INTO employee_permission(id,title,acts) " +
                        "VALUES(?id,?title,?acts)";
                    col1 = Console.ReadLine();
                    col2 = Console.ReadLine();
                    col3 = Console.ReadLine();
                    command.Parameters.AddWithValue("?id", col1);
                    command.Parameters.AddWithValue("?title", col2);
                    command.Parameters.AddWithValue("?acts", col3);
                    command.ExecuteNonQuery();
                    break;
                case "employee_session":
                    command.CommandText = "INSERT INTO employee_session(id,employee_id,time) " +
                        "VALUES(?id,?employee_id,?time)";
                    col1 = Console.ReadLine();
                    col2 = Console.ReadLine();
                    col3 = Console.ReadLine();
                    command.Parameters.AddWithValue("?id", col1);
                    command.Parameters.AddWithValue("?employee_id", col2);
                    command.Parameters.AddWithValue("?time", col3);
                    command.ExecuteNonQuery();
                    break;
                case "invoice":
                    command.CommandText = "INSERT INTO invoice(id,date_of,provider,total_price) " +
                        "VALUES(?id,?date_of,?provider,?total_price)";
                    col1 = Console.ReadLine();
                    col2 = Console.ReadLine();
                    col3 = Console.ReadLine();
                    col4 = Console.ReadLine();
                    command.Parameters.AddWithValue("?id", col1);
                    command.Parameters.AddWithValue("?date_of", col2);
                    command.Parameters.AddWithValue("?provider", col3);
                    command.Parameters.AddWithValue("?total_price", col4);
                    command.ExecuteNonQuery();
                    break;
                case "product":
                    command.CommandText = "INSERT INTO product(id,name,price,category,description,date_manufacture,date_expiration,in_stock) " +
                        "VALUES(?id,?name,?price,?category,?description,?date_manufacture,?date_expiration,?in_stock)";
                    col1 = Console.ReadLine();
                    col2 = Console.ReadLine();
                    col3 = Console.ReadLine();
                    col4 = Console.ReadLine();
                    col5 = Console.ReadLine();
                    col6 = Console.ReadLine();
                    col7 = Console.ReadLine();
                    col8 = Console.ReadLine();
                    command.Parameters.AddWithValue("?id", col1);
                    command.Parameters.AddWithValue("?name", col2);
                    command.Parameters.AddWithValue("?price", col3);
                    command.Parameters.AddWithValue("?category", col4);
                    command.Parameters.AddWithValue("?description", col5);
                    command.Parameters.AddWithValue("?date_manufacture", col6);
                    command.Parameters.AddWithValue("?date_expiration", col7);
                    command.Parameters.AddWithValue("?in_stock", col8);
                    command.ExecuteNonQuery();
                    break;
                case "product_invoice":
                    command.CommandText = "INSERT INTO product_invoice(invoice_id,product_id,amount) " +
                        "VALUES(?invoice_id,?product_id,?amount)";
                    col1 = Console.ReadLine();
                    col2 = Console.ReadLine();
                    col3 = Console.ReadLine();
                    command.Parameters.AddWithValue("?invoice_id", col1);
                    command.Parameters.AddWithValue("?product_id", col2);
                    command.Parameters.AddWithValue("?amount", col3);
                    command.ExecuteNonQuery();
                    break;
                case "product_receipt":
                    command.CommandText = "INSERT INTO product_receipt(receipt_id,product_id,amount,price,action_id) " +
                        "VALUES(?receipt_id,?product_id,?amount,?price,?action_id)";
                    col1 = Console.ReadLine();
                    col2 = Console.ReadLine();
                    col3 = Console.ReadLine();
                    col4 = Console.ReadLine();
                    col5 = Console.ReadLine();
                    command.Parameters.AddWithValue("?receipt_id", col1);
                    command.Parameters.AddWithValue("?product_id", col2);
                    command.Parameters.AddWithValue("?amount", col3);
                    command.Parameters.AddWithValue("?price", col4);
                    command.Parameters.AddWithValue("?action_id", col5);
                    command.ExecuteNonQuery();
                    break;
                case "receipt":
                    command.CommandText = "INSERT INTO receipt(id,total_price,date_of) " +
                        "VALUES(?id,?total_price,?date_of)";
                    col1 = Console.ReadLine();
                    col2 = Console.ReadLine();
                    col3 = Console.ReadLine();
                    command.Parameters.AddWithValue("?id", col1);
                    command.Parameters.AddWithValue("?total_price", col2);
                    command.Parameters.AddWithValue("?date_of", col3);
                    command.ExecuteNonQuery();
                    break;
                case "sale_statistic":
                    command.CommandText = "INSERT INTO sale_statistic(id,product_id,sold_out,sale_date,expired) " +
                        "VALUES(?id,?product_id,?sold_out,?sale_date,?expired)";
                    col1 = Console.ReadLine();
                    col2 = Console.ReadLine();
                    col3 = Console.ReadLine();
                    col4 = Console.ReadLine();
                    col5 = Console.ReadLine();
                    command.Parameters.AddWithValue("?id", col1);
                    command.Parameters.AddWithValue("?product_id", col2);
                    command.Parameters.AddWithValue("?sold_out", col3);
                    command.Parameters.AddWithValue("?sale_date", col4);
                    command.Parameters.AddWithValue("?expired", col5);
                    command.ExecuteNonQuery();
                    break;
                default:
                    Console.WriteLine("Invalid table name!");
                    break;
            }
        }

    }
}
