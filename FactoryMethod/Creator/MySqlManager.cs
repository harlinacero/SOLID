
namespace Pruebas.FactoryMethod.Creator
{
    internal class MySqlManager<T> : DBManager<T>
    {
        public override IDataBase<T> DataBase()
        {
            return new MySQLDB<T>();
        }
    }
}
