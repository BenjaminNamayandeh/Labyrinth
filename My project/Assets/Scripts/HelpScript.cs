using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpScript : MonoBehaviour
{
   [SerializeField] private string HelpMenu = "Help Menu";

   public void HelpButton()
   {
    SceneManager.LoadScene(HelpMenu);
   }
}
