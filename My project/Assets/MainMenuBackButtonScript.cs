using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuBackButtonScript : MonoBehaviour
{
   [SerializeField] private string backToMainMenuButton = "Main Menu";

   public void BackButton()
   {
    SceneManager.LoadScene(backToMainMenuButton);
   }
}