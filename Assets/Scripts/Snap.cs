using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snap : MonoBehaviour
{
    /*
    private void OnDrawGizmos()
    {
        SnapToGrid();
    }
    */


    void Start()
    {

    }


    void Update()
    {
        SnapToGrid();
    }
    
    private void SnapToGrid()
    {
        var position = new Vector2(
            Mathf.RoundToInt(this.transform.position.x),
            Mathf.RoundToInt(this.transform.position.y)
        );

        this.transform.position = position;

    }

}
