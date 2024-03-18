using UssJuniorTest.Core.Models;

namespace UssJuniorTest.Infrastructure.Store;

/// <summary>
/// Хранилище данных. Эмуляция БД.
/// </summary>
/// <remarks>ДАННЫЙ ИНТЕРФЕЙС НЕ ИЗМЕНЯТЬ.</remarks>
public interface IStore
{
    IQueryable<Car> GetAllCars();
    
    IQueryable<Person> GetAllPersons();
    
    IQueryable<DriveLog> GetAllDriveLogs();
}