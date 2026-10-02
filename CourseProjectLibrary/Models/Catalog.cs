using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectLibrary.Models
{
    public class Catalog : Subject
    {
        public string? Brand { get; set; } // Марка авто
        public decimal Price { get; set; } // Цена за перевозку на 1 км
        public double Expense { get; set; } // Расход топлива на перевозку за 1 км

        // Переопределённый метод определения эквивалентности Catalog
        public override bool Equals(object?  obj)
        {
            return this.Id == (obj as Catalog)?.Id;
        }

        // Переопределение метода преобразования класса в строку
        public override string ToString()
        {
            return $"{Brand} | Цена: {Price} руб/км (ID: {Id})";
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }

}
