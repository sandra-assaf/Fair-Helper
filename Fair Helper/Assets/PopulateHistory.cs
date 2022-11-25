using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulateHistory : MonoBehaviour
{
    // Start is called before the first frame update
    public History history;
    public HistoryCell cellPrefab;
    void Start()
    {
        
    }

    public void populate()
    {
        HistoryCell newCell;
        foreach (Order order in history.orders)
        {
            newCell = (HistoryCell)Instantiate(cellPrefab, transform);
            newCell.setOrder(order);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
