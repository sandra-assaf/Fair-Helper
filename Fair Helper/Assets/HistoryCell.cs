using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HistoryCell : MonoBehaviour
{
    public Text orderDate;
    public Text orderTotal;

    public Order order;
    void Start()
    {
        
    }

    public void setOrder(Order o)
    {
        order = o;
        orderDate.text = order.timeOfOrder;
        orderTotal.text = "Total Sum:" + order.totalSum;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
