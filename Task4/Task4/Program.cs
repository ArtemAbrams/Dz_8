// Interface Segregation Principle цей солід порушено
Console.WriteLine("");
interface IPrice
{
    void ApplyDiscount(String discount);
    void ApplyPromocode(String promocode);
    void SetPrice(double price);
}


interface IAspect
{
    void SetColor(byte color);
    void SetSize(byte size);
}

class Book:IPrice
{
    private double price;
    public void ApplyDiscount(String discount)
    {
        Console.WriteLine("The book has discount " + discount);
    }
    public void SetPrice(double price)
    {
        this.price = price;
    }

    public void ApplyPromocode(String promocode)
    {
        Console.WriteLine("The book has promocode " + promocode);
    }
}

class Clouther:IAspect, IPrice
{
    private double price;
    private byte color;
    private byte size;

    public void SetSize(byte size)
    {
        this.size = size;
    }
    public void SetColor(byte color)
    {
        this.color = color;
    }
    public void ApplyDiscount(String discount)
    {
        Console.WriteLine("The book has discount " + discount);
    }
    public void SetPrice(double price)
    {
        this.price = price;
    }

    public void ApplyPromocode(String promocode)
    {
        Console.WriteLine("The book has promocode " + promocode);
    }
    
}