// See https://aka.ms/new-console-template for more information
using Patterns.FactoryP;
using Patterns.ObservableP;
using Patterns.ObservableP.EmailService;
using Patterns.ObservableP.Models;
using Patterns.SingletonP;
using Patterns.StrategyP;

Console.WriteLine("--------------");


#region Singleton

Console.WriteLine(Singleton.GetInstance.Msg);
Singleton.GetInstance.Msg = "Ola k ase";
Console.WriteLine(Singleton.GetInstance.Msg);
#endregion

#region Factory simple

// MyConnection Conn = new Factory().ObtConexion(ConnectionProviderType.MySQLConnection);
// Console.WriteLine(Conn.Connections());
#endregion

#region Factory Abstract
var facDb = new Factory().GetFactory(ConnectionService.DB);
var oConn = facDb.GetDB(ConnectionProviderType.MySQLConnection);
Console.WriteLine(oConn.Connections());

var facApi = new Factory().GetFactory(ConnectionService.Rest);
var oConnApi = facApi.GetRest(ConnectionProviderType.SalesRest);
Console.WriteLine(oConnApi.readURL("localhost"));
#endregion

#region Observable

OrderService _orderService = new OrderService();

var order =  new Order(){
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

Console.WriteLine("\n--- Patron Estrategia ---\n");
Pato pelirrojo = new PatoPelirrojo();
pelirrojo.Mostrar();
pelirrojo.Nadar();
pelirrojo.Volar();
pelirrojo.Graznar();
Console.WriteLine();

Pato decorativo = new PatoDecorativo();
decorativo.Mostrar();
decorativo.Nadar();
decorativo.Volar();
decorativo.Graznar();
#endregion