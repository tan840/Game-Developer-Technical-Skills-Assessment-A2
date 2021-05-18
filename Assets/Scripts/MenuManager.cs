using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public TMP_Text countNumberOfCubes;
    public GameObject PauseImage;
    private GameManager gameManager;


    public static MenuManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        gameManager = GameManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void CubeCount(int val)
    {
        countNumberOfCubes.text = val.ToString();
    }
    public void PauseSprite(bool val)
    {
        PauseImage.SetActive(val);
    }
    #region Button Functions
    public void SpawnBtn()
    {
        //print("spawn");
        gameManager.SpawnCube();
    }
    public  void PauseBtn()
    {
        //print("spawn");
        gameManager.GamePaused();
    }
    #endregion
}
