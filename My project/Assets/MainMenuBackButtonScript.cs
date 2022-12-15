using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// When you press back button in help menu, go back to main menu
/// </summary>
public class MainMenuBackButtonScript : MonoBehaviour
{
   [SerializeField] private string backToMainMenuButton = "Main Menu";

   public void BackButton()
   {
    SceneManager.LoadScene(backToMainMenuButton);
   }
}