using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;


namespace GNB.Infraestructure.Data
{
    public class DataBaseInitializer
    {
        private readonly GNBProductsContext _GNBProductsContext;
        private readonly DbInitializerSettings _DbInitializerSettings;

        public DataBaseInitializer(GNBProductsContext gnbProductsContext, ILoggerFactory loggerFactory, DbInitializerSettings dbInitializerSettings) 
        {
            _GNBProductsContext = gnbProductsContext;
            _DbInitializerSettings = dbInitializerSettings;
        }

        public void Initialize() 
        {
            
        }



    }
}
