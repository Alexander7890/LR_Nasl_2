using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public class Computer
    {
        // Поля класу
        private string type;
        private string processor;
        private string monitor;
        private string keyboard;
        private string mouse;
        private string systemUnit;
        // Конструктор
        public Computer(string type, string processor, string monitor, string keyboard, string mouse, string systemUnit)
        {
            this.type = type;
            this.processor = processor;
            this.monitor = monitor;
            this.keyboard = keyboard;
            this.mouse = mouse;
            this.systemUnit = systemUnit;
        }
        // Методи класу
        public void Modernize(string component, string replacement)
        {
            switch (component.ToLower())
            {
                case "processor":
                    processor = replacement;
                    break;
                case "monitor":
                    monitor = replacement;
                    break;
                case "keyboard":
                    keyboard = replacement;
                    break;
                case "mouse":
                    mouse = replacement;
                    break;
                case "system unit":
                    systemUnit = replacement;
                    break;
                default:
                    MessageBox.Show("Invalid component name.");
                    break;
            }
        }
        // Перевірка готовності комп'ютера
        public bool IsReady()
        {
            return !string.IsNullOrWhiteSpace(type) &&
                   !string.IsNullOrWhiteSpace(processor) &&
                   !string.IsNullOrWhiteSpace(monitor) &&
                   !string.IsNullOrWhiteSpace(keyboard) &&
                   !string.IsNullOrWhiteSpace(mouse) &&
                   !string.IsNullOrWhiteSpace(systemUnit);
        }
        // Отримання опису комп'ютера
        public string GetDescription()
        {
            return $"Type: {type}, Processor: {processor}, Monitor: {monitor}, Keyboard: {keyboard}, Mouse: {mouse}, System Unit: {systemUnit}, Ready: {(IsReady() ? "Yes" : "No")}";
        }
    }
}
