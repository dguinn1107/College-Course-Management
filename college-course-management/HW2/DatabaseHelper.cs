using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CollegeCourseManagement
    {
        public static class DatabaseHelper
        {
        private static SqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CollegeCourseDb"].ConnectionString;
            return new SqlConnection(connectionString);
        }
        public static void DeleteCourseInDatabase(string courseID)
            {
                try
                {
                    using (SqlConnection connection = GetConnection())
                    {
                        connection.Open();
                        string query = "DELETE FROM course_info WHERE course_id = @course_id";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@course_id", courseID);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                Console.WriteLine("Course successfully deleted from the database.");
                            }
                            else
                            {
                                Console.WriteLine("No rows were affected. The course might not exist.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error occurred during deletion: " + ex.Message);
                }
            }

            public static DataTable GetAllCourses()
            {
                DataTable courses = new DataTable();

                try
                {
                    using (SqlConnection connection = GetConnection())
                    {
                        connection.Open();
                        string query = "SELECT * FROM course_info";

                        using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                        {
                            adapter.Fill(courses);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error occurred while fetching courses: " + ex.Message);
                }

                return courses;
            }
        }
    }



