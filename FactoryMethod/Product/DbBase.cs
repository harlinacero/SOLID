using System.Collections.Generic;

namespace Pruebas.FactoryMethod
{
    internal abstract class DbBase<T>
    {
        public List<T> _repo;
        public string _name;
        public DbBase()
        {
            _repo = new List<T>();
        }
    }
}
