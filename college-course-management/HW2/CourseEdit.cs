using System;
using System.Globalization;
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
            PopulateSemesterBox();
            PopulateTimeComboBox(); 
        }

  

        public void LoadGrid(DataGridView dataGrid)
        {
            try
            {
                dataGrid.DataSource = DatabaseHelper.GetAllCourses();
                dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                dataGrid.ScrollBars = ScrollBars.Both;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading courses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTextBox(object sender, EventArgs e)
        {
            courseIdtextbox.Clear();
            titleCoursetextbox.Clear();
            totalCoursehrsbox.Clear();
            courseTimeBox.SelectedIndex = -1; 
            semesterOfferedComboBox.SelectedIndex = -1; 

            for (int i = 0; i < Days_CheckedListBox.Items.Count; i++)
            {
                Days_CheckedListBox.SetItemChecked(i, false);
            }
        }

        private bool IsTimeValid(string time)
        {
            string[] formats = { "h:mm tt", "hh:mm tt" };
            return DateTime.TryParseExact(
                time,
                formats,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out _
            );
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(courseIdtextbox.Text) ||
                string.IsNullOrWhiteSpace(titleCoursetextbox.Text) ||
                string.IsNullOrWhiteSpace(totalCoursehrsbox.Text) ||
                string.IsNullOrWhiteSpace(courseTimeBox.Text) ||
                Days_CheckedListBox.SelectedItems.Count == 0 ||
                semesterOfferedComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            if (!int.TryParse(totalCoursehrsbox.Text, out int courseHours))
            {
                MessageBox.Show("Invalid course hours.");
                return;
            }

            if (!IsTimeValid(courseTimeBox.Text))
            {
                MessageBox.Show("Invalid time format. Use hh:mm AM/PM.");
                return;
            }

            string selectedSemester = semesterOfferedComboBox.SelectedItem.ToString();

            DatabaseHelper.AddCourse(
                courseIdtextbox.Text,
                titleCoursetextbox.Text,
                courseHours,
                courseTimeBox.Text,
                Days_CheckedListBox.Text,
                selectedSemester
            );

            LoadGrid(courseDataGrid);
            ClearTextBox(sender, e);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedCourseId))
            {
                DatabaseHelper.DeleteCourseInDatabase(selectedCourseId);
                LoadGrid(courseDataGrid);
            }
        }

        private void courseDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedCourseId = courseDataGrid.Rows[e.RowIndex].Cells["course_id"].Value.ToString();
            }
        }

        private void PopulateSemesterBox()
        {
            int nextYear = DateTime.Now.Year + 1;
            semesterOfferedComboBox.Items.Clear();
            semesterOfferedComboBox.Items.Add($"Spring {nextYear}");
            semesterOfferedComboBox.Items.Add($"Summer {nextYear}");
            semesterOfferedComboBox.Items.Add($"Fall {nextYear}");
            semesterOfferedComboBox.SelectedIndex = 0;
        }

        private void PopulateTimeComboBox()
        {
            courseTimeBox.Items.Clear(); 
            for (int hour = 1; hour <= 12; hour++)
            {
                courseTimeBox.Items.Add($"{hour}:00 AM");
                courseTimeBox.Items.Add($"{hour}:30 AM");
                courseTimeBox.Items.Add($"{hour}:00 PM");
                courseTimeBox.Items.Add($"{hour}:30 PM");
            }
            courseTimeBox.DropDownStyle = ComboBoxStyle.DropDownList; 
            courseTimeBox.SelectedIndex = 0; 
        }







 

    }
}
