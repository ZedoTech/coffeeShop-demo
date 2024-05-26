using coffeeShop.DBAccess;
using coffeeShop.Models;
using System.Data;

namespace coffeeShop.Providers
{
    public class DataProvider
    {
        public static List<StoreDTO> GetStore()
        {
            var dt = SampleDb.GetStore();
            var list = new List<StoreDTO>();
            foreach (DataRow row in dt.Rows)
            {
                var id = Convert.ToInt64(row["Id"]);
                var openDate = row["OpenDate"].ToString();
                var openTime = row["OpenTime"].ToString();

                var store = new StoreDTO
                {
                    Id = id,
                    OpenDate = openDate,
                    OpenTime = openTime
                };

                list.Add(store);
            }
            return list;
        }
    }
}
