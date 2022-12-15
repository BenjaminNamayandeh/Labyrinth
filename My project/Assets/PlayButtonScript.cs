using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// When you press play button on the main menu, the game proceeds to Story Scene 1
/// </summary>
public class PlayButtonScript : MonoBehaviour
{
   [SerializeField] private string playButtonLevel1 = "Story Scene 1";

   public void PlayButton()
   {
    SceneManager.LoadScene(playButtonLevel1);
   }
}