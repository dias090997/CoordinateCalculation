using System;


namespace CoordinateCalculation
{
    /// <summary>
    /// Класс для колебательного движения.
    /// </summary>
    [Serializable]
    public class Vibrating : IMotion
    {
        /// <summary>
        /// Начальная координата.
        /// </summary>
        private int _startCoordinate;

        /// <summary>
        /// Начальное время.
        /// </summary>
        private int _time;

        /// <summary>
        /// Частота.
        /// </summary>
        private int _frequency;

        /// <summary>
        /// Амплитуда.
        /// </summary>
        private int _amplitude;

        /// <summary>
        /// Начальная фаза.
        /// </summary>
        private int _startPhase;

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="_startCoordinate"></param>
        /// <param name="_time"></param>
        /// <param name="_frequency"></param>
        /// <param name="_amplitude"></param>
        /// <param name="_startPhase"></param>
        public Vibrating(int _startCoordinate, int _time, int _frequency, int _amplitude, int _startPhase)
        {
            StartCoordinate = _startCoordinate;
            Time = _time;
            Frequency = _frequency;
            Amplitude = _amplitude;
            StartPhase = _startPhase;
        }

        public Vibrating()
        {

        }

        /// <summary>
        ///Свойство для начальной фазы.
        /// </summary>
        public int StartPhase
        {
            get
            {
                return _startPhase;
            }
            set
            {
                if (value > 0)
                {
                    _startPhase = value;

                }
                else
                {
                    throw new ArgumentException("Начальная фаза не может быть со знаком минус");
                }
            }
        }


        /// <summary>
        ///Свойство для амплитуды.
        /// </summary>
        public int Amplitude
        {
            get
            {
                return _amplitude;
            }
            set
            {
                if (value > 0)
                {
                    _amplitude = value;

                }
                else
                {
                    throw new ArgumentException("Амплитуда не может быть со знаком минус");
                }
            }
        }


        /// <summary>
        ///Свойство для частоты.
        /// </summary>
        public int Frequency
        {
            get
            {
                return _frequency;
            }
            set
            {
                if (value > 0)
                {
                    _frequency = value;

                }
                else
                {
                    throw new ArgumentException("Частота не может быть со знаком минус");
                }
            }
        }

        /// <summary>
        ///Свойство для времени.
        /// </summary>
        public int Time
        {
            get
            {
                return _time;
            }
            set
            {
                if (value > 0)
                {
                    _time = value;

                }
                else
                {
                    throw new ArgumentException("Время не может быть со знаком минус");
                }
            }
        }

        /// <summary>
        /// Cвойство для начальной координаты.
        /// </summary>
       public int StartCoordinate
        {
            get
            {
                return _startCoordinate;
            }
            set
            {
                _startCoordinate = value;
            }
        }



        /// <summary>
        /// Нахождения координаты движения для колебательного движения.
        /// </summary>
        /// <returns></returns>
        public double CalculateCoordinate
        {
            get{ return (_amplitude * Math.Sin(_frequency * _time + _startPhase)); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get
            {
                return "Колебательное";
            }
        }
    }
}

