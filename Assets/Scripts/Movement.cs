using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float force;
    public Transform tr;
    // Update is called once per frame
    void FixedUpdate()
    {
        tr.transform.position += transform.right * 2 * Time.deltaTime;
        if (Input.GetKey("space") || Input.GetKey("up") || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector3.up * force;
        }
    }
}
