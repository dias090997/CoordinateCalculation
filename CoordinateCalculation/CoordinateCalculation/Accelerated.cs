using System;


namespace CoordinateCalculation
{
    /// <summary>
    /// Класс для равноускоренно движение.
    /// </summary>
    [Serializable]
    public class Accelerated : IMotion
    {
        /// <summary>
        /// Время.
        /// </summary>
        private int _time;
        
       /// <summary>
       /// Начальная координата.
       /// </summary>
        private int _startCoordinate;

        /// <summary>
        /// Начальная скорость.
        /// </summary>
        private int _startSpeed;

        /// <summary>
        /// Ускорение.
        /// </summary>
        private int _acceleration;

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="_time">Время.</param>
        /// <param name="_startCoordinate">Начальная координата.</param>
        /// <param name="_startSpeed">Начальная скорость.</param>
        /// <param name="_acceleration">Ускорение.</param>
        public Accelerated(int time, int startCoordinate, int startSpeed, int acceleration)
        {
            StartCoordinate = startCoordinate;
            StartSpeed = startSpeed; 
            Time= time;
            Acceleration = acceleration;
        }

        public Accelerated()
        {

        }
        /// <summary> 
        /// Свойство для ускорения.
        /// </summary> 
        public int Acceleration
        {
            get { return _acceleration; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Ускорение не может быть равно нулю");
                }
                _acceleration = value;
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
                if (value < 0)
                {
                    throw new ArgumentException("Время не может быть со знаком минус");
                }
                _time = value;
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
        /// Свойство для начальной скорости.
        /// </summary> 
        public int StartSpeed
        {
            get
            {
                return _startSpeed;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Начальнвя скорость должна быть положительной");
                }
                _startSpeed = value;
            }

        }

        /// <summary>
        /// Нахождение координаты движения для равноускоренного движения.
        /// </summary>
        /// <returns></returns>
        public double CalculateCoordinate
        {
            get { return (_startCoordinate + (_startSpeed * _time) + (_acceleration * _time * _time) / 2.0); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get
            {
                return "Равноускоренное";
            }
        }
    }
}
