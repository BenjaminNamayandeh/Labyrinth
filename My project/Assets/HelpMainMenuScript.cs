using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpMainMenuScript : MonoBehaviour
{
   [SerializeField] private string helpMainMenuButton = "Help Main Menu";

   public void HelpButton()
   {
    SceneManager.LoadScene(helpMainMenuButton);
   }
}