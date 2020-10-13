using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter.II
{
    public interface IPeopleService
    {
        IEnumerable<IPerson> Get();
    }
}
