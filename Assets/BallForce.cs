using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallForce : MonoBehaviour
{
    public Rigidbody rb;
    public float thrustX = 3.0f;
    public float thrustY = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update time :" + Time.deltaTime);
    }

    void FixedUpdate(){
        rb.AddForce(Input.GetAxis("Horizontal") * thrustX, 0, 0);
        rb.AddForce(0, Input.GetAxis("Vertical") * thrustY, 0);
    }
}
