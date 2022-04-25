using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetection : MonoBehaviour
{
    public Rigidbody rb;
    private bool collisionHappened = false;
    public Behaviour movementScript;
    private void OnCollisionEnter(Collision collision)
    {
        if (!collisionHappened)
        {
            Debug.Log("Collision!");
            collisionHappened = true;
            FindObjectOfType<GameManager>().EndGame();
            movementScript.enabled = false;
        }
        
    }
}
