using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Extensions.Configuration;


namespace CrudCoreTest.Data.AppConfig
{
    public class AppConfiguration
    {
        public static string ConnectionString
        {
            get => @"Data Source=MONTAZERI-PC\SQLDEV;Initial Catalog=FatemehMontazeriCoreDb;User Id=sa;Password=1404;";
        }

    }
}
