using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public partial class Клиенты
    {
        public long Фио { get; set; }
        public long ПаспортныеДанные { get; set; }
        public long ДатаЗаселения { get; set; }
        public long ДатаВыезда { get; set; }
        public long КодНомера { get; set; }
        public long Стоимость { get; set; }
        public long КодСотрудника { get; set; }
        public long КодУслуги1 { get; set; }
        public long КодУслуги2 { get; set; }
        public long КодУслуги3 { get; set; }

        public virtual Номера КодНомераNavigation { get; set; }
        public virtual Сотрудники КодСотрудникаNavigation { get; set; }
        public virtual Услуги КодУслуги1Navigation { get; set; }
        public virtual Услуги КодУслуги2Navigation { get; set; }
        public virtual Услуги КодУслуги3Navigation { get; set; }
    }
}
