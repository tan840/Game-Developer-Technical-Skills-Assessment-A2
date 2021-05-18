using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float spawnDelay = 0.5f;
    private float nextSpawn = 0f;
    private int numberOfCubes = 0;

    public bool paused;
    public GameObject cubePrefab;
    public Transform spawnPoint;
    private MenuManager menuManager;

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

    private void Start()
    {
        menuManager = MenuManager.instance;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && Time.time > nextSpawn)
        {
            SpawnCube();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            GamePaused();
        }
    }

    public void SpawnCube()
    {
        numberOfCubes++;
        nextSpawn = Time.time + spawnDelay;
        Instantiate(cubePrefab, spawnPoint.position, spawnPoint.rotation);
        menuManager.countNumberOfCubes.text = numberOfCubes.ToString();
    }

    public void GamePaused()
    {
        paused = !paused;
        if (paused)
        {
            Time.timeScale = 0f;
            menuManager.PauseImage.SetActive(true);
        }
        else
        {
            Time.timeScale = 1f;
            menuManager.PauseImage.SetActive(false);
        }
    }
}
