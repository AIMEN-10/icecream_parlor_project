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
        public int SaveAdmin( Dictionary<string, object> parameters)
        {
            //String q = $"insert into admin values('{a.username}','{a.email}','{a.password}')";
            int r = mgr.IUDobj("admin1",parameters);
            return r;
        }

        public DataTable loginAdmin(Dictionary<string, object> parameters)
        {
            
            return mgr.Fetchobj("login_5",parameters);

        }
        public int SaveProduct( Dictionary<string, object> parameters)
        {

            //String q = $"insert into product (name,singlep,doublep,familyp,path) " +
            //        $"select '{p.name}','{p.singleP}','{p.doubleP}','{p.familyP}','{p.Path}' " +
            //        $"where '{p.name}' like '%sandwitch%' or " +
            //        $"'{p.name}' like '%sandwitches%' or " +
            //        $"'{p.name}' like '%sundaes%' or" +
            //        $" '{p.name}' like '%sundae%' or" +
            //        $" '{p.name}' like '%stick%' or " +
            //        $"'{p.name}' like '%sticks%' or" +
            //        $" '{p.name}' like '%bar%' or" +
            //        $" '{p.name}' like '%bars%' or" +
            //        $" '{p.name}' like '%sundaes%' or" +
            //        $" '{p.name}' like '%blizzard%' or " +
            //        $"'{p.name}' like '%cups%' or " +
            //        $"'{p.name}' like '%cup%' or " +
            //        $"'{p.name}' like '%cones%' or " +
            //        $"'{p.name}' like '%cone%'  or " +
            //        $"'{p.name}' like '%mochi%' or" +
            //        $" '{p.name}' like '%tacos%' or " +
            //        $"'{p.name}' like '%pie%' or" +
            //        $"'{p.name}' like '%pies%' or" +
            //        $"'{p.name}' like '%bombs%' or" +
            //        $"'{p.name}' like '%macrones%' or" +
            //        $"'{p.name}' like '%popsicles%' or" +

            //        $"'{p.name}' like '%screwballs%'";

            int r =mgr.IUDobj("InsertProduct", parameters);
            return r;
        }
        public DataTable showproduct(Dictionary<string, object> parameters)
        {

            return mgr.Fetchobj("show_product", parameters);

        }
        public int Updateproduct(Dictionary<string, object> parameters)
        {
            //string q = $"UPDATE product SET name = '{p.name}', singleP = '{p.singleP}', doubleP = '{p.doubleP}', familyP = '{p.familyP}', Path = '{p.Path}' WHERE name = '{p.name}'";
            int r = mgr.IUDobj("updateProduct",parameters);
            return r;
        }
        public DataTable blizzard(Dictionary<string, object> parameters)
        {

            //return mgr.Fetch($"SELECT  * FROM product WHERE name like  '%{name}%'");
            return mgr.Fetchobj("fetch_p", parameters);

        }
        //public DataTable diff()
        //{

        //    return mgr.Fetch($"SELECT  * FROM product WHERE name like  '%stick%' or name like '%popsicle%'");

        //}
        public DataTable novelties(Dictionary<string, object> parameters)
        {
            return mgr.Fetchobj("fetch_diff", parameters);
            //return mgr.Fetch($"SELECT  * FROM product WHERE name like  '%macrones%' or name like '%mochi%' or name like '%pies%' or name like '%bombs%' or name like '%tacos%' or name like '%screwballs%'");

        }
        public int delete(Dictionary<string, object> parameters)
        {
            //int r= mgr.IUD($"delete from product where name='{name}'");
            int r = mgr.IUDobj("delETE_PROC", parameters);
            return r;
        }
        public DataTable id(Dictionary<string, object> parameters )
        {
            
            //return mgr.Fetch($"Select top 1 * from orders order by order_id  desc ");
            return mgr.Fetchobj("order_id", parameters);
        }
        public int order(Dictionary<string, object> parameters)
        {
            //String q = $"insert into orders values( '{date}','{id}','{bill}')" ;
            int r = mgr.IUDobj("order_proc1", parameters);
            return r;
        }
        public int order_name(Dictionary<string, object> parameters)
        {
            //string q = $"INSERT INTO ORDERS_list VALUES( '{id}','{val}','{detail}','{quant}' )";
            int r=mgr.IUDobj("o_proc",parameters);
            return r;
        }
        public DataTable AdminView(Dictionary<string, object> parameters)
        {
            return mgr.Fetchobj("admin_display", parameters);

        }
        public DataTable AdminViewOrdername(Dictionary<string, object> parameters)
        {
            //return mgr.Fetch($"Select name,detail,quantity  from orders_list where order_id='{id}'");
            return mgr.Fetchobj("admin_display_det", parameters);

        }

    }
}
