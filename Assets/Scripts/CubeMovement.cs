using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public Transform target;
    public float moveSpeed = 5f;
    public float rotationSpeed = 50f;
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            Quaternion rotateAngle = Quaternion.LookRotation(target.position - transform.position);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotateAngle, rotationSpeed *Time.deltaTime);
            rb.velocity = new Vector3(0,0, moveSpeed * Time.deltaTime);
            
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
    }
}
