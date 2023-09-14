using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace netweb.Models
{
    public class DbConn
    {
        private readonly string _ConnStr 
=ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
    }
}