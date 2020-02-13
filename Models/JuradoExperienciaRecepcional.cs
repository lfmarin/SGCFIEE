﻿using System;
using System.Collections.Generic;

namespace SGCFIEE.Models
{
    public partial class JuradoExperienciaRecepcional
    {
        public JuradoExperienciaRecepcional()
        {
            AcademicosJuradoRecep = new HashSet<AcademicosJuradoRecep>();
        }

        public int IdJer { get; set; }
        public int? IdTr { get; set; }
        public int? JuradoPrejurado { get; set; }
        public string Archivo { get; set; }

        public virtual TrabajosRecepcionales IdTrNavigation { get; set; }
        public virtual ICollection<AcademicosJuradoRecep> AcademicosJuradoRecep { get; set; }
    }
}
