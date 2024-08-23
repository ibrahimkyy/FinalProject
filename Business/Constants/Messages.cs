using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants//sabit damek proje sabitleri metinler gibi
{
    public static class Messages//sürekli newlememek için static verdik
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        internal static string MaintenanceTime = "Sistem Bakımda";
        internal static string ProductsListed="Ürünler Listelendi";
    }
}
