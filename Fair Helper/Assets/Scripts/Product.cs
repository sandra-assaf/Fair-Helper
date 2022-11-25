using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Product
{
    public string name;
    public int price;

    public Product()
    {
        this.name = "";
        this.price = 0;
    }

    public Product(string name, int price)
    {
        this.name = name;
        this.price = price;
    }
} 

