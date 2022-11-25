using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProductListController : MonoBehaviour
{
    public Stock stock;
    public Dropdown productDropDown;
    public Dropdown quantityDropdown;
    public OrderBuilder orderBuilder;

    private List<Product> products;
    void Start()
    {
        products = new List<Product>(this.stock.products.Keys);
        foreach (Product p in products)
        {
            productDropDown.options.Add(new Dropdown.OptionData() { text = p.name });
        }
        productDropDown.SetValueWithoutNotify(0);

        productDropDown.onValueChanged.AddListener(delegate {
            prodDropdownValueChanged();
        });
    }

    void prodDropdownValueChanged()
    {
        quantityDropdown.ClearOptions();
        int productIndex = productDropDown.value;
        int maxQuantity = stock.products[products[productIndex]];
        for(int i=0; i<=maxQuantity; i++)
        {
            quantityDropdown.options.Add(new Dropdown.OptionData() { text = i+"" });
        }
    }


    void Update()
    {
        
    }

    public void addToOrder()
    {
        int selectedIndex = productDropDown.value;
        Product p = products[selectedIndex];
        orderBuilder.setQuantity(p, quantityDropdown.value);
    }
}
