using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetY : MonoBehaviour 
{
    [SerializeField]
    private float y = -0.08f;

	void ResetPositionY () 
    {
        Vector3 yReset = transform.position;
        yReset.y = y;
        transform.position = yReset;
	}
}