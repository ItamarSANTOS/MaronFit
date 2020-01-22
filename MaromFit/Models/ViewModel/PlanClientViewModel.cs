using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaromFit.Models.ViewModel
{
    public class PlanClientViewModel
    {
        public Client Usuario { get; set; }
        public List<Plano> Planos { get; set; }
    }
}