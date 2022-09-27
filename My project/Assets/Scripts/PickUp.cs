using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public int woodCount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Wood")
        {
            woodCount += 1;
            var wood = collision.gameObject;
            Destroy(wood);
            print(woodCount);
        }
    }
}
