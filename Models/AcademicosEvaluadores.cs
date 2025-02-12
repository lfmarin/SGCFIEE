﻿using System;
using System.Collections.Generic;

namespace SGCFIEE.Models
{
    public partial class Academicosevaluadores
    {
        public int IdAcademicosEvaluadores { get; set; }
        public int? IdAcademico { get; set; }
        public int? IdEvaluadores { get; set; }
        public int? Lider { get; set; }

        public virtual Academicos IdAcademicoNavigation { get; set; }
        public virtual EvaluadoresAcademicos IdEvaluadoresNavigation { get; set; }
    }
}
