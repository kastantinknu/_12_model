using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Models
{//
    public class HexagonModel : Shapes, INotifyPropertyChanged
    {//8
        int[] vs = new int[] { 44, 8, 76, 26, 76, 63, 44, 81, 13, 63, 13, 26 };
        int[] star = new int[] { 44, 18, 47, 39, 67, 33, 50, 44, 66, 57, 47, 50, 44, 71, 41, 50, 22, 55, 38, 44, 22, 33, 41, 39 };

        internal bool Chaker()
        {
            if (  ((vs[2] == 136) && (vs[3] >= 86) && (vs[3] <= 214))  || ((vs[4] == 136) && (vs[5] >= 86) && (vs[5] <= 214))  )
            {
                return false;

            }
            else
            {
                return true;

            }
        }
        internal bool Chaker0()
        {
            if (((vs[8] == 154) && (vs[9] >= 86) && (vs[9] <= 214)) ||( (vs[10] == 154) && (vs[11] >= 86) && (vs[11] <= 214)))
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
            if (  ((vs[6] <= 136) && (vs[6] >= 104))&&((vs[7]>=86)&&(vs[7]<=104)) && (vs[7] == Math.Round((-0.5625 * vs[6] + 162.5), 0, MidpointRounding.AwayFromZero) ) )
            {
                return false;

            }
            else
            {
                return true;

            }
        }
        internal bool Chaker3()
        {
            if (((vs[6] >= 154) && (vs[6] <= 186)) && ((vs[7] >= 86) && (vs[7] <= 104)) && (vs[7] >= Math.Round((0.6 * vs[6] -7.6), 0, MidpointRounding.AwayFromZero)))
            {
                return false;

            }
            else
            {
                return true;

            }
        }
        internal bool Chaker4()
        {
            if (((vs[0] >= 154) && (vs[0] <= 185)) && ((vs[1] >= 196) && (vs[1] <= 214)) && (vs[1] <= Math.Round((-0.580645 * vs[0] + 303.419), 0, MidpointRounding.AwayFromZero)))
            {
                return false;

            }
            else
            {
                return true;

            }
        }
        internal bool Chaker5()
        {
            if (((vs[0] >= 104) && (vs[0] <= 136)) && ((vs[1] >= 196) && (vs[1] <= 214)) && (vs[1] <= Math.Round((0.5625 * vs[0] + 137.5), 0, MidpointRounding.AwayFromZero)))
            {
                return false;

            }
            else
            {
                return true;

            }
        }
        public string GetString_of_points(int[] vs)
        {
            return String.Join(",", vs);
        }
        public string GetString_of_points()
        {
            return String.Join(",", vs);
        }


        public override void MovingRIGHT(int CanvasWidth)
        {
            if ((vs[2] <= CanvasWidth - 6) && Chaker() && Chaker2() && Chaker5())
            {
                int[] vs1 = new int[12];
                for (int i = 0; i < vs.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        vs1[i] = vs[i] + 1;
                    }
                    else
                    {
                        vs1[i] = vs[i];

                    }

                }
                vs = vs1;
                Points_of_polygon = this.GetString_of_points(vs);
                int[] star1 = new int[24];
                for (int i = 0; i < star.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        star1[i] = star[i] + 1;
                    }
                    else
                    {
                        star1[i] = star[i];
                    }
                }
                star = star1;
                Points_of_star = this.GetString_of_points(star);
            }
        }
        public override void MovingLEFT( )
        {
            if (vs[8] >= 4 && Chaker0()&& Chaker3() &&Chaker4())
            {
                int[] vs1 = new int[12];
                for (int i = 0; i < vs.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        vs1[i] = vs[i] - 1;
                    }
                    else
                    {
                        vs1[i] = vs[i];
                    }
                }

                vs = vs1;
                Points_of_polygon = this.GetString_of_points(vs);

                int[] star1 = new int[24];
                for (int i = 0; i < star.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        star1[i] = star[i] -1;
                    }
                    else
                    {
                        star1[i] = star[i];

                    }

                }
                star = star1;
                Points_of_star = this.GetString_of_points(star);
            }
        }
        public override void MovingUP()
        {
            if (Chaker4()&& vs[1] >= 4 && Chaker5() && (!((vs[1] == 214) && (vs[0] >= 136) && (vs[0] <= 154))))
            {
                int[] vs1 = new int[12];
                for (int i = 0; i < vs.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        vs1[i] = vs[i];
                    }
                    else
                    {
                        vs1[i] = vs[i] - 1;
                    }
                }

                vs = vs1;
                Points_of_polygon = this.GetString_of_points(vs);


                int[] star1 = new int[24];
                for (int i = 0; i < star.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        star1[i] = star[i] ;
                    }
                    else
                    {
                        star1[i] = star[i]-1;

                    }

                }
                star = star1;
                Points_of_star = this.GetString_of_points(star);
            }
        }
        public override void MovingDOWN(int CanvasHeight)
        {
            if ( (vs[7] <= CanvasHeight - 6)&& Chaker3() && Chaker2()&&   (! ( (vs[7]==86)&&(vs[6]>=136)&&(vs[6]<=154) ) ))
            {
                int[] vs1 = new int[12];
                for (int i = 0; i < vs.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        vs1[i] = vs[i];
                    }
                    else
                    {
                        vs1[i] = vs[i] + 1;
                    }
                }

                vs = vs1;
                Points_of_polygon = this.GetString_of_points(vs);

                int[] star1 = new int[24];
                for (int i = 0; i < star.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        star1[i] = star[i] ;
                    }
                    else
                    {
                        star1[i] = star[i]+ 1;

                    }

                }
                star = star1;
                Points_of_star = this.GetString_of_points(star);
            }
        }

        public override void MovingUPRIGHT()
        {
            if ((vs[1] >= 4)&& (!((vs[1] == 214) && (vs[0] >= 136) && (vs[0] <= 154)))&&(vs[2] <= 300-6)&& Chaker()&&Chaker4() && Chaker5())
            {
                int[] vs1 = new int[12];
                for (int i = 0; i < vs.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        vs1[i] = vs[i] + 1;
                    }
                    else
                    {
                        vs1[i] = vs[i] - 1;
                    }
                }

                vs = vs1;
                Points_of_polygon = this.GetString_of_points(vs);

                int[] star1 = new int[24];
                for (int i = 0; i < star.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        star1[i] = star[i] + 1;
                    }
                    else
                    {
                        star1[i] = star[i]-1;

                    }

                }
                star = star1;
                Points_of_star = this.GetString_of_points(star);
            }
        }

        public override void MovingDOWNRIGHT()
        {
            if ((vs[4] <= 300-6) && (vs[7] <= 300 - 6)&& Chaker2()&& Chaker()&&Chaker3()&&(!((vs[7] == 86) && (vs[6] >= 136) && (vs[6] <= 154))))
            {
                int[] vs1 = new int[12];
                for (int i = 0; i < vs.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        vs1[i] = vs[i] + 1;
                    }
                    else
                    {
                        vs1[i] = vs[i] + 1;
                    }
                }

                vs = vs1;
                Points_of_polygon = this.GetString_of_points(vs);

                int[] star1 = new int[24];
                for (int i = 0; i < star.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        star1[i] = star[i] + 1;
                    }
                    else
                    {
                        star1[i] = star[i]+ 1;

                    }

                }
                star = star1;
                Points_of_star = this.GetString_of_points(star);
            }
        }

        public override void MovingDOWNLEFT()
        {
            if ((vs[7] <= 300-6) && (vs[8] >= 4)&& Chaker0() && Chaker2()&& Chaker3()&& (!((vs[7] == 86) && (vs[6] >= 136) && (vs[6] <= 154))))
            {
                int[] vs1 = new int[12];
                for (int i = 0; i < vs.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        vs1[i] = vs[i] - 1;
                    }
                    else
                    {
                        vs1[i] = vs[i] + 1;
                    }
                }

                vs = vs1;
                Points_of_polygon = this.GetString_of_points(vs);

                int[] star1 = new int[24];
                for (int i = 0; i < star.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        star1[i] = star[i] - 1;
                    }
                    else
                    {
                        star1[i] = star[i]+ 1;

                    }

                }
                star = star1;
                Points_of_star = this.GetString_of_points(star);
            }
        }

        public override void MovingUPLEFT()
        {
            if ((vs[1] >= 4) && (vs[10] >= 4)&& (!((vs[1] == 214) && (vs[0] >= 136) && (vs[0] <= 154)))&& Chaker0()&& Chaker4() && Chaker5())
            {
                int[] vs1 = new int[12];
                for (int i = 0; i < vs.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        vs1[i] = vs[i] - 1;
                    }
                    else
                    {
                        vs1[i] = vs[i] - 1;
                    }
                }

                vs = vs1;
                Points_of_polygon = this.GetString_of_points(vs);
                int[] star1 = new int[24];
                for (int i = 0; i < star.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        star1[i] = star[i] - 1;
                    }
                    else
                    {
                        star1[i] = star[i]- 1;

                    }

                }
                star = star1;
                Points_of_star = this.GetString_of_points(star);
            }
        }

        private string _points_of_polygon;

        public string Points_of_polygon
        {
            get { return _points_of_polygon; }
            set => SetAndRaisePropertyChanged(ref _points_of_polygon, value);
        }

        private string _points_of_star;

        public string Points_of_star
        {
            get { return _points_of_star; }
            set => SetAndRaisePropertyChanged(ref _points_of_star, value);
        }

        public HexagonModel()
        {
            Points_of_polygon = this.GetString_of_points(vs);
            Points_of_star = this.GetString_of_points(star);
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
