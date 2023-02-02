using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSound : MonoBehaviour
{

    public AudioSource jump;
    public AudioSource move;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Jumpsound()
    {
        jump.Play();
    }

    void MoveSound()
    {
        move.Play();
    }
}
