using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaromFit.Models
{
    public class Client
    {
        //criando propriedade proop tab tab
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime SubscribeDate { get; set; }

        public Plano Plan { get; set; }
        public int PlanId { get; set; }
    }
}