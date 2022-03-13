using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 public class ToggleSpriteWhileColliding : MonoBehaviour 
 {
     private SpriteRenderer _mySpriteRenderer;
     public Sprite newSprite;
     private Sprite oldSprite;
 
     private void Start ()
     {
         _mySpriteRenderer = GetComponent<SpriteRenderer>();
         oldSprite = _mySpriteRenderer.sprite;
     }
 
     private void OnCollisionEnter2D(Collision2D collision)
     {
         if(collision.gameObject.tag == "Player" || collision.gameObject.tag == "Box")
         {
            _mySpriteRenderer.sprite = newSprite;
         }
     }

     private void OnCollisionExit2D(Collision2D collision) 
     {
         _mySpriteRenderer.sprite = oldSprite;
     }

 }