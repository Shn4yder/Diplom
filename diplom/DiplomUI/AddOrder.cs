﻿using diplom.Models;
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
    public partial class AddOrder : Form
    {
        string id_user, status, name_usr;
        public AddOrder(string id_user, string status, string name_usr)
        {
            InitializeComponent();
            this.id_user = id_user;
            this.status = status;
            this.name_usr = name_usr;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Orders ord_frm = new Orders(id_user, status, name_usr);
            ord_frm.Show();
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            OrderModel new_order = new OrderModel();

            new_order.Number = numb_tB.Text;
            new_order.Name = name_tB.Text;
            new_order.Counter = Convert.ToInt16(ppl_UpDown.Value);
            new_order.Time_start = DateTime.Now.ToString();
            new_order.Comment = comment_tB.Text;
            new_order.Id_user = Convert.ToInt16(id_user);

            AddNewOrder(new_order);

            this.Close();
            Orders ord_frm = new Orders(id_user, status, name_usr);
            ord_frm.Show();
        }

        private void AddNewOrder(OrderModel order)
        {
            DataManager.AddOrder(order);
        }
    }
}
