using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// When help button in main menu is pressed, load help menu
/// </summary>
public class HelpMainMenuScript : MonoBehaviour
{
   [SerializeField] private string helpMainMenuButton = "Help Main Menu";

   public void HelpButton()
   {
    SceneManager.LoadScene(helpMainMenuButton);
   }
}