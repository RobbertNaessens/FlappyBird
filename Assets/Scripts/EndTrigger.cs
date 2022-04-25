using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public Rigidbody rb;
    public GameManager gameManager;
    void OnTriggerEnter()
    {
        rb.constraints = RigidbodyConstraints.FreezePositionY;
        gameManager.CompleteLevel();
    }
}
