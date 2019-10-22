//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using SmartRetailSystem.Models;

//namespace SmartRetailSystem.BusinessLayer
//{
//    public class BusinessFacade
//    {
//        internal ShopsModel SingleShopItems(int theshopID, int theprodID)
//        {
//            using (var shopItems = new SRSDatabaseEntities())
//            {

//                var shoid = shopItems.Shops.FirstOrDefault(x => x.ShopID == Convert.ToString(theshopID));
//                var prodid = shopItems.Products.FirstOrDefault(x => x.ProID == Convert.ToString(theprodID));

//                return shoid == null ? null : new ShopsModel
//                {
//                    ShopID = shoid.ShopID,
//                    ShopDescription = shoid.ShopDescription,
//                };

//            }

//        }
//    }
//}