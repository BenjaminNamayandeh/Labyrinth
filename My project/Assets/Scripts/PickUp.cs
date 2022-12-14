using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class PickUp : MonoBehaviour // This class enables the player to pick up wood in the maze
{
    [SerializeField] private Slider slider;
    [SerializeField] private Timer timer;
    [SerializeField] private TMP_Text bestScoreText;
    [SerializeField] private float speed;
    [SerializeField] private string highScoreSaveKey;
    public int woodCount;

    public float SliderValue => slider.value;

    private void Start()
    {
        var highscore = Math.Round(PlayerPrefs.GetFloat(highScoreSaveKey), 2).ToString();
        bestScoreText.text = $"PB: {highscore}";
    }

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
            var bestTime = PlayerPrefs.GetFloat(highScoreSaveKey);
            var currentTime = timer.currentTime;
            if (currentTime <= bestTime || bestTime == 0f)
            {
                bestTime = currentTime;
                PlayerPrefs.SetFloat(highScoreSaveKey, bestTime);
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private void Update() // Slider decreases with time
    {
        slider.value -= Time.deltaTime * speed;
    }
}
