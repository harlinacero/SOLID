using System.Collections.Generic;

namespace Pruebas.FactoryMethod
{
    public interface IDataBase<T>
    {
        public T GetBy(string key);
        public IEnumerable<T> GetAll();
        public T Add(T item);
        public T Delete(T item);
        public T Update(T item);
    }
}
