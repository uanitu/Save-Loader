using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOnIce : MonoBehaviour
{
    private Rigidbody2D myy;
    private bool isIce;
        private float previousAngularDrag;
        private float previousDrag;
        public float dragValue;
        public float angularDValu;
    // Start is called before the first frame update
    void Start()
    {
        myy = GetComponent<Rigidbody2D>();
        previousAngularDrag = myy.angularDrag;
        previousDrag = myy.drag;
    }
    // Update is called once per frame
    void Update()
    { 
        if (isIce)
        {            
            myy.drag = dragValue;
            myy.angularDrag = angularDValu;
        }

        else
        {
            myy.drag = previousDrag;
            myy.angularDrag = previousAngularDrag;
        }

}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ice")
        {
            isIce = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Ice")
        {
            isIce = false;
        }
    }
}

