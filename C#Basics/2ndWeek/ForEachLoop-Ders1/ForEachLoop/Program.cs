//forach denildiğinde aklımıza ilk gelecek şey koleksiyondur. Bir koleksiyonun elemanlarıyla işlem yapacaksak foreach dongu yontemine basvururuz.

string[] members = {"A","B","C"};

Array.Resize(ref members, members.Length+1); // gitti arrayi kopyaladı, elemanları kopyaladı, array kapasitesine 1 ekledi, eskisini sildi.

List<string> productList = new List<string> { "TV", "XBOX ONE", "SoundBar" };

List<string> shoppingCart = new List<string>();

foreach (var item in productList) // burada item readonly valuedir. üzerine islem yapamazsın. silemezsin.
{
    shoppingCart.Add(item);
    /*productList.Remove(item);*/ // bu yuzden bu kod calısmaz
}

//alıstırma - illeri yaz - a harfi ile baslayanları bir baska koleksiyona al 

//işlemin doğrusu

foreach (var item in shoppingCart)
{
    productList.Remove(item);
}