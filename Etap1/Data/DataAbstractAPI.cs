namespace DataNS;

public abstract class DataAbstractAPI
{
    public int radius;
    public int Backgroundwidth;
    public int Backgroundheight;
    public string color;
    public int maxspeed;

    public static DataAbstractAPI CreateApi()
    {
        return new DataAPI();
    }
}