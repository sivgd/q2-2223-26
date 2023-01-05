using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraversePlatform : MonoBehaviour
{// Start is called before the first frame update

    public List<Transform> patrolPts = new List<Transform>();
    Transform[] patrolPoints = new Transform[] { };
    public int patrolPath;
    public float pathTime;
    public float currentTime;
    int nPoints;
    public GameObject player;

    void Start()
    {
       
        Debug.Log(patrolPath);
        patrolPoints = patrolPts.ToArray();
        nPoints = patrolPoints.Length;


        //  turnTowardsTarget();

    }

  


    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.SetParent(transform);

        currentTime += Time.deltaTime;
        if (currentTime > pathTime)
        {


            currentTime = 0; //reset the timer
            patrolPath++;
            



            //  turnTowardsTarget();

        }
        transform.position = Vector3.Lerp(patrolPoints[patrolPath].position, patrolPoints[(patrolPath + 1) % nPoints].position, currentTime / pathTime);

    }





    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.SetParent(null);
    }
}
