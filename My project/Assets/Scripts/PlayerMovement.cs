using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Windows;
using Input = UnityEngine.Input;

/// <summary>
/// Takes user input to control player movement, also changes the animation state, and flips it based on the pressed key
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 moveDirection;
    private Animator animator; 

    public float speed;
    bool flipped = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = (transform.up * Input.GetAxisRaw("Vertical") + transform.right * Input.GetAxisRaw("Horizontal")).normalized;

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W))
        {
            animator.SetFloat("Speed", 1);

            print(flipped);

            if (Input.GetKeyDown(KeyCode.A) && flipped)
            {
                transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
                flipped = false;
            }
            else if (Input.GetKeyDown(KeyCode.D) && !flipped)
            {
                transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
                flipped = true;
            }
        }
        else
        {
            animator.SetFloat("Speed", 0);
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(moveDirection * speed);
    }
}
