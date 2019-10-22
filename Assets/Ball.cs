using System.Collections;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float ballInitialVelocity = 400f;

    private Rigidbody rb;
    public bool ballInPlay;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }    
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && ballInPlay == false)
        {
            transform.parent = null;
            ballInPlay = true;
            rb.isKinematic = false;
            rb.AddForce(new Vector3(ballInitialVelocity, ballInitialVelocity, 0));
        }
    }
}
