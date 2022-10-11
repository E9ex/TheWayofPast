using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endtrigger : MonoBehaviour
{
    public GameManager GameManager;
    private void OnTriggerEnter()
    {
        GameManager.CompleteLevel();
    }
    //9.video
    
}
