using System;


namespace CoordinateCalculation
{
    /// <summary>
    /// Класс равномерного движения.
    /// </summary>
    [Serializable]
    public class Uniform : IMotion
    {

        /// <summary>
        /// Время.
        /// </summary>
        private int _time;

        /// <summary
        /// Начальная координата.
        /// </summary>
        private int _startCoordinate;

        /// <summary>
        /// Начальная скорость.
        /// </summary>
        private int _startSpeed;

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="time">Время.</param>
        /// <param name="coordinate">Начальная координата.</param>
        /// <param name="speed">Скорость.</param>
        public Uniform(int _time, int _startCoordinate, int _startSpeed)
        {
            StartCoordinate = _startCoordinate;
            StartSpeed = _startSpeed;
            Time = _time;
        }

        public Uniform()
        {

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
        /// Свойство для скорости.
        /// </summary>
        public int StartSpeed
        {
            get
            {
                return _startSpeed;
            }
            set
            {
                if (_startSpeed < 0)
                {
                    throw new ArgumentException("Скорость не может быть со знаком минус");
                }          
                _startSpeed = value;
            }
        }

        /// <summary>
        /// Свойство для времени.
        /// </summary>
        public int Time
        {
            get
            {
                return _time;
            }
            set
            {
                if (_time > 0)
                {
                    throw new ArgumentException("Время не может быть со знаком минус");
                }
                _time = value;
            }
        }
        
        /// <summary>
        ///  Нахождение координаты движения для равномерного движения.
        /// </summary>
        /// <returns>Координату</returns>
        public double CalculateCoordinate
        {
           get { return (_startCoordinate + _startSpeed * _time); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get
            {
                return "Равномерное";
            }
        }
    }
}
