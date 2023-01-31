using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularPlatform : MonoBehaviour
{

    public float timeCounter = 0;

    public float speed;
    public float width;
    public float height;
    Vector3 origin;
    


    // Start is called before the first frame update
    void Start()
    {

        Vector3 origin = transform.position;


    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime * speed;

        float x = (Mathf.Cos(timeCounter) * width);
        float y = (Mathf.Sin(timeCounter) * height);

        transform.position = new Vector3(x, y) ;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.SetParent(transform);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.SetParent(null);
    }


}
