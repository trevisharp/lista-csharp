// Explique em suas palavras a vantagem do
// sumPrice2 sobre o sumPrice1.

float sumPrice1(List<Item> items, string[] searchs)
{
    float price = 0;
    for (int i = 0; i < searchs.Length; i++)
    {
        var search = searchs[i];
        for (int j = 0; j < items.Count; j++)
        {
            var item = items[j];
            if (item.Title == search)
                price += item.Price;
        }
    }
    return price;
}

float sumPrice2(List<Item> items, string[] searchs)
{
    float price = 0;
    var dict = new Dictionary<string, float>();
    for (int i = 0; i < items.Count; i++)
    {
        var item = items[i];
        dict[item.Title] = item.Price;
    }

    for (int i = 0; i < searchs.Length; i++)
    {
        var search = searchs[i];
        price += dict[search];
    }
    return price;
}


public class Item
{
    public string Title { get; set; }
    public float Price { get; set; }
}