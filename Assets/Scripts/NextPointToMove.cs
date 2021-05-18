using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// sets the next target
/// </summary>
public class NextPointToMove : MonoBehaviour
{
    public Transform nextPoint;
    public float moveDelay = 0f;
    CubeMovement player;
    //WaitForSeconds shortWait = new WaitForSeconds();

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player = other.GetComponent<CubeMovement>();
            player.target = nextPoint;
            player.playerText.text = "waiting...";
            player.canMove = false;
            Invoke("SetTarget", moveDelay);
        }
    }
    void SetTarget()
    {      
        if (player!=null)
        {
            player.canMove = true;
        }
    }
}
