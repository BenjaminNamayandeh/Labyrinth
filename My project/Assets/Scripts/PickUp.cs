using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;

/// <summary>
/// This class enables the player to pick up wood in the maze.
/// </summary>
public class PickUp : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private Timer timer;
    [SerializeField] private TMP_Text bestScoreText;
    [SerializeField] private float speed;
    [SerializeField] private string highScoreSaveKey;
    public int woodCount;

    public float SliderValue => slider.value;

    /// <summary>
    /// Stores the time as a personal best, the next time you start the level, you see your PB.
    /// </summary>
    private void Start()
    {
        var highscore = Math.Round(PlayerPrefs.GetFloat(highScoreSaveKey), 2).ToString();
        bestScoreText.text = $"PB: {highscore}";
    }

    /// <summary>
    /// If the player hits the wood, add to the wood count and increase wood bar value. If the player reaches the door, the level ends.
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Wood")
        {
            woodCount += 1;
            var wood = collision.gameObject;
            Destroy(wood);
            slider.value += 0.3f;
        }

        if (collision.tag == "Door")
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

    /// <summary>
    /// As time goes on, decerease the slider bar.
    /// </summary>
    private void Update()
    {
        slider.value -= Time.deltaTime * speed;
    }
}
