using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class DesktopComputer : Computer
    {
        // Поле класу
        private string chassis;
        // Конструктор
        public DesktopComputer(string type, string processor, string monitor, string keyboard, string mouse, string systemUnit, string chassis)
            : base(type, processor, monitor, keyboard, mouse, systemUnit)
        {
            this.chassis = chassis;
        }
        // Перевірка готовності комп'ютера
        public override bool IsReady()
        {
            return base.IsReady() && !string.IsNullOrWhiteSpace(chassis);
        }
        // Отримати опис комп'ютера
        public new string GetDescription()
        {
            return base.GetDescription() + $", Chassis: {chassis}";
        }
    }
}
