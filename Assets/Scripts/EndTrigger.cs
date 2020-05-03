using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Check if player collides with pit collider
        if (collision.tag == "Player")
        {
            //Reload the scene if player collides with pit
            Debug.Log("You Win");
        }
    }
}

