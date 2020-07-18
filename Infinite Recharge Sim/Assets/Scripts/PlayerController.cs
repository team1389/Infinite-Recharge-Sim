using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 2f;
    public float maxSpeed = 10f;
    public float turnSpeed = 5f;
    public float maxAngularVelocity = 5f;
    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(0.0f, 0.0f, moveVertical);

        rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
        rb.maxAngularVelocity = maxAngularVelocity;
        transform.Translate(movement * speed, Space.Self);

        rb.AddRelativeTorque(0.0f, moveHorizontal * turnSpeed, 0.0f, ForceMode.VelocityChange);
     


    }
}
