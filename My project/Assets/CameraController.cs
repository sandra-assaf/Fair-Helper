using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject character;
    void Start()
    {
        this.transform.position = new Vector3(2.98f, -0.14f, -10f);
    }

    
    void Update()
    {
        if (character.transform.position.x >= 2.98f && character.transform.position.x <= 22.16f)
        {
            transform.position = new Vector3(character.transform.position.x, transform.position.y, transform.position.z);
        }
    }
}
