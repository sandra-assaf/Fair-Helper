using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stock : MonoBehaviour
{
    public Dictionary<Product, int> products;
    public void Awake()
    {
        products = new Dictionary<Product, int>();
        retrieveStock();
    }

    private void retrieveStock()
    {
        TextAsset textAsset = Resources.Load<TextAsset>("Product List");
        char[] lineDelim = new char[] { '\r', '\n' };
        string[] text = textAsset.text.Split(lineDelim, System.StringSplitOptions.RemoveEmptyEntries);
        foreach(string line in text)
        {
            string[] components = line.Split(' ');
            string name = components[0];
            int price = int.Parse(components[1]);
            int quantity = int.Parse(components[2]);
            Product product = new Product(name, price);
            products.Add(product, quantity);
        }
    }
}
