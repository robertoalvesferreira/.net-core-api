﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ResApiCore.Model.Base
{
    //Contrato entre atributos
    //e a estrtura da tabela
    //[DataContract]
    public class BaseEntity
    {

        public long? Id { get; set; }
    }
}
