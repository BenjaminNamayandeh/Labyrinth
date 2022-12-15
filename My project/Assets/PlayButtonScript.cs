using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonScript : MonoBehaviour
{
   [SerializeField] private string playButtonLevel1 = "Story Scene 1";

   public void PlayButton()
   {
    SceneManager.LoadScene(playButtonLevel1);
   }
}