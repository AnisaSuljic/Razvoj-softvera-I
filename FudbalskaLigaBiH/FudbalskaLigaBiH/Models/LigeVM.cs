﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FudbalskaLigaBiH.Models
{
    public class LigeVM
    {
        public int LigaID{ get; set; }
        public List<SelectListItem> listaliga{ get; set; }
    }
}
