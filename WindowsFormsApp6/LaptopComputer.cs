using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class LaptopComputer : Computer
    {
        // Поле класу
        private string battery;
        // Конструктор
        public LaptopComputer(string type, string processor, string monitor, string keyboard, string mouse, string systemUnit, string battery)
            : base(type, processor, monitor, keyboard, mouse, systemUnit)
        {
            this.battery = battery;
        }
        // Перевірка готовності комп'ютера
        public override bool IsReady()
        {
            return base.IsReady() && !string.IsNullOrWhiteSpace(battery);
        }
        // Отримати опис комп'ютера
        public new string GetDescription()
        {
            return base.GetDescription() + $", Battery: {battery}";
        }
    }
}

