using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeCourseManagement
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            CourseEdit courseEditControl = new CourseEdit();
            tabPage3.Controls.Add(courseEditControl);
            courseEditControl.Dock = DockStyle.Fill;
        }
    }
}
