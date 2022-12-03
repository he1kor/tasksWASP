namespace Tasks._5._1;

public class DVD : Disk
{
    protected string Producer;
    protected string FilmCompany;
    protected int Minutes;

    public override int DiskSize => 32 * Minutes;

    public DVD(string producer, string filmCompany, int minutes, string name, string genre) : base(name, genre)
    {
        Producer = producer;
        FilmCompany = filmCompany;
        Minutes = minutes;
    }

    public override void Burn(params string[] values)
    {
        Minutes = values.Length;
        BurnCount++;
    }

    public override string ToString()
    {
        return Name + " (" + Genre + ") by " + Producer + " made in " + FilmCompany + ". Duration: " + Minutes + "; burn count: " + BurnCount;
    }
}