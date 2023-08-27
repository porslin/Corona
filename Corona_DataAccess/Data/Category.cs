using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// there will be multiple products in this website. and all of products will belong to some category. 

// remove .Date from the category namespace
namespace Corona_DataAccess
{
    public class Category
    {
        // use data annotation to explicitly state a primary key. 
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; }

        // here createdDate is used for logging purposes, and not in the web app. 
        public DateTime CreatedDate { get; set; }
    }
}

// when working with realworld apps, the root entity level db objects are not exposed. to expose only the properties that are needed, DTOs are used.

// first create the category table and push it to the db. to do that, create DbContext in the application. EF Core is used to create and manage the db object. 
