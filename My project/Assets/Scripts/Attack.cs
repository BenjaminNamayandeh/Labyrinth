using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Attack : MonoBehaviour
{
    private int attacks;

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
