using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateStorm : MonoBehaviour
{

    public Material cloudZone;
    public Material stormZone;
    
    // Start is called before the first frame update
    void Start()
    {

        RenderSettings.skybox = cloudZone;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(DelayedAction());
    }

    private IEnumerator DelayedAction()
    {
        yield return new WaitForSeconds(4);
        RenderSettings.skybox = stormZone;
    }


}
