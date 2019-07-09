using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGravity : MonoBehaviour
{
    [SerializeField]
    public float gravity = 0.5f;

    void Update()
    {       
        Vector3 vel = Camera.main.transform.forward * gravity;
        GetComponent<Rigidbody>().velocity = vel;
    }

    public void SetGravity(float newGrav)
    {
        gravity = newGrav;
    }
}