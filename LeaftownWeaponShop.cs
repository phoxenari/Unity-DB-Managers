public static class LeaftownWeaponShop : Shop {
  bool isInstantiated;
  string shopName;
  ShopKeeper shopKeeper;
  List<ShopItem> weapons = new List<ShopItem>;
  
  static void InstantiateShop() {
    //weapon shop name
    shopName = "Larry's Sharp Objects";
    
    //weapon shop keeper
    shopKeeper = CreateKeeper("Larry", "Tarsier");
    shopKeeper.greeting = "Would you like to buy some of my /dangerously/ sharp objects?";
    shopKeeper.goodbye = "Oh... *squints* I see how it is.";
    shopKeeper.soldout = "Looks like I'm all out... *whispering to self* Guess I'll have to steal—I mean make some more later.";
    
    //weapon shop items
    weapons.Add(CreateItem("Great Sword", 100, 2, false));
    shopKeeper.itemDialogue.Add("Very large and heavy... If you can't swing it, I found dropping it from high up in a tree does the trick.");
    
    weapons.Add(CreateItem("Dagger", 10, 5, false));
    shopKeeper.itemDialogue.Add("Much lighter than any blade you'll handle. Great for quick jabs and running away afterwards.");
    
    weapons.Add(CreateItem("Butter Knife", 1, 1, true));
    shopKeeper.itemDialogue.Add("*pulls out a bucket full of butter knives* Great versatility! There's nothing a butter knife can't do! I've got more in the back.");
    
    //instantiation complete
    isInstantiated = true;
  }
}
