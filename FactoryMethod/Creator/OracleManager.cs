
namespace Pruebas.FactoryMethod.Creator
{
    internal class OracleManager<T> : DBManager<T>
    {
        public override IDataBase<T> DataBase()
        {
            return new Oracle<T>();
        }
    }
}
