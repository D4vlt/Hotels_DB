using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public partial class Должности
    {
        public Должности()
        {
            Сотрудники = new HashSet<Сотрудники>();
        }

        public long КодДолжноти { get; set; }
        public long Наименование { get; set; }
        public long Оклад { get; set; }
        public long Обязанности { get; set; }
        public long Требования { get; set; }

        public virtual ICollection<Сотрудники> Сотрудники { get; set; }
    }
}
