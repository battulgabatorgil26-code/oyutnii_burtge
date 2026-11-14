namespace oyutnii_burtge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            private void Form1_Load(object sender, EventArgs e)
        {
            // Хэлний жагсаалт
            lstLanguage.Items.AddRange(new string[]
            {
        "Монгол",
        "Англи",
        "Орос",
        "Хятад",
        "Япон",
        "Солонгос"
            });

            lstLanguage.SelectedIndex = 0;

            // Тэнхим
            cmbDepartment.Items.AddRange(new string[]
            {
        "Мэдээллийн технологи",
        "Компьютерийн ухаан",
        "Программ хангамж",
        "Байгалийн ухаан"
            });
        }
        }

        private void AddLine(string label, string value)
        {
            rtbInfo.SelectionFont = new Font("Segoe UI", 10, FontStyle.Bold);
            rtbInfo.SelectionColor = Color.Black;
            rtbInfo.AppendText(label);
            rtbInfo.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            rtbInfo.SelectionColor = Color.DarkGreen;
            rtbInfo.AppendText(value + "\n");
        }

        private void picPhoto_Click(object sender, EventArgs e)
        {
            if (ofdPhoto.ShowDialog() == DialogResult.OK)
            {
                picPhoto.Image = Image.FromFile(ofdPhoto.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
}
