namespace Patterns.FactoryP
{
    public enum ConnectionProviderType
    {
        SQLConnection, MySQLConnection, OracleConnection, SalesRest, UserRest
    }
    public enum ConnectionService{
        DB, Rest
    }
}