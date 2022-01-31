using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20109982_GADE_SUP
{
    [Serializable]
    class Map
    {

        Tile[,] mapArray;
        Hero hero;
        public Shop shop;
        public Enemey[,] enemeyArray;
        public Item[,] itemarray;
        int MinWidth_X;
        int MaxWidth_X;
        int MinHeight_Y;
        int MaxHeight_Y;
        Random rnd = new Random();
        public int maxGold = 10;
        private int enemycount = 10;


        public Tile[,] maparray
        {
            get
            {
                return mapArray;
            }
            set
            {

            }

        }

        public Hero Hero { get => hero; set => hero = value; }
        public int MaxWidth_X1 { get => MaxWidth_X; set => MaxWidth_X = value; }
        public int MinHeight_Y1 { get => MinHeight_Y; set => MinHeight_Y = value; }
        public int MaxHeight_Y1 { get => MaxHeight_Y; set => MaxHeight_Y = value; }
        public int MinWidth_X1 { get => MinWidth_X; set => MinWidth_X = value; }
        internal Item[,] Itemarray { get => itemarray; set => itemarray = value; }
        internal Enemey[,] EnemeyArray { get => enemeyArray; set => enemeyArray = value; }

        public void populateArray()
        {
            mapArray = new Tile[MaxWidth_X1, MaxHeight_Y1];

            for (int i = 0; i <= MaxWidth_X1 - 1; i++)
            {
                for (int o = 0; o <= MaxHeight_Y1 - 1; o++)
                {
                    mapArray[i, o] = new EmptyTile(i, o);

                }
            }




            create(Tile.TileType.HERO);
            create(Tile.TileType.SHOP);
            for (int i = 0; i <= RandomNumber(1, enemycount); i++)
            {
                create(Tile.TileType.ENEMY);
            }
            for (int i = 0; i <= MaxHeight_Y1 - 1; i++)
            {
                mapArray[MaxWidth_X1 - 1, i] = new Obstacle(MaxWidth_X1 - 1, i);
                mapArray[0, i] = new Obstacle(MinWidth_X1 + 1, i);
            }
            for (int i = 0; i <= MaxWidth_X1 - 1; i++)
            {
                mapArray[i, MaxHeight_Y1 - 1] = new Obstacle(i, MaxHeight_Y1 - 1);
                mapArray[i, 0] = new Obstacle(i, MinHeight_Y1 + 1);
            }
            int goldcount = RandomNumber(2, maxGold);
            for (int i = 0; i < goldcount; i++)
            {
                create(Tile.TileType.GOLD);
            }



        }

        public int RandomNumber(int min, int max)
        {
            return rnd.Next(min, max);
        }

        public Map(int minWidth_X, int maxWidth_X, int minHeight_Y, int maxHeight_Y)
        {
            MinWidth_X1 = minWidth_X;
            MaxWidth_X1 = RandomNumber(minWidth_X + 5, maxWidth_X - 1);
            MinHeight_Y1 = minHeight_Y;
            MaxHeight_Y1 = RandomNumber(minHeight_Y + 5, maxHeight_Y - 1);

            mapArray = new Tile[MaxWidth_X1, MaxHeight_Y1];
            enemeyArray = new Enemey[MaxWidth_X1, MaxHeight_Y1];
            itemarray = new Item[MaxWidth_X1, MaxHeight_Y1];



            populateArray();



        }
        public Item GetItemAtPostion(int X, int Y)
        {
            if (itemarray[X, Y] != null)
            {
                for (int i = 0; i < MaxWidth_X1; i++)
                {
                    for (int o = 0; o < MaxHeight_Y1; o++)
                    {
                        if (itemarray[i, o] != null)
                        {
                            return itemarray[i, o];
                        }
                    }
                }
            }


            return null;
        }
        public void drawmap(Label l1abel, Label heroinfo)
        {
            ;
            l1abel.Text = "";
            heroinfo.Text = hero.ToString();

            for (int i = 0; i < MaxWidth_X1; i++)
            {
                l1abel.Text += "\n";
                for (int o = 0; o < MaxHeight_Y1; o++)
                {
                    if (enemeyArray[i, o] != null)
                    {
                        l1abel.Text += enemeyArray[i, o].Symbol + " ";
                    }
                    else if (itemarray[i, o] != null)
                    {
                        l1abel.Text += itemarray[i, o].ToString();
                    }
                    else if (i == hero.X_coordinate && o == hero.Y_coordinate)
                    {
                        l1abel.Text += " H ";

                    }
                    else
                    {
                        l1abel.Text += Convert.ToString(mapArray[i, o]);
                    }





                }
            }
            if (hero.weapon != null)
            {
                hero.current_weapon = hero.weapon.Weapon_type;
                hero.current_range = hero.weapon.Range;
                hero.current_damage = hero.weapon.Damage;
                hero.Damage = hero.current_damage;

            }



        }

        public void UpdateVision(RichTextBox rtb)
        {


            rtb.Text = "";
            for (int i = 0; i < MaxWidth_X; i++)
            {
                for (int o = 0; o < MaxHeight_Y; o++)
                {
                    if (i == hero.X_coordinate + 1 && o == hero.Y_coordinate && enemeyArray[i, o] != null)
                    {
                        rtb.Text += enemeyArray[i, o].ToString() + "\n";
                    }
                    if (i == hero.X_coordinate - 1 && o == hero.Y_coordinate && enemeyArray[i, o] != null)
                    {
                        rtb.Text += enemeyArray[i, o].ToString() + "\n";
                    }
                    if (i == hero.X_coordinate && o == hero.Y_coordinate + 1 && enemeyArray[i, o] != null)
                    {
                        rtb.Text += enemeyArray[i, o].ToString() + "\n";
                    }
                    if (i == hero.X_coordinate && o == hero.Y_coordinate - 1 && enemeyArray[i, o] != null)
                    {
                        rtb.Text += enemeyArray[i, o].ToString() + "\n";
                    }
                    if (i == hero.X_coordinate + 1 && o == hero.Y_coordinate + 1 && enemeyArray[i, o] != null)
                    {
                        rtb.Text += enemeyArray[i, o].ToString() + "\n";
                    }
                    if (i == hero.X_coordinate + 1 && o == hero.Y_coordinate - 1 && enemeyArray[i, o] != null)
                    {
                        rtb.Text += enemeyArray[i, o].ToString() + "\n";
                    }
                    if (i == hero.X_coordinate - 1 && o == hero.Y_coordinate + 1 && enemeyArray[i, o] != null)
                    {
                        rtb.Text += enemeyArray[i, o].ToString() + "\n";
                    }
                    if (i == hero.X_coordinate - 1 && o == hero.Y_coordinate - 1 && enemeyArray[i, o] != null)
                    {
                        rtb.Text += enemeyArray[i, o].ToString() + "\n";

                    }
                }
            }

        }

        private Tile create(Tile.TileType type)

        {

            int enemeyrandom = RandomNumber(0, 3);
            int rndX = RandomNumber(MinWidth_X1 + 1, MaxWidth_X1 - 1);
            int rndY = RandomNumber(MinHeight_Y1 + 1, MaxHeight_Y1 - 1);

            while (rndX == 0)
            {
                rndX = RandomNumber(MinWidth_X1, MaxWidth_X1);
            }
            while (rndY == 0)
            {
                rndY = RandomNumber(MinHeight_Y1, MaxHeight_Y1);
            }


            if (type == Tile.TileType.HERO)
            {

                Hero = new Hero(rndX, rndY, 100, 2);
                return Hero;

            }
            else if (type == Tile.TileType.ENEMY)
            {

                if (enemeyrandom == 0)
                {
                    while (rndX > MaxWidth_X1)
                    {
                        rndX = RandomNumber(MinWidth_X1, MaxWidth_X1);
                    }
                    while (rndY > MaxHeight_Y1)
                    {
                        rndY = RandomNumber(MinHeight_Y1, MaxHeight_Y1);
                    }
                    return enemeyArray[rndX, rndY] = new Goblin(rndX, rndY);
                }
                else if (enemeyrandom == 1)
                {
                    while (rndX > MaxWidth_X1 && rndX != hero.X_coordinate)
                    {
                        rndX = RandomNumber(MinWidth_X1, MaxWidth_X1);
                    }
                    while (rndY > MaxHeight_Y1 && rndY != hero.Y_coordinate)
                    {
                        rndY = RandomNumber(MinHeight_Y1, MaxHeight_Y1);
                    }
                    return enemeyArray[rndX, rndY] = new Mage(rndX, rndY);
                }
                else
                {
                    while (rndX > MaxWidth_X1 && rndX != hero.X_coordinate)
                    {
                        rndX = RandomNumber(MinWidth_X1, MaxWidth_X1);
                    }
                    while (rndY > MaxHeight_Y1 && rndY != hero.Y_coordinate)
                    {
                        rndY = RandomNumber(MinHeight_Y1, MaxHeight_Y1);
                    }
                    return enemeyArray[rndX, rndY] = new Leader(rndX, rndY);
                }

            }
            else if (type == Tile.TileType.GOLD)
            {
                while (rndX > MaxWidth_X1 && rndX != hero.X_coordinate)
                {
                    rndX = RandomNumber(MinWidth_X1, MaxWidth_X1);
                }
                while (rndY > MaxHeight_Y1 && rndY != hero.Y_coordinate)
                {
                    rndY = RandomNumber(MinHeight_Y1, MaxHeight_Y1);
                }
                return itemarray[rndX, rndY] = new Gold(rndX, rndY);


            }
            else if (type == Tile.TileType.SHOP)
            {

                while (rndX > MaxWidth_X1 && rndX != hero.X_coordinate)
                {
                    rndX = RandomNumber(MinWidth_X1, MaxWidth_X1);
                }
                while (rndY > MaxHeight_Y1 && rndY != hero.Y_coordinate)
                {
                    rndY = RandomNumber(MinHeight_Y1, MaxHeight_Y1);
                }
                shop = new Shop(rndX, rndY);
                return mapArray[rndX, rndY] = shop;

            }

            return null;
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
