namespace DataNS
{
    public abstract class DataAbstractAPI
    {
        public int radius;
        public int Backgroundwidth;
        public int Backgroundheight;
        public string color;
        public double maxspeed;
        public int maxWeight;
        public int minWeight;
        public List<Ball> Balls { get; set; }
        public static DataAbstractAPI CreateApi()
        {
            return new DataAPI();
        }
        public abstract Ball createBall();
    }
}
