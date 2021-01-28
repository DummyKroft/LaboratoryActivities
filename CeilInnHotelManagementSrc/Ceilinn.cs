using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CeilInnHotelManagement
{
    public partial class Ceilinn : Form
    {
        public Ceilinn()
        {
            InitializeComponent();
        }

        private void Ceilinn_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"C:\Microsoft Visual C# Application Design\Ceil Inn");
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customers clients = new Customers();
            clients.ShowDialog();
        }

        private void btnOccupancies_Click(object sender, EventArgs e)
        {
            Occupancies rentals = new Occupancies();
            rentals.ShowDialog();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            Rooms rms = new Rooms();
            rms.ShowDialog();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            Payments pmts = new Payments();
            pmts.Show();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            Employees staff = new Employees();
            staff.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
