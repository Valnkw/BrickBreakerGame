//Valentine Nkowa
// 1/31/25
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Varibles
    private static GameManager instance;
    private float playerScore = 0;

    //Methods

    //Accessors
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject aGo = new GameObject("Game Manager");
                instance = aGo.AddComponent<GameManager>();
                DontDestroyOnLoad(aGo);
            }
            return instance;
        }
            
    }
}
