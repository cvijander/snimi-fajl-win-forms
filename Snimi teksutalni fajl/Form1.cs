namespace Snimi_teksutalni_fajl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void snimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Tekst (*.txt)|*.txt| Web stranica(*.html|*.html)";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string sadrzaj = richTextBox1.Text;
                string lokacija = sfd.FileName;
                File.WriteAllText(lokacija, sadrzaj);
                MessageBox.Show("Dokument je uspesno sacuvan");
            }
        }
    }
}