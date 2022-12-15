using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

/// <summary>
/// It sets the target for the enemy, which is the player and then uses NavMesh to find the most efficient route to the player.
/// </summary>
public class aimovement : MonoBehaviour
{
    [SerializeField] Transform target;

    NavMeshAgent agent;

    private Vector3 positionLastFrame;
    public Vector3 vel;
    bool flipped = false;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        var displacement = transform.position - positionLastFrame;

        vel = displacement / Time.deltaTime;
        
        agent.SetDestination(target.position);

        positionLastFrame = transform.position;

        if (vel.x < 0f && flipped)
        {
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            flipped = false;
        }
        if (vel.x > 0f && !flipped)
        {
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            flipped = true;
        }
    }

    /// <summary>
    /// When the player hits the wood piece, it adds to the wood count and increas the slider's value
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
}
