using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CellController : MonoBehaviour
{
    public Text productNameText;
    public Dropdown dropdown;
    public Text stockText;
    public OrderBuilder orderBuilder;

    public Product product;
    public int quantity;

    public void Start()
    {
        dropdown.onValueChanged.AddListener(delegate {
            dropdownValueChanged();
        });
    }

    public void setCellValues(Product p, int q)
    {
        product = p;
        quantity = q;
        productNameText.text = p.name;
        stockText.text = quantity + "";
        dropdown.options.Clear();
        for (int i = 0; i <= quantity; i++)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = i + "" });
        }
    }

    void dropdownValueChanged()
    {
        if (orderBuilder)
        {
            orderBuilder.setQuantity(product, dropdown.value);
        }
    }
}
