using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WA.CRM.db;

namespace WA.CRM.Models
{
    public class AdminListModel
    {
        private MVCTestEntities entities = new MVCTestEntities();

        List<AdminModel> admins = new List<AdminModel>();
    }
}