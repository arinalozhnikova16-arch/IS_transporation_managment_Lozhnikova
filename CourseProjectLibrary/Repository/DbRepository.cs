using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseProjectLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseProjectLibrary.Repository
{
    public class DbRepository : DbContext, IRepository
    {
        #region Определение таблиц БД и создание БД
        // Определение таблиц БД
        // Каждая DbSet - отдельная таблица данных БД
        DbSet<Catalog> Catalogs => Set<Catalog>();
        DbSet<Car> Cars => Set<Car>();
        DbSet<Traffic> Traffics => Set<Traffic>();

        // Установка параметров подключения и создания БД
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Файл БД TransportationManagement.db
            optionsBuilder.UseSqlite("DataSource = TransportationManagement.db");
        }
        #endregion

        #region Конструктор класса DbRepository
        public DbRepository()
        {
            //Удаление БД
            //Database.EnsureDeleted();
            //Создание БД
            Database.EnsureCreated();
        }
        #endregion

        #region Добавить элемент
        public bool AddCatalog(Catalog catalog)
        {
            // Добавить в таблицу
            catalog.Id = Catalogs.OrderBy(p => p.Id).Last().Id + 1;
            Catalogs.Add(catalog);
            // Сохранить изменения
            var res = this.SaveChanges();
            if (res > 0) return true;
            return false;
        }
        public bool AddCar(Car car)
        {
            // Добавить в таблицу
            car.Id = Cars.OrderBy(p => p.Id).Last().Id + 1;
            Cars.Add(car);
            // Сохранить изменения
            var res = this.SaveChanges();
            if (res > 0) return true;
            return false;
        }
        public bool AddTraffic(Traffic traffic)
        {
            // Добавить в таблицу
            traffic.Id = Traffics.OrderBy(p => p.Id).Last().Id + 1;
            Traffics.Add(traffic);
            // Сохранить изменения
            var res = this.SaveChanges();
            if (res > 0) return true;
            return false;
        }
        #endregion

        #region Удалить элемент
        public bool RemoveCatalog(Catalog catalog)
        {
            // Удалить элемент из таблицы
            Catalogs.Remove(catalog);
            var res= this.SaveChanges();
            if (res > 0) return true;
            return false;
        }
        public bool RemoveCar(Car car)
        {
            // Удалить элемент из таблицы
            Cars.Remove(car);
            var res = this.SaveChanges();
            if (res > 0) return true;
            return false;
        }
        public bool RemoveTraffic(Traffic traffic)
        {
            // Удалить элемент из таблицы
            Traffics.Remove(traffic);
            var res = this.SaveChanges();
            if (res > 0) return true;
            return false;
        }
        #endregion

        #region Обновить элемент
        public bool UpdateCatalog(Catalog catalog)
        {
            // Обновить элемент в коллекции
            Catalogs.Update(catalog);
            var res = this.SaveChanges();
            if (res > 0) return true;
            return false;
        }
        public bool UpdateCar(Car car)
        {
            // Обновить элемент в коллекции
            Cars.Update(car);
            var res = this.SaveChanges();
            if (res > 0) return true;
            return false;
        }
        public bool UpdateTraffic(Traffic traffic)
        {
            // Обновить элемент в коллекции
            Traffics.Update(traffic);
            var res = this.SaveChanges();
            if (res > 0) return true;
            return false;
        }
        #endregion

        #region Получить элемент по ID
        public Catalog GetCatalog(int catalogId)
        {
            return Catalogs.FirstOrDefault(p => p.Id == catalogId);
        }
        public Car GetCar(int carId)
        {
            return Cars.FirstOrDefault(p => p.Id == carId);
        }
        public Traffic GetTraffic(int trafficId)
        {
            return Traffics.FirstOrDefault(p => p.Id == trafficId);
        }
        #endregion

        #region Фильтрация и сортировка таблиц
        public ObservableCollection<Catalog> GetCatalogs(int sort = 0)
        {
            if (sort == 0)
                return new ObservableCollection<Catalog>(Catalogs.OrderBy(p => p.Id));
            else if (sort == 1)
                return new ObservableCollection<Catalog>(Catalogs.OrderBy(p => p.Brand));
            else
                return new ObservableCollection<Catalog>(Catalogs.OrderBy(p => p.Expense));
        }
        public ObservableCollection<Car> GetCars(int sort = 0)
        {
            if (sort == 0)
                return new ObservableCollection<Car>(Cars.OrderBy(p => p.Id));
            else if (sort == 1)
                return new ObservableCollection<Car>(Cars.OrderBy(p => p.Number));
            else
                return new ObservableCollection<Car>(Cars.OrderBy(p => p.Mileage));
        }
        public ObservableCollection<Traffic> GetTraffics(int sort = 0)
        {
            if (sort == 0)
                return new ObservableCollection<Traffic>(Traffics.OrderBy(p => p.Id));
            else
                return new ObservableCollection<Traffic>(Traffics.OrderBy(p => p.Number));
        }
        //Получить заказы по гос.номеру
        public ObservableCollection<Traffic> GetTrafficsByNumber(string carNumber)
        {
            return new ObservableCollection<Traffic>(Traffics.Where(p => p.Number != null && p.Number.Number == carNumber));
        }
        #endregion
    }
}
