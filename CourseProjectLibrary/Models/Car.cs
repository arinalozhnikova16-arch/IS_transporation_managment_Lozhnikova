using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectLibrary.Models
{
    public class Car : Subject
    {
        public string? Number { get; set; } // Гос.номер автомобиля
        public Catalog Brand { get; set; } // Марка авто
        public string? Color { get; set; } // Цвет
        public double Mileage { get; set; } // Пробег

        // Переопределение метода установления эквивалентности объектов Car
        public override bool Equals(object? obj)
        {
            return this.Id == (obj as Car)?.Id;
        }

        // Переопределение метода преобразования класса в строку
        public override string ToString()
        {
            return $"{Number}, {Brand?.Brand} (ID: {Id})";
        }

        public override int GetHashCode()
        {
            return this.Id;
        }
    }
}
