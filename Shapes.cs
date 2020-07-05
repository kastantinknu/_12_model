using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public abstract class Shapes
    {
        public abstract void MovingRIGHT(int CanvasWidth);

        public abstract void MovingLEFT();
        public abstract void MovingUP();
        public abstract void MovingDOWN(int CanvasHeight);

        public abstract void MovingUPRIGHT();
        public abstract void MovingDOWNRIGHT();
        public abstract void MovingDOWNLEFT();
        public abstract void MovingUPLEFT();
    }
}
