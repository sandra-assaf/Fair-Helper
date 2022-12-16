using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject popupBox;
    public Animator animator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void popUp()
    {
        if (!MemoryController.isPopped)
        {
            popupBox.SetActive(true);
            animator.SetTrigger("pop");
        }
    }

    public void closePopup()
    {
        popupBox.SetActive(false);
    }
}
