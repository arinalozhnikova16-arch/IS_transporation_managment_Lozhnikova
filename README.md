# IS_transporation_managment_Lozhnikova

# ИС «Управление перевозками» (WPF / C#)

Учебный прототип информационной системы для транспортной компании. Автоматизирует учёт автопарка, тарифов и рейсов, а также строит базовую аналитику по прибыли и загрузке машин. Проект выполнен в рамках курсовой работы по дисциплине "Программирование".

## Что делает приложение
- **Учёт и автоматизация.** Три связанные таблицы (Справочник тарифов, Автопарк, Перевозки). При добавлении рейса прибыль считается автоматически по формуле, что исключает ручной ввод и ошибки.
- **Работа с данными.** Реализованы добавление, редактирование, удаление (с каскадным удалением связанных записей), сортировка и фильтрация по госномеру.
- **Аналитика и отчёты.** Построение линейного графика прибыли и столбчатой диаграммы загрузки машин (LiveCharts). Экспорт отчётов в Excel, Word и TXT.

## Использованный технологический стек
- C# / WPF (.NET)
- SQLite + Entity Framework Core (локальная БД)
- LiveCharts.Wpf (визуализация)

## Архитектура:
Разделила проект на библиотеку классов (модели и репозиторий) и UI. Использовала паттерн Repository и ObservableCollection, чтобы интерфейс обновлялся автоматически при изменении данных в БД

## Примеры работы приложения
### Пользовательские формы
<img width="735" height="651" alt="image" src="https://github.com/user-attachments/assets/08e3ebc7-265f-483d-95a8-31fed33e1c7d" />
<img width="732" height="643" alt="image" src="https://github.com/user-attachments/assets/759e4639-201e-4903-ae94-a66d054d32cb" />
<img width="740" height="654" alt="image" src="https://github.com/user-attachments/assets/738f3f42-dabc-4e65-a439-5a8dc0e23b61" />

### Аналитика
<img width="506" height="578" alt="image" src="https://github.com/user-attachments/assets/9fa784df-c259-4607-9b28-660fe8cca226" />
<img width="510" height="578" alt="image" src="https://github.com/user-attachments/assets/95e37e7d-2372-4227-97ab-ce8550f60f08" />

### Экспорт данных
<img width="784" height="612" alt="image" src="https://github.com/user-attachments/assets/69bebc69-21c1-4495-8848-8fecb73a9117" />
<img width="952" height="501" alt="image" src="https://github.com/user-attachments/assets/1cb9e3d7-a09f-44f5-98ec-40a00bcf9157" />
<img width="954" height="579" alt="image" src="https://github.com/user-attachments/assets/2ee0b635-0001-48f7-b7e1-af82ea33ef48" />
