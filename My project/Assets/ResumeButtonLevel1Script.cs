using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResumeButtonLevel1Script : MonoBehaviour
{
   [SerializeField] private PauseMenuEvents pauseMenuEvents;


   public void ResumeGame()
   {
      pauseMenuEvents.ResumeGame();
   }
}