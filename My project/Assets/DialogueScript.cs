using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueScript : MonoBehaviour
{
    public Button nextButton;
    public Image charImage;
    public Text charText;
    public Sprite[] charImages;
    public string[] charLines;
    public MemoryController memoryController;
    private bool activatedPopup = false;
    public bool switchState = false;
    private int state = 0;
    private bool isOpen = false;
    void Start()
    {
        memoryController.m_MyEvent.AddListener(ActivatedPopup);
    }

    public void buttonClicked()
    {
        switchState = true;
    }

    void ActivatedPopup(string tagName)
    {
        if(tagName=="Drook") 
        {
            activatedPopup = true;  
            isOpen = true;
        } if(isOpen && tagName == "Close")
        {
            closePopup();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (activatedPopup)
        {
            activatedPopup = false;
            nextButton.gameObject.SetActive(true);
            nextButton.enabled = true;
            nextButton.GetComponent<Image>().enabled = true;
            nextButton.interactable = true;
            state = 0;
            charImage.sprite = charImages[state];
            charText.text = charLines[state];
        }
        if(switchState)
        {
            switchState = false;
            state++;
            if(state == 2)
            {
                nextButton.GetComponent<Image>().enabled = false;
                nextButton.enabled = false;
            }
            if (state < 3)
            {
                charImage.sprite = charImages[state];
                charText.text = charLines[state];
            }

        }
    }

    public void closePopup()
    {
        isOpen = false;
        nextButton.GetComponent<Image>().enabled = false;
        nextButton.gameObject.SetActive(false) ;
        state = 0;
        memoryController.reactivatePop();
    }


}
