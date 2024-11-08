namespace Database_forms_app_project
{
    public partial class Form1 : Form
    {
        bool form2showing = false;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void bntForm2_Click(object sender, EventArgs e)
        {
            if (form2showing){
                MessageBox.Show("Already open");
            }else
            {
                Form form2 = new Form2();
                form2.Show();
                form2showing = true;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Button bntForm2 = new Button()
            {
                Location = new Point(60, 50),
            BackColor = Color.Thistle,
                Text = "Insert values into table.",
            };
            bntForm2.Size = new Size(200, 50);
            Controls.Add(bntForm2);
            bntForm2.Click += bntForm2_Click;
        }
    }
}