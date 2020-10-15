using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitecturalPatterns.Views
{
    public interface IMvpView
    {
        void Load(string value);
        void Display(string value);
    }
}
