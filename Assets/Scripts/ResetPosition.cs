using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour 
{
    [SerializeField]
    private float value = 0.01f;

    public void ResetPos()
    {
        Debug.Log ("ResetPos");
        gameObject.transform.localPosition = new Vector3
            (
                value,
                value,
                value
            );
    }
}