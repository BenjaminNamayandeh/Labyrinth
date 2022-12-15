using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// It gives the user 3 attacks that moves the monster to a set position on the map.
/// </summary>
public class Attack : MonoBehaviour
{
    private int attacks;
    
    /// <summary>
    /// When the user presses 'E', the attack is commenced.
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            attacks++;
            print(attacks);
            if (collision.tag == "Enemy" && attacks <= 4)
            {
                var enemy = collision.gameObject;
                enemy.transform.position = new Vector3(11.65f, 17.68f);
            }
        }
    }
}
