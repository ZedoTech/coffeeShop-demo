using coffeeShop.Shared;
using System.Data;
using System.Data.SqlClient;

namespace coffeeShop.DBAccess
{
    public class SampleDb
    {
        public static DataTable GetStore()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(GlobalConst.DefaultConnection))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Store", conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return dt;
        }
    }
}
