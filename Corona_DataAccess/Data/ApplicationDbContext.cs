using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corona_DataAccess.Data
{
    // in order to use EF Core, the EF must use the DbContext. Change class to public. 
    public class ApplicationDbContext : DbContext
    {
        // to configure EF Core, create a ctor inside the ApplicationDbContext. Within the ctor receive the DbContextOptions. This options will be on the class ApplicationDbContext. Then pass them to the base class of DbContext.
        // so wtv options which has a connectionstring that was received when this class was instantiated, that needs to be passed to DbContext. 
        // this is the default config that is needed with DbContext.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        // now, create a category table in the db. So write DbSet of class CAtegory. and name it categories. this will create a table with the name of categories. 
        public virtual DbSet<Category> Categories { get; set; }
        

        // to create a table, you need to create a SQL server adn establish a connection
    }
}
