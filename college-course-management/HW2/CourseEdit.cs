using System;
using System.Linq;
using System.Windows.Forms;
using CollegeCourseDLL;




namespace CollegeCourseManagement
{
    public partial class CourseEdit : UserControl
    {
        

        

        public CourseEdit()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          



        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void ClearTextBox(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            
            textBox5.Clear();
            
            for (int i = 0; i < Days_CheckedListBox.Items.Count; i++)
            {
                Days_CheckedListBox.SetItemChecked(i, false);
            }
        }

       


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                CollegeCourseDLL.CollegeCourse.DeleteCourse(textBox1.Text);
                MessageBox.Show("Course Removed");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
