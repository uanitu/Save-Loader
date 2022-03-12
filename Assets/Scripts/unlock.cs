using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlock : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.tag == "Key")
        {
            Destroy(collision.gameObject);
            //play animations and destroy block
            Destroy(gameObject);
        }   
    }
}
