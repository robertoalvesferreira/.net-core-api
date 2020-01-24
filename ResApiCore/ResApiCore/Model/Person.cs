using ResApiCore.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResApiCore.Model
{
    public class Person : BaseEntity
    {
        //public long? Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        public long? Profile_id { get; set; }

     
    }


}
