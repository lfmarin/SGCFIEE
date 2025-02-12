﻿using System;
using System.Collections.Generic;

namespace SGCFIEE.Models
{
    public partial class Academicotrabajosrecep
    {
        public int IdAcademicoTrabajosRecep { get; set; }
        public int? IdAcademico { get; set; }
        public int? IdTrabajosRecep { get; set; }
        public int? Lider { get; set; }

        public virtual Academicos IdAcademicoNavigation { get; set; }
        public virtual TrabajosRecepcionales IdTrabajosRecepNavigation { get; set; }
    }
}
