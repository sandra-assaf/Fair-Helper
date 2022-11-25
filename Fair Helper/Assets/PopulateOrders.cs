using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulateOrders : MonoBehaviour
{
    public OrderBuilder order;
    public OrderCell orderCell;
    void Start()
    {
        
    }

    public void populate()
    {
        order.updateText();
        clearList();
        OrderCell newCell;
        foreach (KeyValuePair<Product, int> product in order.products)
        {
            newCell = (OrderCell)Instantiate(orderCell, transform);
            newCell.orderBuilder = order;
            newCell.setCell(product.Key, product.Value);
        }
        
    }

    public void clearList()
    {
        foreach (Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
