using System;
using System.Linq;
using System.Windows.Forms;




namespace CollegeCourseManagement
{
    public partial class CourseEdit : UserControl
    {


        private string selectedCourseId;

        public CourseEdit()
        {
            InitializeComponent();
            LoadGrid(courseDataGrid);

        }

        private void Form1_Load(object sender, EventArgs e)
        {




        }
        public void LoadGrid(DataGridView dataGrid)
        {
            try
            {
                dataGrid.DataSource = DatabaseHelper.GetAllCourses();
                dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                dataGrid.ScrollBars = ScrollBars.Both; // Optional: Add scrollbars for better UX
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading courses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void ClearTextBox(object sender, EventArgs e)
        {
            courseIdtextbox.Clear();
            titleCoursetextbox.Clear();
            totalCoursehrsbox.Clear();
            semesterOfferedbox.Clear();
            timeOfclassbox.Clear();

            for (int i = 0; i < Days_CheckedListBox.Items.Count; i++)
            {
                Days_CheckedListBox.SetItemChecked(i, false);
            }
        }




  

        private void AddButton_Click(object sender, EventArgs e)
        {
          DatabaseHelper.AddCourse(
          courseIdtextbox.Text,             // course_id
          titleCoursetextbox.Text,          // course_name
          int.Parse(totalCoursehrsbox.Text), // course_hrs
          timeOfclassbox.Text,              // course_time
          Days_CheckedListBox.Text,         // course_daysScheduled
          semesterOfferedbox.Text           // course_semesterOffered
      );
            LoadGrid(courseDataGrid);

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedCourseId))
            {

                DatabaseHelper.DeleteCourseInDatabase(selectedCourseId);
               
                LoadGrid(courseDataGrid); // Refresh the grid

            }
        }




        private void courseDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Retrieve the selected course ID from the clicked row
                selectedCourseId = courseDataGrid.Rows[e.RowIndex].Cells["course_id"].Value.ToString();
            }
        }
    }
    }


