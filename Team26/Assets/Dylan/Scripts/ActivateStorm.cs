using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateStorm : MonoBehaviour
{
    public Transform rain;
   
    public Material cloudZone;
    public Material stormZone;
    public AudioSource _AudioSource;

    public AudioClip _AudioClip1;
    public AudioClip _AudioClip2;

    // Start is called before the first frame update
    void Start()
    {

        RenderSettings.skybox = cloudZone;
        _AudioSource.clip = _AudioClip1;

        _AudioSource.Play();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(DelayedAction());
        StartCoroutine(DelayedActionYes());


    }
    private IEnumerator DelayedAction()
    {
        yield return new WaitForSeconds(4);
        RenderSettings.skybox = stormZone;
        rain.GetComponent<ParticleSystem>();
        _AudioSource.clip = _AudioClip2;
        _AudioSource.Play();
    }

    private IEnumerator DelayedActionYes()
    {
        yield return new WaitForSeconds(34);
        RenderSettings.skybox = cloudZone;

        _AudioSource.clip = _AudioClip1;
        _AudioSource.Play();



    }

}
