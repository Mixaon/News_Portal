using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Data.Entity;

namespace NewsPortal.Models
{
    public class NewsContext : DbContext
    {
        public DbSet<News> _News { get; set; }
    }
}