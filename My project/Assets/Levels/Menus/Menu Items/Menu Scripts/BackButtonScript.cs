using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpButtonScript : MonoBehaviour
{
   [SerializeField] private string backButtonHelpMenu = "Main Menu";

   public void MainButton()
   {
    SceneManager.LoadScene(backButtonHelpMenu);
   }
}
