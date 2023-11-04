
using System.Data;
using System.Data.SqlClient;
using task2_MVC_Famms.Entities;

namespace task2_MVC_Famms.Data
{
    public class ProductData
    {
        private const string Sql_ConnectionString= "Server=WIN-HRJ8B1ML5AG;Database=ProductDb;Trusted_Connection=True";
        public static List<Product> ListProducts()
        {
            SqlConnection connection = null;

            DataSet ds = null;

            List<Product> products = new();

            try
            {
                //berem i sozdaem noviy coonectionString: 
                connection = new SqlConnection(Sql_ConnectionString);
                //nujno vzat tu kommandu, kotoraya nam nujna v SQL(a imenno select * from..)
                SqlCommand command = new SqlCommand("select * from Products_tbl ", connection);

                connection.Open();  

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;

                //creating new Data Set:
                ds=new DataSet();
                da.Fill(ds); //dataAdapter fill Data Set



                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)

                {

                    var  product = new Product();

                    product.Price = Convert.ToDecimal(ds.Tables[0].Rows[i]["Price"].ToString());

                    product.Name = ds.Tables[0].Rows[i]["Name"].ToString();

                    product.ImagePath = ds.Tables[0].Rows[i]["Img_Path"].ToString();
                   

                    products.Add(product);//v list dobavlayem eti products 

                }
            }
            finally
            {
                connection.Close();
            }

            return products;
        }
    }
}
