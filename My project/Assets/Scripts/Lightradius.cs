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

    bool flashing;

    // Update is called once per frame
    void Update()
    {
        light2D.pointLightInnerRadius = pickup.SliderValue * innerRadius;
        light2D.pointLightOuterRadius = light2D.pointLightInnerRadius + outerDistance;
        
        if (timeSinceLastFlash >= 5f && light2D.pointLightInnerRadius <= 0 && Input.GetKeyDown(KeyCode.Space) && !flashing)
        {
            StartCoroutine(Flash());
        }

        timeSinceLastFlash += Time.deltaTime;
    }

    IEnumerator Flash()
    {
        light2DFlash.SetActive(true);
        flashing = true;
        yield return new WaitForSeconds(0.1f);
        light2DFlash.SetActive(false);
        flashing = false;
        timeSinceLastFlash = 0;
    }
}
