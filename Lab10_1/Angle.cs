using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_1
{
    public class Angle
    {
        
        private int _degree; 
        private int _min;
        private int _sec;
                
        #region Properties
                
        public int Gradus
        {
            get { return _degree; }
            set
            {
                if (value > 360 || value < 0) throw new Exception("Неверный угол. Должен быть 0-360");
                _degree = value;
            }
        }

        public int Min
        {
            get { return _min; }
            set
            {
                if (value > 60 || value < 0) throw new Exception("Неверный угол. минуты должны быть 0-60");
                _min = value;
            }
        }

        public int Sec
        {
            get { return _sec; }
            set
            {
                if (value > 60 || value < 0) throw new Exception("Неверный угол. секунды должны быть 0-60");
                _sec = value;
            }
        }

        #endregion

        #region Constructors
               
        public Angle()
        {

        }

        public Angle(int Degrees, int Minutes, int Seconds)
        {
            Gradus = Degrees;
            Min = Minutes;
            Sec = Seconds;
        }

        public Angle(int Degrees, int Minutes)
        {
            Gradus = Degrees;
            Min = Minutes;
        }

        public Angle(int Degrees)
        {
            Gradus = Degrees;
        }
        #endregion

        #region Methods
        
        public double ToRad() => (_degree + (_min + _sec / 60) / 60) * Math.PI / 180;
                
        public override string ToString()
        {
            return _degree + "° " + _min + "' " + _sec + "''";
        }

        #endregion

    }
}
