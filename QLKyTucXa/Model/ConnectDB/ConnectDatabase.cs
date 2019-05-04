using Model.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ConnectDB
{
  public  class ConnectDatabase
    {
        public QLKyTucXaDbContext db { get; set; }
        
        public ConnectDatabase()
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
            //EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();
            //entityBuilder.Provider = @"System.Data.SqlClient";
            //entityBuilder.ProviderConnectionString = 
            ////entityBuilder.Metadata = @"res://*";
           // entityBuilder.Metadata = @"res://*/EF.QLKyTucXaDbContext.csdl|res://*/EF.QLKyTucXaDbContext.ssdl|res://*/EF.QLKyTucXaDbContext.msl";
            db = new QLKyTucXaDbContext(@"data source=MYLINH\MYLINH;initial catalog=QuanLyKiTucXa;integrated security=True;MultipleActiveResultSets=True");
        }
    }
}
