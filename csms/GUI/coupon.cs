using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace GUI
{
    public partial class coupon : Form
    {

        private string selectedProductID = ""; // ID sản phẩm được chọn
        private int operationMode = 0; // 1: Add, 2: Edit

        public coupon()
        {
            InitializeComponent();
        }
        public void cbLoading()
        {
            SearchCbType.Items.Add("Coffee");
            SearchCbType.Items.Add("Tea");
            SearchCbType.Items.Add("Cold Brew");
        }

        internal void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            refreshGRD();
            cbLoading();
        }

        private void clearField()
        {
            tbID.Text = "";
            tbName.Text = "";
            tbDiscount.Text = "";
        }

        private void refreshGRD()
        {
            showGRD();
            gb1.Enabled = false;
            btnSave.Enabled = false;
            btnDel.Enabled = false;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;

        }

        //------data grid view
        public void showGRD()
        {
            BUS_product b = new BUS_product("", "", "", "0", "", "");
            grdProd.DataSource = b.selectProdCoupon();

            BUS_coupon c = new BUS_coupon("", "", 0);
            grdCoupon.DataSource = c.selectQuery();

        }

        private void grdProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clearField();
            btnAdd.Enabled = true;
            tbName.Text = grdProd.CurrentRow.Cells[1].Value.ToString();
            selectedProductID = grdProd.CurrentRow.Cells[0].Value.ToString();
        }
        private void grdCoupon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Enabled = false;
            btnDel.Enabled = true;
            btnEdit.Enabled = true;

            tbID.Text = grdCoupon.CurrentRow.Cells[0].Value.ToString();
            tbName.Text = grdCoupon.CurrentRow.Cells[1].Value.ToString();
            tbDiscount.Text = grdCoupon.CurrentRow.Cells[2].Value.ToString();
        }

        //button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            gb1.Enabled = true;
            tbID.Enabled = false;
            tbName.Enabled = false;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            tbDiscount.Focus();
            tbDiscount.Enabled = true;
            BUS_coupon c = new BUS_coupon("", "", 0);
            tbID.Text = c.auto_generateProdID();
            operationMode = 1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            gb1.Enabled = true;
            tbID.Enabled = false;
            btnEdit.Enabled = false;
            tbName.Enabled = false;
            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            btnSave.Enabled = true;
            tbDiscount.Focus();
            tbDiscount.Enabled = true;
            operationMode = 2;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this coupon?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                BUS_coupon c = new BUS_coupon(tbID.Text, "", 0);
                c.deleteQuery();
                MessageBox.Show("Delete Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            refreshGRD();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!ValidateFields()) return;

            var couponBUS = new BUS_coupon(tbID.Text, selectedProductID, int.Parse(tbDiscount.Text));

            if (operationMode == 1) // Thêm mới
            {
                if (couponBUS.isCouponExist(selectedProductID).Rows.Count > 0)
                {
                    MessageBox.Show("This product already has a coupon!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                couponBUS.addQuery();
                MessageBox.Show("Added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (operationMode == 2) // Cập nhật
            {
                couponBUS.updateQuery();
                MessageBox.Show("Updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            refreshData();
        }


        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(tbDiscount.Text))
            {
                MessageBox.Show("Discount percentage is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbDiscount.Focus();
                return false;
            }

            if (!int.TryParse(tbDiscount.Text, out int discount) || discount <= 0 || discount > 100)
            {
                MessageBox.Show("Discount must be between 1% and 100%.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbDiscount.Focus();
                return false;
            }

            return true;
        }

        private void SearchCbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            BUS_product b = new BUS_product("", "", "", "0", "", "");
            grdProd.DataSource = b.FilterProductsByType(SearchCbType.SelectedItem?.ToString() ?? "");
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            BUS_product b = new BUS_product("", "", "", "0", "", "");
            grdProd.DataSource = b.selectQuery();
        }
    }
}
