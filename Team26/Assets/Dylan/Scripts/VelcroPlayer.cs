using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelcroPlayer : MonoBehaviour
{
    void OnCollisionStay(Collision platformCollision)
    {
        GameObject platformCenter = platformCollision.transform.GetChild(0).gameObject;
        gameObject.transform.parent = platformCenter.transform;
    }

    void OnCollisionExit()
    {
        gameObject.transform.parent = null;
    }
}
