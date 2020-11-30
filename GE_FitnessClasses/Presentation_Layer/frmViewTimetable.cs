using System;
using System.Windows.Forms;

namespace GE_FitnessClasses
{
    public partial class frmViewTimetable : Form
    {
        frmHome parent;
        public frmViewTimetable(frmHome Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmViewTimetable_Load(object sender, EventArgs e)
        {
            //Populate DataGridView
            string[] row0 = new string[] { "08:00", "Zumba", "HITT", "Kettlebells", "Boxfit", "BodySculpt", "Yoga", "Hot Yoga"};
            string[] row1 = new string[] { "09:00", "Kettlebells", "Boxfit", "Zumba", "HIIT", "Yoga", "Abs and Core", "Pilates" };
            string[] row2 = new string[] { "10:00", "Open Gym", "Open Gym", "Open Gym", "Open Gym", "Open Gym", "Open Gym", "Open Gym" };
            string[] row3 = new string[] { "11:00", "Open Gym", "Open Gym", "Open Gym", "Open Gym", "Open Gym", "Open Gym", "Open Gym" };
            string[] row4 = new string[] { "12:00", "Yoga", "Abs and Core", "Hot Yoga", "BodySculpt", "Aerobics", "HIIT", "Zumba" };
            string[] row5 = new string[] { "13:00", "HIIT", "Hot Yoga", "Aerobics", "Zumba", "Abs and Core", "Kettlebells", "Yoga" };
            string[] row6 = new string[] { "14:00", "Aerobics", "BodySculpt", "Pilates", "Pilates", "Zumba", "Hot Yoga", "Boxfit" };
            string[] row7 = new string[] { "15:00", "Pilates", "Zumba", "HIIT", "Abs and Core", "Kettlebells", "Zumba", "BodySculpt" };
            string[] row8 = new string[] { "16:00", "Boxfit", "Kettlebells", "Abs and Core", "Yoga", "HIIT", "Pilates", "Aerobics" };
            string[] row9 = new string[] { "17:00", "BodySculpt", "Pilates", "Yoga", "Kettlebells", "Pilates", "Boxfit", "HIIT" };
            string[] row10 = new string[] { "18:00", "Hot Yoga", "Yoga", "BodySculpt", "Aerobics", "Hot Yoga", "BodySculpt", "Abs and Core" };
            string[] row11 = new string[] { "19:00", "Abs and Core", "Aerobics", "Boxfit", "Hot Yoga", "Boxfit", "Aerobics", "Kettlebells" };
            string[] row12 = new string[] { "20:00", "Open Gym", "Open Gym", "Open Gym", "Open Gym", "Open Gym", "Open Gym", "Open Gym" };
            string[] row13 = new string[] { "21:00", "Open Gym", "Open Gym", "Open Gym", "Open Gym", "Open Gym", "Open Gym", "Open Gym" };

            object[] timetable = new object[] { row0, row1, row2, row3, row4, row5, row6, row7, row8, row9, row10, row11, row12, row13};

            foreach (string[] rowArray in timetable)
            {
                grdTimetable.Rows.Add(rowArray);
            }

        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            //dispose of this form
            this.Close();

            //show hidden home page
            parent.Visible = true;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
