using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[System.Serializable]
public class MyStringEvent : UnityEvent<string>
{
}

public class MemoryController : MonoBehaviour
{
    public static bool isPopped = false;
    public GameObject popupBox;
    public Animator animator;

    public string memText;
    public Sprite memImage;

    public Text popUpText;
    public Image popUpImage;

    private bool playerInRange = false;
    public MyStringEvent m_MyEvent;

    public void Start()
    {
        popUpText.text = memText;
        popUpImage.sprite = memImage;
        if (m_MyEvent == null)
            m_MyEvent = new MyStringEvent();

    }

    public void popUp()
    {
        popupBox.SetActive(true);
        animator.SetTrigger("pop");
        MemoryController.isPopped = true;
        m_MyEvent.Invoke(this.gameObject.tag);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerInRange && !MemoryController.isPopped)
        {
            popUp(); 
        }
    }

    public void reactivatePop()
    { 
        MemoryController.isPopped = false;
        if(m_MyEvent != null) 
        { 
            m_MyEvent?.Invoke("Close"); 
        }
        popupBox.SetActive(false);
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
    }
}
