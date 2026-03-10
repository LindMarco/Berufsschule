using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Support_Ticket_System
{
    public partial class Ticket_Start : Form
    {
        public Ticket_Start()
        {
            InitializeComponent();
        }
        private void start_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bu_erstellen_Click(object sender, EventArgs e)
        {
            Ticket_Erstellen form2 = new Ticket_Erstellen();
            form2.Show();
            this.Hide();
        }

        private void bu_bearbeiten_Click(object sender, EventArgs e)
        {
            Ticket_Bearbeiten form3 = new Ticket_Bearbeiten();
            form3.Show();
            this.Hide();
        }

        private void bu_administrator_Click(object sender, EventArgs e)
        {
            Ticket_Admin form4 = new Ticket_Admin();
            form4.Show();
            this.Hide();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}