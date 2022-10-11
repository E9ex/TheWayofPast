using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;




    public class PlayerCollision : MonoBehaviour
{
    public First movement;
    private void OnCollisionEnter(Collision obstacle)

    {
        if (obstacle.collider.tag=="obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().Endgame();

        }
    }
}
