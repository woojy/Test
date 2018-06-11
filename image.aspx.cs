using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace metoo1
{
    public partial class image : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_Click(object sender, EventArgs e)
        {

            string Image = Request.Form["Image"];
            int ImageNo= 0;
            aa.Text = Image;  
            string connectionString = "Data Source=10.96.124.87,1433;Initial Catalog=metoo;Persist Security Info=True;User ID=sa;Password=metoo";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO IMAGE VALUES(@ImageNo,@ImageName, @ImageSize);", conn)) //imageNo는 기본키
                    {
                        cmd.Parameters.AddWithValue("@ImageNo", ImageNo);
                        cmd.Parameters.AddWithValue("@ImageName", Image);
                        cmd.Parameters.AddWithValue("@ImageSize", 5);

                        int row = cmd.ExecuteNonQuery();
                        dbcheck.Text = "연결완료!";
                    }
                    conn.Close();
                }
            }
            catch (SqlException ex)
            {
                dbcheck.Text = ex.Message;
            }
        }
    }
}