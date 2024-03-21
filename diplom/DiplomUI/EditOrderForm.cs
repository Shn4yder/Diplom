using diplom.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplom
{
    public partial class EditOrderForm : Form
    {
        string id_order;
        List<OrderModel> order = new List<OrderModel>();
        public EditOrderForm(string id_order)
        {
            InitializeComponent();
            this.id_order = id_order;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
