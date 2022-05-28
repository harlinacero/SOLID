using System;
using System.Collections.Generic;
using System.Linq;

namespace Pruebas.FactoryMethod
{
    internal class MySQLDB<T> : DbBase<T>, IDataBase<T>
    {
       

        public MySQLDB(): base()
        {
            _name = nameof(MySQLDB<T>);
        }
        public T Add(T item)
        {
            _repo.Add(item);
            Console.WriteLine($"Insertando en {_name}");
            return item;
        }

        public T Delete(T item)
        {
            _repo.Remove(item);
            Console.WriteLine($"Eliminando en {_name}");
            return item;
        }

        public IEnumerable<T> GetAll()
        {
            Console.WriteLine($"Consulta todo en {_name}");
            return _repo;
        }

        public T GetBy(string key)
        {
            Console.WriteLine($"Obtiene un elemento en {_name}");
            return _repo.FirstOrDefault();

        }

        public T Update(T item)
        {
            Console.WriteLine($"Reemplazando un elemento en {_name}");
            var obje = _repo.Where(d => d.Equals(item)).FirstOrDefault();
            if (obje != null)
                return item;
            return item;

        }
    }
}
