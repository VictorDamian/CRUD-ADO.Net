// See https://aka.ms/new-console-template for more information
Console.WriteLine("Principio segregacion de interfaces");





public class SaleRepository : IBasicActions<Sale>
{
    public void Add(Sale entity)
    {
        Console.WriteLine("Creado...");
    }
    public Sale Get(int id)
    {
        Console.WriteLine("Obtener venta...");
        return new Sale();
    }
    public List<Sale> GetAll()
    {
        Console.WriteLine("Obtener lista...");
        return new List<Sale>();
    }
}
public class UserRepository : IEditableActions<User>, IBasicActions<User>
{
    public void Add(User entity)
    {
        Console.WriteLine("Creado...");
    }

    public void Delete(User entity)
    {
        Console.WriteLine("Eliminado...");
    }

    public User Get(int id)
    {
        Console.WriteLine("Obtener usr...");
        return new User();
    }

    public List<User> GetAll()
    {
        Console.WriteLine("Obtener lista...");
        return new List<User>();
    }

    public void Update(User entity)
    {
        Console.WriteLine("Actualizado...");
    }
}
public interface IBasicActions<T>
{
    public T Get(int id);
    public List<T> GetAll();
    public void Add (T entity);
}
public interface IEditableActions<T>
{
    public void Update(T entity);
    public void Delete(T entity);
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
}
public class Sale
{
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
}