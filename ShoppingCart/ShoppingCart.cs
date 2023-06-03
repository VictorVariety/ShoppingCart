namespace ShoppingCart;


public class ShoppingCart
{
    private readonly List<CartItem> _items;

    public ShoppingCart()
    {
        _items = new List<CartItem>();
    }

    public void Run()
    {
        var productA = new Product("A", 40);
        var productB = new Product("B", 70);
        var productC = new Product("C", 30);
        ShowCart();
        Buy(productA, 1);
        ShowCart();
        Buy(productB, 3);
        ShowCart();
        Buy(productA, 1);
        ShowCart();
        Buy(productC, 4);
        ShowCart();

    }
    private void ShowCart()
    {
        if (_items.Count == 0)
        {
            Console.WriteLine("Handlekurven er tom.");
            Console.WriteLine();
            return;
        }

        Console.WriteLine("Handlekurv:");
        var totalPrice = 0;
        foreach (var item in _items)
        {
            
            var price = item.ShowItemsAndReturnPriceOfItems();
            totalPrice += price;
        }

        Console.WriteLine($"Totalpris: {totalPrice}");
        Console.WriteLine();
    }
    private void Buy(Product product, int count)
    {
        
        var existingItem = _items.Find(item => item.Product.Equals(product));
        if (existingItem == null)
        {
            _items.Add(new CartItem(product, count));
        }
        else
        {
            existingItem.IncreaseCount(count);
        }
        Console.WriteLine($"Du kjøpte {count} stk. {product.Name}");
        Console.WriteLine();
    }
}