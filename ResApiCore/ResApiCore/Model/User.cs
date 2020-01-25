using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ResApiCore.Model
{
    //Contrato entre atributos
    //e a estrtura da tabela
    //[DataContract]
    public class User
    {

        public long? Id { get; set; }
        public string Login { get; set; }
        public string AccessKey { get; set; }
    }
}
