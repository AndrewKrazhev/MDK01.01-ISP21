using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOneISP21
{
    internal interface IScenes
    {
        string Name { get; set; }
        string Description { get; }        
        int Number { get; set;}
        public void Show();

    }
}
