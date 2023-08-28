public static class Shop {
  public void CreateKeeper(string name, string species) {
    this = new ShopKeeper();
    this.name = name;
    this.species = species;
  }
  
  public ShopItem CreateItem(string name, int price, int stock, bool isInfinite) {
    ShopItem item = new ShopItem();
    item.name = name;
    item.price = price;
    item.stock = stock;
    item.isInfinite = isInfinite;
    return item;
  }
}
