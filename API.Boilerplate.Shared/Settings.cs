using System;
using System.Collections.Generic;
using System.Text;

namespace API.Boilerplate.Shared
{
    public class Settings
    {
        private static string connectionString = "Data Source=.;Initial Catalog=YouLearnCurso; persist security info=True;Integrated Security=SSPI;";

        public static string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
    }
}
