using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuBackButtonScript : MonoBehaviour
{
   [SerializeField] private string backToPauseMenuButton = "Pause Menu";

   public void BackButton()
   {
    SceneManager.LoadScene(backToPauseMenuButton);
   }
}