using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudParallax : MonoBehaviour
{
    [SerializeField] public Vector2 parallaxEffectMultiplier;
    public float backgroundSize;

    private Transform cameraTransform;
    private Vector3 lastCameraPosition;
    private Transform[] layers;
    private float viewZone = 10;
    private int leftIndex;
    private int rightIndex;
    private float lastCameraPos;
    

}
