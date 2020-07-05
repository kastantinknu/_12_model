using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Model
{
   public class TriangleModel : Shapes, INotifyPropertyChanged
    {
        int[] triangle = new int[] { 52, 7, 93, 83, 12, 83, 32, 44, 52, 82, 71, 44, 32, 44, 52, 7 };
        private string _points_of_triangle;

        internal bool Chaker1()
        {
            if (((triangle[0] >= 95) && (triangle[0] <= 136)) && ((triangle[1] >= 138) && (triangle[1] <= 214)) && (triangle[0] >= Math.Round((0.539473 * triangle[1] + 20.5526), 0, MidpointRounding.AwayFromZero)))
            {
                return false;

            }
            else
            {
                return true;

            }
        }
        internal bool Chaker2()
        {
            if (((triangle[0] >= 154) && (triangle[0] <= 194)) && ((triangle[1] >= 138) && (triangle[1] <= 214)) && (triangle[0] <= Math.Round((-0.526315 * triangle[1] + 266.6315), 0, MidpointRounding.AwayFromZero)))
            {
                return false;

            }
            else
            {
                return true;

            }
        }
        public string Points_of_triangle
        {
            get { return _points_of_triangle; }
            set => SetAndRaisePropertyChanged(ref _points_of_triangle, value);
        }
        public string GetString_of_points(int[] vs)
        {
            return String.Join(",", vs);
        }
        public override void MovingRIGHT(int CanvasWidth)
        {
            if ((triangle[2] <= CanvasWidth - 6)&& Chaker1() && (!((triangle[2] == 136)&&(triangle[3] >= 86)&& (triangle[3] <= 214))))
            {
                int[] triangle1 = new int[16];
                for (int i = 0; i < triangle.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        triangle1[i] = triangle[i] + 1;
                    }
                    else
                    {
                        triangle1[i] = triangle[i];

                    }
                }
                triangle = triangle1;
                Points_of_triangle = this.GetString_of_points(triangle);
            }
        }

        public override void MovingLEFT()
        {
            if (triangle[4] >= 4 && Chaker2()&&(!((triangle[4] == 154) && (triangle[5] >= 86) && (triangle[5] <= 214))))
            {
                int[] triangle1 = new int[16];
                for (int i = 0; i < triangle.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        triangle1[i] = triangle[i] - 1;
                    }
                    else
                    {
                        triangle1[i] = triangle[i];

                    }
                }
                triangle = triangle1;
                Points_of_triangle = this.GetString_of_points(triangle);
            }
        }

        public override void MovingUP()
        {
            if (triangle[1] >= 4&& Chaker2() && Chaker1() && (!((triangle[1] == 214) && (triangle[0] >= 136) && (triangle[0] <= 154))))
            {
                int[] vs1 = new int[16];
                for (int i = 0; i < triangle.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        vs1[i] = triangle[i];
                    }
                    else
                    {
                        vs1[i] = triangle[i] - 1;
                    }
                }

                triangle = vs1;
                Points_of_triangle = this.GetString_of_points(triangle);
            }
        }

        public override void MovingDOWN(int CanvasHeight)
        {
            if (triangle[3] <= CanvasHeight -2&& (!((triangle[5] == 86) && (triangle[4] >= 55) && (triangle[4] <= 154))))
            {
                int[] vs1 = new int[16];
                for (int i = 0; i < triangle.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        vs1[i] = triangle[i];
                    }
                    else
                    {
                        vs1[i] = triangle[i] + 1;
                    }
                }

                triangle = vs1;
                Points_of_triangle = this.GetString_of_points(triangle);
            }
        }

        public override void MovingUPRIGHT()
        {
            if ((triangle[1] >= 4) && Chaker1() && (triangle[2] <= 300 - 4) && (!((triangle[2] == 136) && (triangle[3] >= 86) && (triangle[3] <= 214))))
            {
                int[] vs1 = new int[16];
                for (int i = 0; i < triangle.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        vs1[i] = triangle[i] + 1;
                    }
                    else
                    {
                        vs1[i] = triangle[i] - 1;
                    }
                }

                triangle = vs1;
                Points_of_triangle = this.GetString_of_points(triangle);
            }
        }

        public override void MovingDOWNRIGHT()
        {
            if ((triangle[3] <= 300 - 4) && Chaker1() && (triangle[2] <= 300 - 4) && (!((triangle[2] == 136) && (triangle[3] >= 86) && (triangle[3] <= 214))))
            {
                int[] vs1 = new int[16];
                for (int i = 0; i < triangle.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        vs1[i] = triangle[i] + 1;
                    }
                    else
                    {
                        vs1[i] = triangle[i] + 1;
                    }
                }
                triangle = vs1;
                Points_of_triangle = this.GetString_of_points(triangle);

            }
        }

        public override void MovingDOWNLEFT()
        {
            if ((triangle[3] <= 300 - 4)&& Chaker2() && (triangle[4] >= 4) && (!((triangle[4] == 154) && (triangle[5] >= 86) && (triangle[5] <= 214))))
            {
                int[] vs1 = new int[16];
                for (int i = 0; i < triangle.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        vs1[i] = triangle[i] - 1;
                    }
                    else
                    {
                        vs1[i] = triangle[i] + 1;
                    }
                }
                triangle = vs1;
                Points_of_triangle = this.GetString_of_points(triangle);

            }
        }

        public override void MovingUPLEFT()
        {
            if ((triangle[1] >= 4) && Chaker2() && (triangle[4] >= 4) && (!((triangle[4] == 154) && (triangle[5] >= 86) && (triangle[5] <= 214))))
            {
                int[] vs1 = new int[16];
                for (int i = 0; i < triangle.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        vs1[i] = triangle[i] - 1;
                    }
                    else
                    {
                        vs1[i] = triangle[i] - 1;
                    }
                }
                triangle = vs1;
                Points_of_triangle = this.GetString_of_points(triangle);

            }
        }


        public TriangleModel()
        {
            Points_of_triangle = this.GetString_of_points(triangle);
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual bool SetAndRaisePropertyChanged<T>(ref T storage, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
                return false;
            storage = value;
            this.RaisePropertyChanged(propertyName);
            return true;
        }


    }
}
