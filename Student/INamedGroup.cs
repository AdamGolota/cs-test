using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Students
{
    public interface INamedGroup<T>
    {
        void Add(T obj);
        void Remove(T obj);
        string Name { get; set; }
        T this[int i] { get; set; }
    }
}
