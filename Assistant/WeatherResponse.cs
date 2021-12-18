using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistant_v1
{
    class WeatherResponse
    {
        public TempInfo Main { get; set; }

        public string Name { get; set; }
    }
}
