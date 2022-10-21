using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Lightradius : MonoBehaviour
{
    [SerializeField] private PickUp pickup;
    [SerializeField] private Light2D light2D;
    
    [SerializeField] private float outerDistance = 2f;
    [SerializeField] private float innerRadius = 4.5f;

    // Update is called once per frame
    void Update()
    {
        light2D.pointLightInnerRadius = pickup.SliderValue * innerRadius;
        light2D.pointLightOuterRadius = light2D.pointLightInnerRadius + outerDistance;
    }
}
