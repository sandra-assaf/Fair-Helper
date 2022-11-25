using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HistoryController : MonoBehaviour
{
    public GameObject historyList;
    public GameObject productList;
    public Button historyBtn;

    private bool historyActive = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void historyButton()
    {
            productList.SetActive(historyActive);
            historyList.SetActive(!historyActive);
            historyBtn.GetComponentInChildren<Text>().text = historyActive? "History":"Back";
            historyActive = !historyActive;

    }
}
