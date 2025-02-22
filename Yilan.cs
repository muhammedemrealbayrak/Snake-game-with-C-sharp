using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SnackGame
{
    class Yilan
    {

        yilan_parcalari[] yilan_parca;
        public Yilan()
        {
            yilan_parca[] = new yilan_parcalari[3];
        }
        public void ilerle(Yon yon)
        {

        }
        public void Buyu()
        {

        }
    }
    class yilan_parcalari
    {

        public int x_;
        public int y_;
        public readonly int size_x;
        public readonly int size_y;
        public yilan_parcalari(int x, int y)
        { 
            x_ = x;
            y_ = y;

            size_x = 10;
            size_y = 10;
        }

    }
    class Yon
    {   
        public readonly int _x;
        public readonly int _y;
        public Yon(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
}
