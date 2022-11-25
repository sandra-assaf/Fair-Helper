using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersistanceManager
{ 
    public static DataPersistanceManager instance { get; private set; }

    private void Awake()
    {
        instance = this;
    }
   
}
