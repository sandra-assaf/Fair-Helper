using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderBuilder : MonoBehaviour
{
    public Dictionary<Product, int> products;
    public int total = 0;

    public Text textAsset;
    void Start()
    {
        products = new Dictionary<Product, int>();
    }

    public void setQuantity(Product p, int q)
    {
        if(products.ContainsKey(p))
        {
            if(q>0)
            {
                total += (q - products[p]) * p.price;
                products[p] = q;
            } else
            {
                total -= p.price * products[p];
                products.Remove(p);
            }
        } else if(q != 0)
        {
            total += p.price * q;
            products.Add(p, q);
        }
    }

    public void updateText()
    {
        textAsset.text = "Total: " + total;
    }

    public void clearOrder()
    {
        products = new Dictionary<Product, int>();
        total = 0;
        updateText();
    }

}
