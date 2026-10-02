using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseProjectLibrary.Models;

namespace CourseProjectLibrary.Repository
{
    public interface IRepository
    {
        #region Методы возвращают коллекцию объектов
        // ObservableCollection - коллекция с уведомлением об изменении
        ObservableCollection<Catalog> GetCatalogs(int sort = 0);
        ObservableCollection<Car> GetCars(int sort = 0);
        ObservableCollection<Traffic> GetTraffics(int sort = 0);
        #endregion

        #region Добавление элементов в коллекцию
        bool AddCatalog(Catalog catalog);
        bool AddCar(Car car);
        bool AddTraffic(Traffic traffic);
        #endregion

        #region Обновление элементов в коллекции
        bool UpdateCatalog(Catalog catalog);
        bool UpdateCar(Car car);
        bool UpdateTraffic(Traffic traffic);
        #endregion

        #region Удаление элементов в коллекции
        bool RemoveCatalog(Catalog catalog);
        bool RemoveCar(Car car);
        bool RemoveTraffic(Traffic traffic);
        #endregion

        #region Получение элементов по ID
        Catalog GetCatalog(int catalogid);
        Car GetCar(int carid);
        Traffic GetTraffic(int trafficid);
        #endregion

        //Получить заказы по номеру
        ObservableCollection<Traffic> GetTrafficsByNumber(string carNumber);
    }
}
