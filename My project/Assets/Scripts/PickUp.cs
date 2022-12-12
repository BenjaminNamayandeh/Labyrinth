using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PickUp : MonoBehaviour // This class enables the player to pick up wood in the maze
{
    [SerializeField] private Slider slider;
    [SerializeField] private float speed;
    public int woodCount;

    public float SliderValue => slider.value;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Wood") // If player hits wood, add wood count and increase wood bar value
        {
            woodCount += 1;
            var wood = collision.gameObject;
            Destroy(wood); // Wood is destroyed
            slider.value += 0.3f;
        }

        if (collision.tag == "Door") // If door reached, the round ends
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private void Update() // Slider decreases with time
    {
        slider.value -= Time.deltaTime * speed;
    }
}
