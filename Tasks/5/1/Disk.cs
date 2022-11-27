namespace Tasks._5._1;

public class Disk : IStoreItem
{
    protected string Name;
    protected string Genre;
    protected int BurnCount;
    public double Price { get; set; }

    public virtual int DiskSize { get; }
    
    public Disk(string name, string genre)
    {
        Name = name;
        Genre = genre;
        BurnCount = 0;
    }

    public void DiscountPrice(int percent)
    {
        Price *= 0.01 * percent;
    }

    public virtual void Burn(params string[] values){}
}