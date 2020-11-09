using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrdersApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace OrdersApp.Helpers
{
    public class SelectListHelper
    {
        // TODO: Refactor it to one method and use Enum as parameter
        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> GetGendersItemsForSelect()
        {
            Client.GenderType[] values = (Client.GenderType[])Enum.GetValues(typeof(Client.GenderType));
            var list = from value in values
                       select new SelectListItem()
                       {
                           Value = ((int)value).ToString(),
                           Text = value.ToString()
                       };
            return list;
        }
        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> GetStatusItemsForSelect()
        {
            Order.StatusTypes[] values = (Order.StatusTypes[])Enum.GetValues(typeof(Order.StatusTypes));
            var list = from value in values
                       select new SelectListItem()
                       {
                           Value = ((int)value).ToString(),
                           Text = value.ToString()
                       };
            return list;
        }
    }
}
