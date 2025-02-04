//Valentine Nkowa
// 1/31/25
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasNav : MonoBehaviour
{
    //Vars
    //[SerializeField]

    //Methods
    public void LoadNextScene(int aSceneID)
    {
        SceneManager.LoadScene(aSceneID);
    }

    public void LoadStartScreen()
    {
        LoadNextScene(0);
    }

     //Accessors
}
