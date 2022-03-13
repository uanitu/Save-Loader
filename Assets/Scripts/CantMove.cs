using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CantMove : MonoBehaviour
{
    private Rigidbody2D rb;
    public string ifTouching;

    private void Start()
     {
         rb = GetComponent<Rigidbody2D>();
     }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == ifTouching)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }
}
