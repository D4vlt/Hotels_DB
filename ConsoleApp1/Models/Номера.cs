using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public partial class Номера
    {
        public long КодНомера { get; set; }
        public long Наименование { get; set; }
        public long Вместимость { get; set; }
        public long Описание { get; set; }
        public long Стоимость { get; set; }

        public virtual Клиенты Клиенты { get; set; }
    }
}
