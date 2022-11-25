using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulateGrid : MonoBehaviour
{
    public CellController cellPrefab;
    public Stock stock;
    public OrderBuilder orderBuilder;
    void Start()
    {
        populate();
    }

    private void populate()
    {
        CellController newCell;
        foreach (KeyValuePair<Product, int> prod in stock.products)
        {
            newCell = (CellController)Instantiate(cellPrefab, transform);
            newCell.orderBuilder = orderBuilder;
            newCell.setCellValues(prod.Key, prod.Value);
        }
    }

    public void resetDropDowns()
    {
        Dropdown[] dropdowns = gameObject.GetComponentsInChildren<Dropdown>();
        foreach (Dropdown drop in dropdowns)
            drop.value = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
