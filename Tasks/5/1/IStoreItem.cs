namespace Tasks._5._1;

public interface IStoreItem
{
    public double Price { get; set; }

    public void DiscountPrice(int percent)
    {
        Price *= 0.01 * percent;
    }
}