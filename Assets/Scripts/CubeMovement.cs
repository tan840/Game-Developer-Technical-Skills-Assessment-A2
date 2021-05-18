using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CubeMovement : MonoBehaviour
{
    public Transform target;
    public float moveSpeed = 5f;
    public float rotationSpeed = 50f;
    public bool canMove;
    //public Rigidbody rb;
    public TMP_Text playerText;


    void Update()
    {
        if (target != null)
        {
            Quaternion rotateAngle = Quaternion.LookRotation(target.position - transform.position);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotateAngle, rotationSpeed *Time.deltaTime);
            //transform.LookAt(new Vector3( transform.position.x, target.position.y, transform.position.z));
            //canMove = true;
            //= new Vector3(0,0, moveSpeed * Time.deltaTime);
            if (canMove)
            {
                transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.Self);
                playerText.text = "Moving...";
            }
            
        }

    }
}
