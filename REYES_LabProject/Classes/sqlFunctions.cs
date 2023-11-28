using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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

        public static string GetUserId(string username)
        {
            try
            {
                connection.Open();

                string selectQuery = "SELECT user_id FROM tbl_user WHERE user_name = @username";

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

        public static int GetRoleIdForUser(int userId)
        {
            string adminQuery = "SELECT admin_id FROM tbl_admin WHERE user_id = @userId";
            string doctorQuery = "SELECT doctor_id FROM tbl_doctor WHERE user_id = @userId";
            string patientQuery = "SELECT patient_id FROM tbl_patient WHERE user_id = @userId";

            try
            {
                connection.Open();

                using (MySqlCommand adminCommand = new MySqlCommand(adminQuery, connection))
                using (MySqlCommand doctorCommand = new MySqlCommand(doctorQuery, connection))
                using (MySqlCommand patientCommand = new MySqlCommand(patientQuery, connection))
                {
                    adminCommand.Parameters.AddWithValue("@userId", userId);
                    doctorCommand.Parameters.AddWithValue("@userId", userId);
                    patientCommand.Parameters.AddWithValue("@userId", userId);

                    object adminResult = adminCommand.ExecuteScalar();
                    object doctorResult = doctorCommand.ExecuteScalar();
                    object patientResult = patientCommand.ExecuteScalar();

                    if (adminResult != null)
                    {
                        return (int)adminResult;
                    }

                    if (doctorResult != null)
                    {
                        return (int)doctorResult;
                    }

                    if (patientResult != null)
                    {
                        return (int)patientResult;
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

            // Return a default value (you may want to handle this differently based on your needs)
            return -1;
        }

        public static string GetRoleNameForUser(int userId)
        {
            string adminQuery = "SELECT admin_name FROM tbl_admin WHERE user_id = @userId";
            string doctorQuery = "SELECT doctor_name FROM tbl_doctor WHERE user_id = @userId";
            string patientQuery = "SELECT patient_name FROM tbl_patient WHERE user_id = @userId";

            try
            {
                connection.Open();

                using (MySqlCommand adminCommand = new MySqlCommand(adminQuery, connection))
                using (MySqlCommand doctorCommand = new MySqlCommand(doctorQuery, connection))
                using (MySqlCommand patientCommand = new MySqlCommand(patientQuery, connection))
                {
                    adminCommand.Parameters.AddWithValue("@userId", userId);
                    doctorCommand.Parameters.AddWithValue("@userId", userId);
                    patientCommand.Parameters.AddWithValue("@userId", userId);

                    object adminResult = adminCommand.ExecuteScalar();
                    object doctorResult = doctorCommand.ExecuteScalar();
                    object patientResult = patientCommand.ExecuteScalar();

                    if (adminResult != null)
                    {
                        return adminResult.ToString();
                    }

                    if (doctorResult != null)
                    {
                        return doctorResult.ToString();
                    }

                    if (patientResult != null)
                    {
                        return patientResult.ToString();
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

            // Return a default value or handle it based on your needs
            return null;
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

        public static DataTable GetInactiveUsers(int isactive)
        {
            DataTable dataTable = new DataTable();
            string query = $"SELECT user_id, user_name, user_isactive, user_role FROM tbl_user WHERE user_isactive = {isactive.ToString()}";

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

        public static string GetUsername(int userId)
        {
            string query = "SELECT user_name FROM tbl_user WHERE user_id = @userId";
            string userName = null;

            try
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        userName = result.ToString();
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

            return userName;
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

        public static void ActivateUser(int userId, int activate)
        {
            string query = "UPDATE tbl_user SET user_isactive = @activate WHERE user_id = @user_id";

            try
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@user_id", userId);
                    command.Parameters.AddWithValue("@activate", activate);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("User not found.");
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
            string query = "INSERT INTO tbl_audit (audit_user_id, audit_context, audit_datetime) VALUES (@userId, @auditContext, @auditDateTime)";
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

        public static void DeleteRowByPrimaryKey(string tableName, string primaryKeyColumnName, int primaryKeyValue)
        {
            string query = $"DELETE FROM {tableName} WHERE {primaryKeyColumnName} = @primaryKeyValue";

            try
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Row deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Row not found or not deleted.");
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

        public static void UpdateUsername(int userid, string username)
        {
            string query = "UPDATE tbl_user SET user_name = @username WHERE user_id = @user_id";

            try
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@user_id", userid);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Username updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Username not updated.");
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

        public static void UpdatePassword(int userid, string password)
        {
            string query = "UPDATE tbl_user SET user_password = @user_password WHERE user_id = @user_id";

            try
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@user_password", password);
                    command.Parameters.AddWithValue("@user_id", userid);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Password updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Password not updated.");
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

        public static void UpdateDisplayname(int userid, string displayname)
        {
            string query = "";

            if (GetUserRole(userid) == "Admin")
            {
                query = "UPDATE tbl_admin SET admin_name = @displayname WHERE user_id = @user_id";
            }
            else if(GetUserRole(userid) == "Doctor")
            {
                query = "UPDATE tbl_doctor SET doctor_name = @displayname WHERE user_id = @user_id";
            } 
            else
            {
                query = "UPDATE tbl_patient SET patient_name = @displayname WHERE user_id = @user_id";
            }

            try
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@displayname", displayname);
                    command.Parameters.AddWithValue("@user_id", userid);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Displayname updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Displayname not updated.");
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

        public static void UpdateUserFromDoctor(int doctor_id, int user_id, string doctor_name)
        {
            string query = "UPDATE tbl_doctor SET user_id = @userId, doctor_name = @doctor_name WHERE doctor_id = @doctorId";

            try
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", user_id);
                    command.Parameters.AddWithValue("@doctor_name", doctor_name);
                    command.Parameters.AddWithValue("@doctorId", doctor_id);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("User information updated successfully for doctor_id: " + doctor_id);
                    }
                    else
                    {
                        Console.WriteLine("Doctor not found or user information not updated.");
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

        public static void UpdateUserFromPatient(int patient_id, int user_id, string patient_name)
        {
            string query = "UPDATE tbl_patient SET user_id = @user_id, patient_name = @patient_name WHERE patient_id = @patient_id";

            try
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@patient_id", patient_id);
                    command.Parameters.AddWithValue("@user_id", user_id);
                    command.Parameters.AddWithValue("@patient_name", patient_name);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("User information updated successfully for patient_id: " + patient_id);
                    }
                    else
                    {
                        Console.WriteLine("Patient not found or user information not updated.");
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

        public static void AddMedicalRecord(int patient_id, int doctor_id, string record_date, string record_diagnosis, string record_prescription, string record_treatmentplan)
        {
            string query = "INSERT INTO tbl_medical_record (patient_id, doctor_id, record_date, record_diagnosis, record_prescription, record_treatmentplan) VALUES (@patientId, @doctorId, @recordDate, @recordDiagnosis, @recordPrescription, @recordTreatmentPlan)";

            try
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@patientId", patient_id);
                    command.Parameters.AddWithValue("@doctorId", doctor_id);
                    command.Parameters.AddWithValue("@recordDate", record_date);
                    command.Parameters.AddWithValue("@recordDiagnosis", record_diagnosis);
                    command.Parameters.AddWithValue("@recordPrescription", record_prescription);
                    command.Parameters.AddWithValue("@recordTreatmentPlan", record_treatmentplan);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Medical record added successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Medical record not added.");
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

        public static void DeleteMedicalRecord(int record_id)
        {
            string query = "DELETE FROM tbl_medical_record WHERE record_id = @recordId";

            try
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@recordId", record_id);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Medical record deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Medical record not found or not deleted.");
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

        public static void UpdateMedicalRecord(int record_id, int patient_id, int doctor_id, string record_date, string record_diagnosis, string record_prescription, string record_treatmentplan)
        {
            string query = "UPDATE tbl_medical_record SET patient_id = @patientId, doctor_id = @doctorId, record_date = @recordDate, record_diagnosis = @recordDiagnosis, record_prescription = @recordPrescription, record_treatmentplan = @recordTreatmentPlan WHERE record_id = @recordId";

            try
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@patientId", patient_id);
                    command.Parameters.AddWithValue("@doctorId", doctor_id);
                    command.Parameters.AddWithValue("@recordDate", record_date);
                    command.Parameters.AddWithValue("@recordDiagnosis", record_diagnosis);
                    command.Parameters.AddWithValue("@recordPrescription", record_prescription);
                    command.Parameters.AddWithValue("@recordTreatmentPlan", record_treatmentplan);
                    command.Parameters.AddWithValue("@recordId", record_id);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Medical record updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Medical record not found or not updated.");
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

        public static void AddBilling(int patient_id, int doctor_id, int record_id, string billing_date, string billing_total, string billing_paymentstatus)
        {
            string query = "INSERT INTO tbl_billing (patient_id, doctor_id, record_id, billing_date, billing_total, billing_paymentstatus) VALUES (@patientId, @doctorId, @recordId, @billingDate, @billingTotal, @billingPaymentStatus)";

            try
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@patientId", patient_id);
                    command.Parameters.AddWithValue("@doctorId", doctor_id);
                    command.Parameters.AddWithValue("@recordId", record_id);
                    command.Parameters.AddWithValue("@billingDate", billing_date);
                    command.Parameters.AddWithValue("@billingTotal", billing_total);
                    command.Parameters.AddWithValue("@billingPaymentStatus", billing_paymentstatus);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Billing record added successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Billing record not added.");
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

        public static void UpdateBilling(int billing_id, int patient_id, int doctor_id, int record_id, string billing_date, string billing_total, string billing_paymentstatus)
        {
            string query = "UPDATE tbl_billing SET patient_id = @patientId, doctor_id = @doctorId, record_id = @recordId, billing_date = @billingDate, billing_total = @billingTotal, billing_paymentstatus = @billingPaymentStatus WHERE billing_id = @billingId";

            try
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@patientId", patient_id);
                    command.Parameters.AddWithValue("@doctorId", doctor_id);
                    command.Parameters.AddWithValue("@recordId", record_id);
                    command.Parameters.AddWithValue("@billingDate", billing_date);
                    command.Parameters.AddWithValue("@billingTotal", billing_total);
                    command.Parameters.AddWithValue("@billingPaymentStatus", billing_paymentstatus);
                    command.Parameters.AddWithValue("@billingId", billing_id);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Billing record updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Billing record not found or not updated.");
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

        public static void DeleteBilling(int billing_id)
        {
            string query = "DELETE FROM tbl_billing WHERE billing_id = @billingId";

            try
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@billingId", billing_id);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Billing record deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Billing record not found or not deleted.");
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

        public static void MarkBillingAsPaid(int billing_id)
        {
            string query = "UPDATE tbl_billing SET billing_paymentstatus = 'PAID' WHERE billing_id = @billingId";

            try
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@billingId", billing_id);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Billing record marked as PAID successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Billing record not found or not updated.");
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

        public static string GetPrimaryKeyColumnName(string tableName)
        {
            string primaryKeyColumnName = null;

            try
            {
                string query = @"SELECT COLUMN_NAME
                        FROM INFORMATION_SCHEMA.COLUMNS
                        WHERE TABLE_SCHEMA = 'db_hospital'
                          AND TABLE_NAME = @tableName
                          AND COLUMN_KEY = 'PRI'";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tableName", tableName);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        primaryKeyColumnName = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return primaryKeyColumnName;
        }

        public static DataTable GetDataByPrimaryKey(string tableName, int primaryKeyId)
        {
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();

                // Get the primary key column name
                string primaryKeyColumnName = GetPrimaryKeyColumnName(tableName);

                if (string.IsNullOrEmpty(primaryKeyColumnName))
                {
                    MessageBox.Show($"Table '{tableName}' doesn't have a primary key column.");
                    return dataTable;
                }

                // Use the primary key column name to fetch data
                //string query = $"SELECT * FROM {tableName} WHERE {primaryKeyColumnName} = @primaryKeyId";
                string query = $"CALL GetDataFromUserId('{tableName}', '{primaryKeyColumnName}', {primaryKeyId})";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    //command.Parameters.AddWithValue("@primaryKeyId", primaryKeyId);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
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

            return dataTable;
        }

        public static DataTable GetMedicalRecordsForPatient(int patientId)
        {
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();

                // Assuming "patient_id" is the actual column name in your table
                string query = "SELECT * FROM tbl_medical_record WHERE patient_id = @patientId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@patientId", patientId);

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

        public static DataTable GetBillingRecordsForPatient(int patientId)
        {
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();

                // Assuming "patient_id" is the actual column name in your table
                string query = "SELECT * FROM tbl_billing WHERE patient_id = @patientId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@patientId", patientId);

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

        public static void BackupDatabase()
        {
            string Server = "localhost";
            string Database = "db_hospital";
            string User = "root";
            string Password = "root";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            string mysqlDumpPath = @"C:\Program Files\MySQL\MySQL Server 8.0\bin\mysqldump.exe";
            try
            {
                // Show the save file dialog to get the backup file path
                saveFileDialog.Filter = "SQL Files (.sql)|*.sql|All Files (.)|*.*";
                saveFileDialog.FileName = "backup.sql";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string backupFilePath = saveFileDialog.FileName;

                    // Build the mysqldump command
                    string command = $"--host={Server} --user={User} --password={Password} --databases {Database} --routines --result-file={backupFilePath}";

                    // Execute the mysqldump command
                    ProcessStartInfo processStartInfo = new ProcessStartInfo(mysqlDumpPath, command)
                    {
                        CreateNoWindow = true,
                        UseShellExecute = false,
                        RedirectStandardOutput = true
                    };

                    Process process = new Process { StartInfo = processStartInfo };
                    process.Start();

                    string output = process.StandardOutput.ReadToEnd(); // Read standard output
                    process.WaitForExit();

                    MessageBox.Show("Backup completed successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during backup: {ex.Message}");
            }
        }

        public static void RestoreDatabase()
        {
            string Server = "localhost";
            string Database = "db_hospital";
            string User = "root";
            string Password = "root";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string mysqlPath = @"C:\Program Files\MySQL\MySQL Server 8.0\bin\mysql.exe";
            try
            {
                openFileDialog.Filter = "SQL Files (.sql)|*.sql|All Files (.)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string restoreFilePath = openFileDialog.FileName;
                    string command = $"--host={Server} --user={User} --password={Password} --database {Database}";

                    ProcessStartInfo processStartInfo = new ProcessStartInfo(mysqlPath, command)
                    {
                        CreateNoWindow = true,
                        UseShellExecute = false,
                        RedirectStandardInput = true
                    };

                    Process process = new Process { StartInfo = processStartInfo };
                    process.Start();

                    string sqlFileContent = File.ReadAllText(restoreFilePath);
                    process.StandardInput.WriteLine(sqlFileContent);
                    process.StandardInput.Close();
                    process.WaitForExit();

                    MessageBox.Show("Restore completed successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during restore: {ex.Message}");
            }
        }

        public static bool TestDatabaseConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

    }
}
