namespace ShoppingCart;

public class CartItem
{
    public Product Product { get; }
    private int _count;

    public CartItem(Product product, int count)
    {
        Product = product;
        _count = count;
    }

    public int ShowItemsAndReturnPriceOfItems()
    {
        var productPrice = Product.Price;
        var amount = _count;
        var price = amount * productPrice;
        Console.WriteLine($"{amount} stk. {Product.Name} for {productPrice}kr = {price}kr");
        return price;
    }

    public void IncreaseCount(int count)
    {
        _count += count;
    }

}