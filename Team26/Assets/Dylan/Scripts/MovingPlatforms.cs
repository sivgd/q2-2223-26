using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatforms : MonoBehaviour
{// Start is called before the first frame update

    public List<Transform> patrolPts = new List<Transform>();
    Transform[] patrolPoints = new Transform[] { };
    public int patrolPath;
    public float pathTime;
    public float currentTime;
    int nPoints;

    void Start()
    {
       
        Debug.Log(patrolPath);
        patrolPoints = patrolPts.ToArray();
        nPoints = patrolPoints.Length;

      //  turnTowardsTarget();

    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > pathTime)
        {


            currentTime = 0; //reset the timer
            patrolPath++;
            if (patrolPath > nPoints - 1) patrolPath = 0;



          //  turnTowardsTarget();

        }
        transform.position = Vector3.Lerp(patrolPoints[patrolPath].position, patrolPoints[(patrolPath + 1) % nPoints].position, currentTime / pathTime);

    }

    public void turnTowardsTarget()
    {

        Vector2 startLocation = patrolPoints[patrolPath % nPoints].position;
        Vector2 endLocation = patrolPoints[(patrolPath + 1) % nPoints].position;
        Vector2 pathDirection = endLocation - startLocation;
        float angle = Mathf.Atan2(pathDirection.y, pathDirection.x) * Mathf.Rad2Deg;
        Debug.Log(pathDirection + " " + angle);
        Debug.Log("------");
        transform.rotation = Quaternion.Euler(0, 0, angle);
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
