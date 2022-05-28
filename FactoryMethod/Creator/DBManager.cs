
namespace Pruebas.FactoryMethod.Creator
{
    internal abstract class DBManager<T>
    {
        public abstract IDataBase<T> DataBase();
    }
}
