using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGravity : MonoBehaviour 
{
    [SerializeField]
    private float gravity = -9.8f;

    void Update () 
    {       
        Vector3 vel = Camera.main.transform.forward;
        vel.y += gravity * Time.deltaTime;
        GetComponent<Rigidbody>().velocity = vel;
    }
}