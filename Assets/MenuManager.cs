using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuManager : MonoBehaviour
{
    [SerializeField] TMP_Text countNumberOfCubes;
    [SerializeField] GameObject PauseImage;
    void Start()
    {
        
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

    }
    public  void PauseBtn()
    {

    }
    #endregion
}
