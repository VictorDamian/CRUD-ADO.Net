// See https://aka.ms/new-console-template for more information
using Patterns.FactoryP;
using Patterns.FactoryP.Abstractions;
using Patterns.ObservableP;
using Patterns.ObservableP.EmailService;
using Patterns.ObservableP.Models;
using Patterns.SingletonP;
using Patterns.StrategyP;

Console.WriteLine("--------------");


#region Singleton

//Console.WriteLine(Singleton.GetInstance.Msg);
//Singleton.GetInstance.Msg = "Ola k ase";
//Console.WriteLine(Singleton.GetInstance.Msg);
#endregion

#region Factory simple

// Los patrones Factory Simple y Factory Abstract son patrones de diseño creacionales que facilitan
// la creación de objetos sin especificar la clase exacta de objeto que se va a crear.

// Factory Simple
// Concepto: El patrón Factory Simple se utiliza para encapsular la creación de objetos en una
// única clase llamada "fábrica". Esta clase decide qué objeto crear en función de algunos parámetros.

// Funcionamiento:

// Interfaz o Clase Base: Define una interfaz común para todos los productos que se van a crear.
// Fábrica: Tiene un método que recibe parámetros (como el tipo de objeto a crear) y retorna una instancia del producto correspondiente.
// Implementaciones: Las clases concretas implementan la interfaz y proporcionan la funcionalidad específica.

var facDb = new Factory().GetFactory(ConnectionService.DB);
var oConn = facDb.GetDB(ConnectionProviderType.MySQLConnection);
//Console.WriteLine(oConn.Connections());

var facApi = new Factory().GetFactory(ConnectionService.Rest);
var oConnApi = facApi.GetRest(ConnectionProviderType.SalesRest);
//Console.WriteLine(oConnApi.readURL("localhost"));

#endregion

#region Factory Abstract

// Concepto: El patrón Factory Abstract es una versión más avanzada del patrón Factory Simple.
// Permite crear familias de productos relacionados sin especificar sus clases concretas.
// Se utiliza cuando el sistema debe ser independiente de cómo se crean, componen y representan los productos.

// Funcionamiento:

// Interfaz de Fábrica Abstracta: Define métodos para crear cada tipo de producto
// (por ejemplo, crear un tipo de conexión a base de datos o un tipo de conexión REST).

// Clases de Fábrica Concretas: Implementan la interfaz de fábrica abstracta y crean instancias de productos específicos.
// Interfaz o Clases Base para Productos: Similar al Factory Simple, pero puede haber
// múltiples interfaces o clases base para diferentes familias de productos.

Factory factory = new Factory();

// Usar la fábrica para obtener la conexión a la base de datos
IAbstractFactory dbFactory = factory.GetFactory(ConnectionService.DB);
MyConnection sqlConnection = dbFactory.GetDB(ConnectionProviderType.SQLConnection);
//Console.WriteLine(sqlConnection.Connections());

//Usar la fábrica para obtener la conexión REST
IAbstractFactory restFactory = factory.GetFactory(ConnectionService.Rest);
IConnectionRest restConnection = restFactory.GetRest(ConnectionProviderType.SalesRest);
string data = restConnection.readURL("https://api.example.com/data");
//Console.WriteLine(data);

#endregion

#region Observable

OrderService _orderService = new OrderService();

var order = new Order()
{
    OrderNumber = "89675RCSG",
    OrderDate = DateTime.Now,
    TotalAmount = 105.99m,
    OrderStatus = OrderStatuses.PendingPayment
};
//
Console.WriteLine("\nAttaching observer...");

var smsObs = new SMSObserver();
var emailObs = new EmailObserver();

_orderService.Attach(smsObs);
_orderService.Attach(emailObs);

Console.WriteLine("Updating ORder Status....");

_orderService.UpdateOrder(order);

Console.WriteLine("Detaching SMS Observer...");
_orderService.Detach(smsObs);

Console.WriteLine("Updating Order Status...");
_orderService.UpdateOrder(order);

#endregion

#region Strategy

//Console.WriteLine("\n--- Patron Estrategia ---\n");
//Pato pelirrojo = new PatoPelirrojo();
//pelirrojo.Mostrar();
//pelirrojo.Nadar();
//pelirrojo.Volar();
//pelirrojo.Graznar();
//Console.WriteLine();

//Pato decorativo = new PatoDecorativo();
//decorativo.Mostrar();
//decorativo.Nadar();
//decorativo.Volar();
//decorativo.Graznar();
#endregion