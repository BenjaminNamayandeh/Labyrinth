using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Lightradius : MonoBehaviour
{
    [SerializeField] private PickUp pickup;
    [SerializeField] private Light2D light2D;
    [SerializeField] private GameObject light2DFlash;

    [SerializeField] private float outerDistance = 2f;
    [SerializeField] private float innerRadius = 4.5f;

    private float timeSinceLastFlash;
    float elapsedTime;

    // Update is called once per frame
    void Update()
    {
        light2D.pointLightInnerRadius = pickup.SliderValue * innerRadius;
        light2D.pointLightOuterRadius = light2D.pointLightInnerRadius + outerDistance;

        if (light2D.pointLightInnerRadius <= 0f && Input.GetKeyDown(KeyCode.E) && timeSinceLastFlash >= 3f)
        {
            float elapsedTime = 0f;
        }

        if (elapsedTime >= 0.2f)
        {
            light2D.gameObject.SetActive(false);
            light2DFlash.SetActive(true);

            elapsedTime += Time.deltaTime;
        }

        timeSinceLastFlash += Time.deltaTime;
    }
}
