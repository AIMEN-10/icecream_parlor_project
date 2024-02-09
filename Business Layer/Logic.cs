using Business_Layer;
using DataAccess_Layer;
using icecream_parlor_project;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Business_layer
{
    public class Logic
    {
        DBManager mgr = new DBManager();
        public int SaveAdmin(Admin a)
        {
            String q = $"insert into admin values('{a.username}','{a.email}','{a.password}')";
            int r = mgr.IUD(q);
            return r;
        }

        public DataTable loginAdmin(string username)
        {

            return mgr.Fetch($"SELECT  * FROM admin WHERE username = '{username}'");

        }
        public int SaveProduct(Product p)
        {

            String q = $"insert into product (name,singlep,doublep,familyp,path) " +
                    $"select '{p.name}','{p.singleP}','{p.doubleP}','{p.familyP}','{p.Path}' " +
                    $"where '{p.name}' like '%sandwitch%' or " +
                    $"'{p.name}' like '%sandwitches%' or " +
                    $"'{p.name}' like '%sundaes%' or" +
                    $" '{p.name}' like '%sundae%' or" +
                    $" '{p.name}' like '%stick%' or " +
                    $"'{p.name}' like '%sticks%' or" +
                    $" '{p.name}' like '%bar%' or" +
                    $" '{p.name}' like '%bars%' or" +
                    $" '{p.name}' like '%sundaes%' or" +
                    $" '{p.name}' like '%blizzard%' or " +
                    $"'{p.name}' like '%cups%' or " +
                    $"'{p.name}' like '%cup%' or " +
                    $"'{p.name}' like '%cones%' or " +
                    $"'{p.name}' like '%cone%'  or " +
                    $"'{p.name}' like '%mochi%' or" +
                    $" '{p.name}' like '%tacos%' or " +
                    $"'{p.name}' like '%pie%' or" +
                    $"'{p.name}' like '%pies%' or" +
                    $"'{p.name}' like '%bombs%' or" +
                    $"'{p.name}' like '%macrones%' or" +
                    $"'{p.name}' like '%popsicles%' or" +

                    $"'{p.name}' like '%screwballs%'";

            int r =mgr.IUD(q);
            return r;
        }
        public DataTable showproduct(string prod_name)
        {

            return mgr.Fetch($"SELECT  * FROM product WHERE name = '{prod_name}'");

        }
        public int Updateproduct(Product p)
        {
            string q = $"UPDATE product SET name = '{p.name}', singleP = '{p.singleP}', doubleP = '{p.doubleP}', familyP = '{p.familyP}', Path = '{p.Path}' WHERE name = '{p.name}'";
            int r = mgr.IUD(q);
            return r;
        }
        public DataTable blizzard(string name)
        {

            return mgr.Fetch($"SELECT  * FROM product WHERE name like  '%{name}%'");

        }
        public DataTable diff()
        {

            return mgr.Fetch($"SELECT  * FROM product WHERE name like  '%stick%' or name like '%popsicle%'");

        }
        public DataTable novelties()
        {

            return mgr.Fetch($"SELECT  * FROM product WHERE name like  '%macrones%' or name like '%mochi%' or name like '%pies%' or name like '%bombs%' or name like '%tacos%' or name like '%screwballs%'");

        }
        public int delete(string name)
        {
            int r= mgr.IUD($"delete from product where name='{name}'");
            return r;
        }
        public DataTable id()
        {
                return mgr.Fetch($"Select top 1 * from orders order by order_id  desc ");
            
        }
        public int order(DateTime date,int id, int bill)
        {
            String q = $"insert into orders values( '{date}','{id}','{bill}')" ;
            int r = mgr.IUD(q);
            return r;
        }
        public int order_name(int id,string val,string detail,int quant)
        {
            string q = $"INSERT INTO ORDERS_list VALUES( '{id}','{val}','{detail}','{quant}' )";
            int r=mgr.IUD(q);
            return r;
        }
        public DataTable AdminView()
        {
            return mgr.Fetch($"Select order_time,order_id  from orders ");

        }
        public DataTable AdminViewOrdername(int id)
        {
            return mgr.Fetch($"Select name,detail,quantity  from orders_list where order_id='{id}'");

        }

    }
}
