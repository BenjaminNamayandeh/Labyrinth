using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private float speed;
    public int woodCount;

    public float SliderValue => slider.value;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Wood")
        {
            woodCount += 1;
            var wood = collision.gameObject;
            Destroy(wood);
            slider.value += 0.3f;
        }
    }

    private void Update()
    {
        slider.value -= Time.deltaTime * speed;
    }
}
