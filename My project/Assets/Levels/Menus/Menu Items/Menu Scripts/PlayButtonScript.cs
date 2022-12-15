using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonScript : MonoBehaviour
{
   [SerializeField] private string playButtonLevel1 = "Level 1";

   public void PlayButton()
   {
    SceneManager.LoadScene(playButtonLevel1);
   }
}