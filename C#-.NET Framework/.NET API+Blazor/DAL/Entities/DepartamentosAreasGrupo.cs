using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class DepartamentosAreasGrupo
{
    public int Id { get; set; }

    public int IdDeptArea { get; set; }

    public int IdUtilGrupo { get; set; }
}
