using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectLibrary.Models
{
    public class Traffic : Subject
    {
        public Car Number { get; set; } // Гос.номер автомобиля
        public decimal Distance { get; set; } // Расстояние
        public decimal Income { get; set; } // Сумма полученной прибыли 
        public DateTime EndDate { get; set; } // Дата окончания перевозки

        // Переопределение метода установления эквивалентности объектов Traffic
        public override bool Equals(object? obj)
        {
            return this.Id == (obj as Traffic)?.Id;
        }

        // Переопределение метода преобразования класса встроку
        public override string ToString()
        {
            return $"ID: {Id} | {Number?.Number} - {Distance} | Прибыль: {Income} руб | Дата окончания: {EndDate.Date.ToString("D")}";
        }

        public override int GetHashCode()
        {
            return this.Id;
        }
    }
}
