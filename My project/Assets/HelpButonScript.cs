using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpButtonScript : MonoBehaviour
{
   [SerializeField] private string helpButtonMenu = "Help Menu";

   public void HelpButton()
   {
    SceneManager.LoadScene(helpButtonMenu);
   }
}