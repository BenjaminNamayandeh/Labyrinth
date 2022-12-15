using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpButtonScript : MonoBehaviour
{
   [SerializeField] private string helpButtonLevel1 = "Help Menu";

   public void helpButton()
   {
    SceneManager.LoadScene(helpButtonLevel1);
   }
}
