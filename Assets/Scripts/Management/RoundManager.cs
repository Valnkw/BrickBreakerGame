using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundManager : MonoBehaviour
{
    //Vars
   //[SerializeField] protected List<BreakableBrick> bricks;
   [SerializeField] protected GameObject CanvasScene;

    //Methods
    public void Update()
    {
        EndRound();
    }
    private void Awake()
    {
        GameObject[] GameObjects = GameObject.FindObjectsOfType<GameObject>();
        if (GameObjects.Length > 1 )
        {
            Destroy(gameObject);
        }
    }

    protected void EndRound() 
    {
        if (FindObjectsOfType<BreakableBrick>().Length <= 0)
        {
            CanvasScene.SetActive(true);
        }
    }
}
