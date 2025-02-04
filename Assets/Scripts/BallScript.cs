//Valentine Nkowa
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    //Varibles
    protected Rigidbody rb;
    [SerializeField] protected Vector3 StartForce = Vector3.one;
    [SerializeField] protected float worldVelocity = 25;

    //Order of func loading
    //Awake
    //Start
    //OnEnable

    //Methods
    private void OnEnable()
    {
        rb = GetComponent<Rigidbody>(); //when enabled give rigidbody
        ApplyStartForce();
    }

    private void FixedUpdate()
    {
        LimitBallVelocity();
    }

    protected void  ApplyStartForce()
    {
        rb.AddForce(StartForce, ForceMode.Impulse); // Adds initial force on ball in a specific direction
    }
    protected void LimitBallVelocity()
    {
        Vector3 hV3 = rb.velocity;
        Vector3 nV3 = Vector3.zero;

        nV3.x = Mathf.Clamp(hV3.x, -worldVelocity, worldVelocity);
        nV3.y = Mathf.Clamp(hV3.y, -worldVelocity, worldVelocity);
        nV3.z = Mathf.Clamp(hV3.z, -worldVelocity, worldVelocity);

        rb.velocity = nV3;
    }
}
