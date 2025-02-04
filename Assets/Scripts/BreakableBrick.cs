//Valentine Nkowa
// 1/31/25
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableBrick : MonoBehaviour
{
    // Varibles
    [SerializeField, Range(1,10)] protected int HitsToBreak;
    protected int CurrentHitsToBreak = 0;

    //Methods
    private void Awake()
    {
        CurrentHitsToBreak = HitsToBreak;
    }
    public void TakeDamage(int aDamage)
    {
        CurrentHitsToBreak -= aDamage;
        BreakBrick();
        

    }

    protected void BreakBrick()
    {
        if (CurrentHitsToBreak < 0)
        {
            //Add flare before destroy
            FindObjectOfType<RoundManager>().RemoveBrick(this);
            Destroy(gameObject);
            //Too late for flare
        }

    }
    //Accessors
}
