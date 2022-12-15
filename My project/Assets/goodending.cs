using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// When you touch the shrub, load the good ending scene
/// </summary>
public class goodending : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            SceneManager.LoadScene("GoodEnding");
        }
    }
}
