using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Order
{
    public int OrderID;
    public Dictionary<Product, int> products;
    public int totalSum;
    public string timeOfOrder;
    public Order(Dictionary<Product, int> prod) 
    {
        timeOfOrder = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        products = prod;
    }

    public void removeProduct(Product prod)
    { 
        products.Remove(prod);
    }

    public void addProduct(Product prod, int quantity)
    { 
        products.Add(prod, quantity);
    }

    public void editQuantity(Product prod, int newQuant)
    { 
        products[prod] = newQuant;
    }

}
