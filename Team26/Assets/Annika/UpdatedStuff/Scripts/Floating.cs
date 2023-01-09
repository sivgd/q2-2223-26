using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating : MonoBehaviour
{
    // "wave" size
    public float amp;
    // up and down movement speed
    public float freq;
    Vector3 initPos;

    private void Start()
    {
        initPos = transform.position;
    }

    // moves through x-axis and changes y-axis position. sideways S.
    private void Update()
    {

        transform.position = new Vector3(initPos.x, Mathf.Sin(Time.time * freq) * amp + initPos.y, 0);
    }
}
