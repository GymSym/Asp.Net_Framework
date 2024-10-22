using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Asp.Net_Framework.Data
{
    public class AspNet_FrameworkContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public AspNet_FrameworkContext() : base("name=AspNet_FrameworkContext")
        {
        }

        public System.Data.Entity.DbSet<Asp.Net_Framework.Models.Contact> Contacts { get; set; }
    }
}
