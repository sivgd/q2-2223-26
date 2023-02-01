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
    public bool grounded = false;
    public GameObject player;

    void Start()
    {
       

        patrolPoints = patrolPts.ToArray();
        nPoints = patrolPoints.Length;
        player = GameObject.Find("Player");

        //  turnTowardsTarget();
      
    }

    // Update is called once per frame
    void Update()
    {
        grounded = Physics2D.BoxCast(transform.position, new Vector2(0.1f, 1.4f), 0, Vector2.up, 1, LayerMask.GetMask("Player"));

        currentTime += Time.deltaTime;
        if (currentTime > pathTime)
        {


            currentTime = 0; //reset the timer
            patrolPath++;
            if (patrolPath > nPoints - 1) patrolPath = 0;



          //  turnTowardsTarget();

        }
        transform.position = Vector3.Lerp(patrolPoints[patrolPath].position, patrolPoints[(patrolPath + 1) % nPoints].position, currentTime / pathTime);



       // if (grounded == true)
       // {
       //   //transform.SetParent(transform);
       //   Debug.Log("IT WORKS");
       //     player.transform.SetParent(this.transform);
           

          
       //}

       // if (grounded == false)
       // {
       //     player.transform.SetParent(null);
       // }

       // //player.transform.localScale = new Vector3(120, 120, 1);

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
