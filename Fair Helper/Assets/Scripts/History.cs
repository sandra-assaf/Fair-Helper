using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class History : MonoBehaviour
{
    public ArrayList orders;
    public OrderBuilder orderBuilder;
    void Start()
    {
        orders = new ArrayList();
    }

    public void removeOrder(int index)
    {
        orders.RemoveAt(index);
    }

    public void removeOrder(Order order)
    { 
        orders.Remove(order);
    }

    public void addOrder(Order order)
    { 
        orders.Add(order);
    }

    public void commitOrder()
    {
        Order order = new Order(orderBuilder.products);
        order.OrderID = orders.Count;
        order.totalSum = orderBuilder.total;
        addOrder(order);
        orderBuilder.clearOrder();
    }

}
