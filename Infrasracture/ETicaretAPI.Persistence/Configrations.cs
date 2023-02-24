using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence
{
    static class Configrations
    {
        static public string ConnectionString
        {
            get {
                ConfigurationManager configrationManager = new();
                configrationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ETicaretAPI.API"));
                configrationManager.AddJsonFile("appsettings.json");

                return configrationManager.GetConnectionString("PostgreSQL");
            }
        }
    }
}
