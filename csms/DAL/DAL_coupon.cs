using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_coupon
    {
        DTO_coupon c;

        public DAL_coupon(string couponID, string prodID, int percent )
        {
            c = new DTO_coupon(couponID, prodID, percent);
        }

        public void addQuery()
        {
            string query = "insert into coupon values ('"+ c.couponID + "', '"+ c.prodID + "', "+ c.percent + " )";
            Connection.selectQuery(query);
        }

        public void updateQuery()
        {
            string query = "update coupon set coupon_percent = "+ c.percent + " where coupon_id = '"+ c.couponID + "'";
            Connection.selectQuery(query);
        }

        public void deleteQuery()
        {
            string query = "delete from coupon where coupon_id = '" + c.couponID + "'";
            Connection.selectQuery(query);
        }
        public DataTable selectQuery()
        {
            string s = "SELECT c.coupon_id as 'Coupon ID', p.prod_name as 'Product name', c.coupon_percent as 'Discount percentage'\r\nFROM Coupon c\r\nJOIN product p ON c.prod_id = p.prod_id;";
            return Connection.selectQuery(s);
        }

        public string getCurrentProdID()
        {
            string s = "select top 1 coupon_id from coupon order by coupon_id desc";
            DataTable dt = Connection.selectQuery(s);
            if(dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            return null;
        }

        public DataTable isCouponExist(string id)
        {
            string s = "select * from coupon where prod_id = '" +id+ "'";
            return Connection.selectQuery(s);
        }

        public string getCouponID_byProdName(string prodName)
        {
            // Sử dụng tham số hóa truy vấn để tránh SQL Injection
            string s = "SELECT Coupon.coupon_id FROM Coupon JOIN product ON Coupon.prod_id = product.prod_id WHERE product.prod_name = @prodName";
            SqlParameter[] parameters = { new SqlParameter("@prodName", prodName) };
            DataTable dt = Connection.selectQuery(s, parameters);

            if (dt.Rows.Count == 0)
            {
                return ""; // Không tìm thấy coupon
            }
            return dt.Rows[0][0].ToString(); // Trả về coupon_id đầu tiên

        }

        public int getCouponPercent_byCouponID(string couponID)
        {
            string s = "SELECT coupon_percent FROM Coupon WHERE coupon_id = @couponID";

            // Sử dụng tham số hóa để tránh SQL Injection
            SqlParameter[] parameters = { new SqlParameter("@couponID", couponID) };

            DataTable dt = Connection.selectQuery(s, parameters);

            if (dt.Rows.Count > 0)
            {
                // Chuyển đổi dữ liệu từ DataTable sang int
                return Convert.ToInt32(dt.Rows[0]["coupon_percent"]);
            }
            else
            {
                // Trả về giá trị mặc định nếu không tìm thấy
                return 0;
            }
        }
    }
}
