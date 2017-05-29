using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinateCalculation

{
    /// <summary>
    /// 
    /// </summary>
    public interface IMotion
    {
        /// <summary>
        /// Время.
        /// </summary>
        int Time { get; set; } 
        

        /// <summary>
        /// 
        /// </summary>
        double CalculateCoordinate { get;}

        /// <summary>
        /// Наименование.
        /// </summary>
        string Name { get;}
    }
}
