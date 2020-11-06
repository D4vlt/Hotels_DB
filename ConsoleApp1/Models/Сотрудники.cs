using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public partial class Сотрудники
    {
        public Сотрудники()
        {
            Клиенты = new HashSet<Клиенты>();
        }

        public long КодСотрудника { get; set; }
        public long Фио { get; set; }
        public long Возраст { get; set; }
        public long Пол { get; set; }
        public long Адрес { get; set; }
        public long ПаспортныеДанные { get; set; }
        public long КодДолжноти { get; set; }

        public virtual Должности КодДолжнотиNavigation { get; set; }
        public virtual ICollection<Клиенты> Клиенты { get; set; }
    }
}
