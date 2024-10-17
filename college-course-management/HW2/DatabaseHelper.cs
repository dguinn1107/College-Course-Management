using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

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


        public static void AddCourse(string courseID, string courseName, int courseHrs, string courseTime,
                                     string courseDaysScheduled, string courseSemesterOffered)
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    string query = "INSERT INTO course_info (course_id, course_name, course_hrs, course_time, course_daysScheduled, course_semesterOffered) " +
                                   "VALUES (@course_id, @course_name, @course_hrs, @course_time, @course_daysScheduled, @course_semesterOffered)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@course_id", courseID);
                        command.Parameters.AddWithValue("@course_name", courseName);
                        command.Parameters.AddWithValue("@course_hrs", courseHrs);
                        command.Parameters.AddWithValue("@course_time", courseTime);
                        command.Parameters.AddWithValue("@course_daysScheduled", courseDaysScheduled);
                        command.Parameters.AddWithValue("@course_semesterOffered", courseSemesterOffered);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Course successfully added.");
                        }
                        else
                        {
                            MessageBox.Show("Course not added. Please try again.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding course: {ex.Message}");
            }
        }
    }
}




