using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linqwin
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data source=store.db;Version=3";

        private List<OrderItem> onlineOrders = new List<OrderItem>();
        public Form1()
        {
            InitializeComponent();
            btnCalcAggregates.Click += btnCalcAggregates_Click;
            
        }

        private void btnCalcAggregates_Click(object sender, EventArgs e)
        {

        }
    }
}
