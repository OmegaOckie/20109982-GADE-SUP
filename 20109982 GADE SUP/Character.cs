using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TAsk1_v._2
{
    [Serializable]
    abstract class Character : Tile
    {
        private Map map;
        private weapon weapon;
        protected int gold;
        protected string symbol;
        protected int hP;
        protected int maxHP;
        protected int damage;
        protected Tile[,] Vision;
        protected int range;
        public enum Movement
        {
            No_Movement, Up, Down, Left, Right
        }

        public bool isdead = false;

        public int HP { get => hP; set => hP = value; }
        public string Symbol { get => symbol; set => symbol = value; }
        public int MaxHP { get => maxHP; set => maxHP = value; }
        public int Damage { get => damage; set => damage = value; }
        public Map Map { get => map; set => map = value; }
        public int Gold { get => gold; set => gold = value; }
        protected weapon Weapon { get => weapon; set => weapon = value; }

        public Character(int x_coordinate, int y_coordinate, int damage) : base(x_coordinate, y_coordinate)
        {
            X_coordinate = x_coordinate;
            Y_coordinate = y_coordinate;

            Damage = damage;


        }

        public virtual void Attack(Character target)
        {
            if (target != null)
            {
                if (target.HP <= 0)
                {

                }
                else
                {
                    target.HP -= this.Damage;
                }
            }



        }
        public virtual bool ChcekRAnge(Character target)
        {
            if (DistanceTo(target) <= range)
            {
                return true;
            }
            else
            {
                return false;

            }


        }
        public void pickup(Item i)
        {

        }

        private int DistanceTo(Character target)
        {
            int spaces = 0;
            //range denotes potion from this charchter
            //only works with range as 1
            //if ((this.X_coordinate + range == target.X_coordinate && this.Y_coordinate == target.Y_coordinate)//left of this charchter
            //    ||(this.X_coordinate == target.X_coordinate && this.Y_coordinate + range == target.Y_coordinate)//up of this charchter
            //    ||(this.X_coordinate - range == target.X_coordinate && this.Y_coordinate == target.Y_coordinate)//right of this charchter
            //    ||(this.X_coordinate  == target.X_coordinate && this.Y_coordinate - range == target.Y_coordinate)//down of this charchter
            //    ||(this.X_coordinate + range == target.X_coordinate && this.Y_coordinate + range == target.Y_coordinate)//top left of this charchter
            //    ||(this.X_coordinate - range == target.X_coordinate && this.Y_coordinate + range == target.Y_coordinate)//top right of this charchter
            //    ||(this.X_coordinate + range == target.X_coordinate && this.Y_coordinate - range == target.Y_coordinate)//bottom left of this charchter
            //    ||(this.X_coordinate - range == target.X_coordinate && this.Y_coordinate - range == target.Y_coordinate))//bottom right of this charchter
            //{


            //    spaces++;

            //}



            return spaces;
        }
        public void Move(Movement move)
        {

            switch (move)
            {
                case Movement.Up:
                    this.X_coordinate--;
                    break;
                case Movement.Down:
                    this.X_coordinate++;
                    break;
                case Movement.Left:
                    this.Y_coordinate--;
                    break;
                case Movement.Right:
                    this.Y_coordinate++;
                    break;
                case Movement.No_Movement:
                    break;
            }

        }
        public void loot(Character target)
        {
            this.gold += target.gold;
        }

        public abstract Movement Returnmove(Movement move = 0);


        public abstract override string ToString();

    }
}
