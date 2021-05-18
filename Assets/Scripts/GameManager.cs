using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float spawnDelay = 0.5f;
    public GameObject cubePrefab;
    public Transform spawnPoint;

    //Singleton
    public static GameManager instance;
    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Instantiate(cubePrefab,spawnPoint.position,spawnPoint.rotation);
        }
    }
}
