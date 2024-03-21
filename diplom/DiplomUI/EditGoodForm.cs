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
    public partial class EditGoodForm : Form
    {
        string id_good;
        List<GoodModel> good = new List<GoodModel>();
        public EditGoodForm(string id_good)
        {
            InitializeComponent();
            this.id_good = id_good;
            GetGood();
        }

        private void GetGood()
        {
            good = DataManager.LoadGood(id_good);

            name_tB.Text = good[0].Name.ToString();
            img_tB.Text = good[0].Img.ToString();
            cost_tB.Text = good[0].Cost.ToString();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DataManager.DeleteGood(id_good);

            Goods_adm form = new Goods_adm();
            form.Show();
            this.Close();
        }

        private void UpdateData()
        {

            GoodModel edit_good = new GoodModel();

            edit_good.Name = name_tB.Text;
            edit_good.Img = img_tB.Text;
            edit_good.Cost = Convert.ToDouble(cost_tB.Text);

            DataManager.UpdateGood(edit_good, id_good);
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            UpdateData();

            Goods_adm form = new Goods_adm();
            form.Show();
            this.Close();
        }
    }
}
