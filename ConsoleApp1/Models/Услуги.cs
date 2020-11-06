using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public partial class Услуги
    {
        public Услуги()
        {
            КлиентыКодУслуги1Navigation = new HashSet<Клиенты>();
            КлиентыКодУслуги2Navigation = new HashSet<Клиенты>();
            КлиентыКодУслуги3Navigation = new HashSet<Клиенты>();
        }

        public long КодУслуги { get; set; }
        public long Наименование { get; set; }
        public long Описание { get; set; }
        public long Стоимость { get; set; }

        public virtual ICollection<Клиенты> КлиентыКодУслуги1Navigation { get; set; }
        public virtual ICollection<Клиенты> КлиентыКодУслуги2Navigation { get; set; }
        public virtual ICollection<Клиенты> КлиентыКодУслуги3Navigation { get; set; }
    }
}
