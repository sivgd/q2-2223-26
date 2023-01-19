using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildingPlatform : MonoBehaviour
{
    public float platformSpeed = 2.5f;
    public bool direction = true; //true = left, false = Right
    public GameObject player = null;
    private Vector3 scale;
    void FixedUpdate()
    {
        //Left Direction
        if (this.transform.position.x >= 6 || this.transform.position.x > -6 && direction)
        {
            this.transform.Translate(Vector3.left * (platformSpeed * Time.deltaTime));
            if (this.transform.position.x <= -6)
            {
                direction = false;
            }
        }
        //Right Direction
        else if (this.transform.position.x <= -6 || this.transform.position.x < 6 && !direction)
        {
            this.transform.Translate(Vector3.right * (platformSpeed * Time.deltaTime));
            if (this.transform.position.x >= 6)
            {
                direction = true;
            }
        }
    }
}
