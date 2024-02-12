using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Emerald
    {
        private int _status; // статус изумруда: 0 - не учтён, 1 - учтён, 2 - отправлен под спуд
        private double _price; // цена изумруда

        public Emerald()
        {
            _status = 0;
            _price = 0.0;
        }

        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
