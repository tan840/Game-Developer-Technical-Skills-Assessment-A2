using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float spawnDelay = 0.5f;
    private float nextSpawn = 0f;

    public bool paused;
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
        if (Input.GetKeyDown(KeyCode.C) && Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnDelay;
            Instantiate(cubePrefab,spawnPoint.position,spawnPoint.rotation);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            paused = !paused;
            if (paused)
            {
                Time.timeScale = 0f;
            }
            else
            {
                Time.timeScale = 1f;
            }
        }
    }
}
