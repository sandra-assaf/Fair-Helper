using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MemoryController : MonoBehaviour
{
    public GameObject popupBox;
    public Animator animator;

    public string memText;
    public Sprite memImage;

    public Text popUpText;
    public Image popUpImage;

    private bool canPop = true;
    private bool playerInRange = false;

    public void Start()
    {
        popUpText.text = memText;
        popUpImage.sprite = memImage;
    }

    public void popUp()
    {
        popupBox.SetActive(true);
        animator.SetTrigger("pop");
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerInRange && canPop)
        {
            canPop = false;
            popUp(); 
        }
    }

    public void reactivatePop()
    { 
        canPop = true;
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
