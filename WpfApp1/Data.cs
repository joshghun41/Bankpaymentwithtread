using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public  class Data
    {
        public string CardNo { get; set; }
        public string FullName { get; set; }
        public int Cash { get; set; }

    public static List<Data> getAll()
        {
            List<Data> list = new List<Data>();
            return new List<Data>()
            {
                new Data
                {
                    CardNo="4444444444444444",
                    FullName="Joshghun Gulmammadli",
                    Cash=1000,
                },
                new Data
                {
                     CardNo="5555555555555555",
                    FullName="Ali ceferli",
                    Cash=500,
                }
            };
        }
    }
}
