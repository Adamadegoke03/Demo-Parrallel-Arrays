namespace Demo_Parrallel_Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // we can changr colors programatically!
            lblGrade.BackColor = Color.Orchid;
        }
        //class level arrays to hold student data
        //multiple collections with indexes being linked
        int[] ids = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 13 };
        string[] students = { "Aaron", "cathy", "Bob", "sue", "George", "Jerry", "Elaine", "kramer", "Mike", "Eleanor" };
        int[] grades = { 44, 99, 65, 89, 60, -12, -10, 56, 34, 35 };

        //Event to handle a search based on the data the user provides
        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool found = false; //did we find the student?
            //blank the label first
            lblGrade.Text = "";
            //Search by name or ID
            int.TryParse(txtStudent.Text, out int id);
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].ToLower() == txtStudent.Text.ToLower() || ids[i] == id)
                {
                    lblGrade.Text = grades[i].ToString();
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                MessageBox.Show("No student natching the name or id of " + txtStudent.Text, "Data not found");
            }

    }
}
