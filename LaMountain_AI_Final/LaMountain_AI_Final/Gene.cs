using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace LaMountain_AI_Final
{
    class Gene
    {
        int color;
        int fitnessValue;

        public Gene(int _color)
        {
            color = _color;
            fitnessValue = int.MaxValue;
        }

        public int CalcFitnessValue(int _color)
        {
            if (fitnessValue == int.MaxValue)
            {
                fitnessValue = Math.Abs(_color - color);
            }
            return fitnessValue;
        }

        public int GeneColor
        {
            get { return color; }
        }

        public void SetColor(int _color)
        {
            color = _color;
            fitnessValue = int.MaxValue;
        }

        public int Fitness
        {
            get { return fitnessValue; }
        }
    }
}
