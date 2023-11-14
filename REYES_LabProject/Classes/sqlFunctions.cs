using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace REYES_LabProject
{
    internal class sqlFunctions
    {
        static string connectionString = "Server=localhost;Database=db_hospital;User Id=root;Password=root;";
        static MySqlConnection connection = new MySqlConnection(connectionString);

        public static bool RegisterUser(string username, string password, string role, int activate)
        {
            try
            {
                connection.Open();

                string insertQuery = "INSERT INTO tbl_user (user_name, user_password, user_role, user_isactive) VALUES (@Username, @Password, @Userrole, @IsActive)";

                using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Userrole", role);
                    cmd.Parameters.AddWithValue("@IsActive", activate);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Record inserted successfully
                        return true;
                    }
                    else
                    {
                        // Insertion failed
                        return false;
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle MySQL database-related exceptions
                Console.WriteLine($"MySQL Exception: {ex.Message}");
                return false; // or re-throw the exception if needed
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                Console.WriteLine($"Exception: {ex.Message}");
                return false; // or re-throw the exception if needed
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

                connection.Dispose();
            }
        }

        public static string GetUserRole(string username)
        {
            try
            {
                connection.Open();

                string selectQuery = "SELECT user_role FROM tbl_user WHERE user_name = @username";

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        // Username found, return the role as a string
                        return result.ToString();
                    }
                    else
                    {
                        // Username not found
                        return "User not found";
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle MySQL database-related exceptions
                Console.WriteLine($"MySQL Exception: {ex.Message}");
                return "Error" + ex; // or re-throw the exception if needed
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                Console.WriteLine($"Exception: {ex.Message}");
                return "Error" + ex; // or re-throw the exception if needed
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

                connection.Dispose();
            }
        }

        public static bool IsActive(string username)
        {
            try
            {
                connection.Open();

                // SQL query to retrieve the isactive value for the given username
                string query = "SELECT user_isactive FROM tbl_user WHERE user_name = @username";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);


                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Check the isactive column value
                            int isActiveValue = reader.GetInt32("user_isactive");
                            return isActiveValue == 1;
                        }
                        else
                        {
                            // Username not found
                            return false;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle MySQL database-related exceptions
                Console.WriteLine($"MySQL Exception: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                Console.WriteLine($"Exception: {ex.Message}");
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

                connection.Dispose();
            }
        }

        public static bool UsernameExists(string username)
        {
            try
            {
                connection.Open();

                string selectQuery = "SELECT COUNT(*) FROM tbl_user WHERE user_name = @Username";

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
            catch (MySqlException ex)
            {
                // Handle MySQL database-related exceptions
                Console.WriteLine($"MySQL Exception: {ex.Message}");
                // You can choose to re-throw the exception or return an error indicator here
                return false;
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                Console.WriteLine($"Exception: {ex.Message}");
                // You can choose to re-throw the exception or return an error indicator here
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

                connection.Dispose();
            }
        }

        public static bool LoginUser(string username, string password)
        {
            try
            {
                connection.Open();

                string selectQuery = "SELECT user_password FROM tbl_user WHERE user_name = @Username";

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    string storedPassword = cmd.ExecuteScalar()?.ToString();

                    if (storedPassword != null)
                    {
                        // Compare the storedPassword with the input password (you should hash the input password before comparing).
                        return storedPassword == password;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle MySQL database-related exceptions
                Console.WriteLine($"MySQL Exception: {ex.Message}");
                // You can choose to re-throw the exception or return an error indicator here
                return false;
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                Console.WriteLine($"Exception: {ex.Message}");
                // You can choose to re-throw the exception or return an error indicator here
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

                connection.Dispose();
            }

        }

        public static DataTable GetTableData(string tableName)
        {
            DataTable dataTable = new DataTable();
            string query = $"SELECT * FROM {tableName}";

            try
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

                connection.Dispose();
            }

            return dataTable;
        }

        public static DataTable GetInactiveUsers()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT user_id, user_name, user_isactive, user_role FROM tbl_user WHERE user_isactive = 0";

            try
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

                connection.Dispose();
            }

            return dataTable;
        }

        public static void ActivateUser(int userId)
        {
            string query = "UPDATE tbl_user SET user_isactive = 1 WHERE user_id = @user_id";

            try
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@user_id", userId);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User activated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("User not found or already activated.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

                connection.Dispose();
            }
        }

        public static string GetUserRole(int userId)
        {
            string query = "SELECT user_role FROM tbl_user WHERE user_id = @userId";
            string userRole = null;

            try
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        userRole = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

                connection.Dispose();
            }

            return userRole;
        }

        public static void InsertUserIdIntoTable(string tableName, int userId)
        {
            string query = $"INSERT INTO {tableName} (user_id) VALUES (@userId)";

            try
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine($"User ID {userId} inserted into {tableName} successfully.");
                    }
                    else
                    {
                        Console.WriteLine($"User ID {userId} not inserted into {tableName}.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

                connection.Dispose();
            }
        }

        public static void InsertAuditData(int userId, string auditContext)
        {
            string query = "INSERT INTO tbl_audit (user_id, audit_context, audit_datetime) VALUES (@userId, @auditContext, @auditDateTime)";
            string auditDateTime = DateTime.Now.ToString();

            try
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@auditContext", auditContext);
                    command.Parameters.AddWithValue("@auditDateTime", auditDateTime);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Audit data inserted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Audit data not inserted.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

                connection.Dispose();
            }
        }


    }
}
