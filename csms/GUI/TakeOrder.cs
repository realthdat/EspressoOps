﻿using BUS;
using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class takeOrder : Form
    {
        private string username;
        private string rid; //receipt id
        private float totalAmount = 0;
        private string deleteProduct = "";
        private string deletePrice = "";
        private int deleteQuantity = 0;
        private int totalQuantity = 0;
        public takeOrder(string username)
        {
            this.username = username;
            InitializeComponent();
            refreshData();
            cbLoading();

            btnAdd.Enabled = false;
        }



        //------------------------utilities------------------------
        public void cbLoading()
        {
            //Type
            SearchCbType.Items.Add("Coffee");
            SearchCbType.Items.Add("Tea");
            SearchCbType.Items.Add("Cold Brew");


            //payment method
            cbPayment.Items.Add("Cash");
            cbPayment.Items.Add("Card");

        }


        private bool isEmpty()
        {
            return false;
        }

        private void refreshGRD()
        {
            showGRD();
        }

        private void showGRD()
        {
            BUS_product b = new BUS_product("", "", "", "0", "", "");
            grdProd.DataSource = b.selectQuery();


        }

        private void showGRD_order()
        {
            BUS_order order = new BUS_order(rid, "", "", 0, "");
            grdOrder.DataSource = order.selectQuery();
        }



        internal void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            showGRD();
            gbProd.Enabled = false;
            btnCreate_order.Enabled = true;
            btnAdd.Enabled = false;
            btnClear.Enabled = false;
            btnDel.Enabled = false;
            btnPDF.Enabled = false;
            tbDiscount.Enabled = false;

        }

        private void resetForm()
        {
            showGRD();
            btnAdd.Enabled = false;
            btnClear.Enabled = false;
            btnDel.Enabled = false;
            btnPDF.Enabled = false;
            tbDiscount.Enabled = false;
            tbMem.Text = "";
            tbDiscount.Text = "";
            tbMem.Enabled = true;
            grdOrder.DataSource = null;
            btnCreate_order.Enabled = true;
            totalmoney.Text = "$0";
            //attr
            rid = ""; //receipt id
            totalAmount = 0;
            deleteProduct = "";
            deletePrice = "";
            deleteQuantity = 0;
            totalQuantity = 0;
        }


        //------------------------data grid view handling------------------------

        private void grdProd_CellClick(object sender, DataGridViewCellEventArgs e) //product info
        {

            //grid view
            tbProdName.Text = grdProd.CurrentRow.Cells[1].Value.ToString();
            tbPrice.Text = grdProd.CurrentRow.Cells[3].Value.ToString();
            tbQuantity.Value = 1;

            //--img
            string imagePath = grdProd.CurrentRow.Cells[5].Value.ToString();
            if (File.Exists(imagePath))
            {
                ProdIMG.Image = System.Drawing.Image.FromFile(imagePath);
            }
            else
            {
                ProdIMG.Image = null;
            }
        }


        private void grdOrder_CellClick(object sender, DataGridViewCellEventArgs e) //order info
        {
            deleteProduct = grdOrder.CurrentRow.Cells[0].Value.ToString();
            deleteQuantity = int.Parse(grdOrder.CurrentRow.Cells[1].Value.ToString());
            deletePrice = grdOrder.CurrentRow.Cells[2].Value.ToString();
            btnDel.Enabled = true;
        }


        //------------------------button handling------------------------

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float price = float.Parse(tbPrice.Text, CultureInfo.InvariantCulture); // Sử dụng CultureInfo.InvariantCulture để tránh lỗi định dạng
            string name = tbProdName.Text;
            int quantity = Convert.ToInt32(tbQuantity.Value);
            totalQuantity += quantity;

            // Lấy prodID bằng tên sản phẩm
            BUS_product b = new BUS_product("", "", "", "0", "", "");
            string prodID = b.getProdID_by_prodName(name);

            // Lấy couponID theo tên sản phẩm
            BUS_coupon coupon = new BUS_coupon("", "", 0);
            string couponID = coupon.getCouponID_byProdName(name);

            float finalPrice = price * quantity; // Giá cuối cùng mặc định
            if (!string.IsNullOrEmpty(couponID))
            {
                int couponPercent = coupon.getCouponPercent_byCouponID(couponID);

                // Đảm bảo couponPercent nằm trong khoảng hợp lý (0-100)
                if (couponPercent < 0 || couponPercent > 100)
                {
                    MessageBox.Show("Invalid coupon percent value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    couponPercent = 0; // Đặt giá trị mặc định
                }

                // Tính giá sau khi giảm giá
                finalPrice = price * quantity * (1 - couponPercent / 100.0f);
            }
            else
            {
                // Nếu không có coupon, giá không giảm
                finalPrice = price * quantity;
            }

            // Thêm sản phẩm vào đơn hàng
            BUS_order newOrder = new BUS_order(rid, couponID, prodID, quantity, finalPrice.ToString("0.00", CultureInfo.InvariantCulture));
            newOrder.addQuery();

            // Cập nhật tổng số tiền
            totalAmount += finalPrice;
            totalmoney.Text = $"${totalAmount.ToString("0.00", CultureInfo.InvariantCulture)}";

            // Hiển thị thông tin đơn hàng
            showGRD_order();

        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            BUS_order newOrder = new BUS_order(rid, "", "", 0, "");
            newOrder.deleteQueryAll();
            totalmoney.Text = "$0";
            totalAmount = 0;
            totalQuantity = 0;
            showGRD_order();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu thông tin cần xóa rỗng
            if (string.IsNullOrEmpty(deleteProduct) || deleteQuantity <= 0 || string.IsNullOrEmpty(deletePrice))
            {
                MessageBox.Show("Please select a valid item to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lấy prodID của sản phẩm cần xóa
                BUS_product b = new BUS_product("", "", "", "0", "", "");
                string deleteID = b.getProdID_by_prodName(deleteProduct);

                // Thực hiện xóa sản phẩm trong đơn hàng
                BUS_order newOrder = new BUS_order(rid, "", deleteID, 0, "");
                newOrder.deleteQuery();

                // Tính toán lại tổng tiền
                float itemPrice = float.Parse(deletePrice, CultureInfo.InvariantCulture); // Chuyển đổi giá sang float
                totalAmount -= itemPrice;
                totalQuantity -= deleteQuantity;

                // Cập nhật giao diện
                totalmoney.Text = $"${totalAmount.ToString("0.00", CultureInfo.InvariantCulture)}";
                showGRD_order();

                // Reset các thông tin của sản phẩm bị xóa
                deleteProduct = "";
                deletePrice = "";
                deleteQuantity = 0;
                btnDel.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {

            if (cbPayment.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose payment method", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //update accu for membership
            float NEWtotalAmount;
            if (tbMem.Text != "") //have membership
            {
                NEWtotalAmount = totalAmount - totalAmount * (float.Parse(tbDiscount.Text) * 0.01f);
                totalAmount = NEWtotalAmount;
                BUS_membership m = new BUS_membership("", "", "", "", 0, "");

                string memid = m.findMembership(tbMem.Text);
                BUS_membership membership = new BUS_membership(memid, "", "", "", 0, "");
                float newAccu = float.Parse(membership.getAccu()) + totalAmount;
                membership.updateAccu(newAccu.ToString().Replace(",", "."));
                membership.checkRank();

            }


            string total_amount = totalAmount.ToString().Replace(",", ".");

            //update a receipt
            BUS_receipt receipt = new BUS_receipt(rid, "", "", "", cbPayment.Text, total_amount, totalQuantity);
            receipt.updateQuery();


            MessageBox.Show("Payment Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resetForm();

        }

        private void btnCreate_order_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;

            string memID = ""; //customer phone number
            if (tbMem.Text.Length > 0)
            {
                BUS_membership m = new BUS_membership("", "", "", "", 0, "");
                memID = m.findMembership(tbMem.Text); //finding membership customer by numberphone
                if (memID == null)
                {
                    MessageBox.Show("This phone number hasn’t been registered yet!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (memID == "0")
                {
                    tbDiscount.Text = "0";
                }
                else
                {
                    tbDiscount.Text = m.findDiscount(memID);
                }
            }
            else
            {
                memID = null;
            }



            //get staff name by username
            BUS_STAFF b = new BUS_STAFF("", "", "", "", "", "", "");
            string staffid = b.getStaffid(username);
            //get date
            DateTime currentDateTime = DateTime.Now;

            string format_Datetime = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            //create a receipt
            BUS_receipt r = new BUS_receipt("", "", "", "", "", "0.0", 0);
            rid = r.auto_generateReceiptID();


            BUS_receipt receipt = new BUS_receipt(rid, staffid, memID, format_Datetime, "", "0.0", 0);
            receipt.addQuery();

            tbMem.Enabled = false;
            gbProd.Enabled = true;
            btnClear.Enabled = true;
            tbProdName.Enabled = false;
            tbPrice.Enabled = false;
            btnCreate_order.Enabled = false;
            showGRD_order();
        }


        //Searching
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            refreshGRD();
        }

        private void FilterProducts(string selectType, string searchText)
        {
            BUS_product p = new BUS_product("", "", "", "", "", "");
            DataTable filterProducts = p.FilterProducts(selectType, searchText);
            grdProd.DataSource = filterProducts;
        }

        private void SearchTbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string selectedType = SearchCbType.SelectedItem?.ToString();
                string searchText = SearchTbName.Text.Trim();

                // Call a method to filter products based on the selected type and search text
                FilterProducts(selectedType, searchText);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;

            BUS_receipt r = new BUS_receipt(rid, "", "", "", "", "0.0", 0);
            DAL_order o = new DAL_order(rid, "", "", 0, "");

            o.deleteQueryAll();
            r.deleteQuery();

            resetForm();
        }

        private void SearchCbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = SearchCbType.SelectedItem?.ToString();
            string searchText = SearchTbName.Text.Trim();

            // Call a method to filter products based on the selected type and search text
            FilterProducts(selectedType, searchText);
        }

        private void grdProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gbSearch_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = SearchTbName.Text.Trim();

            BUS_product p = new BUS_product("", "", "", "", "", "");
            DataTable Products = p.searchByName(name);
            grdProd.DataSource = Products;
        }
    }
}
