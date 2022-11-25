using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderCell : MonoBehaviour
{
    public Text productNameText;
    public Text quantityText;
    public Button btn;

    public InputField inputField;
    private bool isEditing = false;
    private bool updateCell = false;

    public OrderBuilder orderBuilder;
    private Product prod;
    
    public void setCell(Product p, int q)
    {
        productNameText.text = p.name;
        quantityText.text = q + "";
        prod = p;
    }

    public void Update()
    {
        if(updateCell)
        {
            updateCell = false;
            if (!isEditing)
            {
                isEditing = !isEditing;
                string q = quantityText.text;
                quantityText.gameObject.SetActive(false);
                inputField.gameObject.SetActive(true);
                inputField.text = q;
                btn.GetComponentInChildren<Text>().text = "Done";

            }
            else
            {
                isEditing = !isEditing;
                quantityText.gameObject.SetActive(true);
                int newQuantity = int.Parse(inputField.text);
                quantityText.text = newQuantity+"";
                orderBuilder.setQuantity(prod, newQuantity);
                if(newQuantity == 0)
                {
                    Destroy(gameObject);
                }
                inputField.text = "";
                inputField.gameObject.SetActive(false);
                btn.GetComponentInChildren<Text>().text = "Edit";

            }
            orderBuilder.updateText();
        }
    }

    public void buttonClicked()
    {
        updateCell = true;
    }
}
