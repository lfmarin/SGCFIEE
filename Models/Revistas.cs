﻿using System;
using System.Collections.Generic;

namespace SGCFIEE.Models
{
    public partial class Revistas
    {
        public Revistas()
        {
            AcademicoRevistas = new HashSet<AcademicoRevistas>();
        }

        public int IdRevistas { get; set; }
        public int? IdNI { get; set; }
        public int? Registro { get; set; }
        public int? Arbitrada { get; set; }
        public string Nombre { get; set; }
        public string Archivo { get; set; }

        public virtual TipoLocNacInter IdNINavigation { get; set; }
        public virtual ICollection<AcademicoRevistas> AcademicoRevistas { get; set; }
    }
}
