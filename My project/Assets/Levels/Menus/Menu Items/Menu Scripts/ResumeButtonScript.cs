using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResumeButtonScript : MonoBehaviour
{
   [SerializeField] private string resumeButtonLevel1 = "Level 1";

   public void ResumeButton()
   {
    SceneManager.LoadScene(resumeButtonLevel1);
   }
}
