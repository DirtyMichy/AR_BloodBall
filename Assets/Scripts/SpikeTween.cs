using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTween : MonoBehaviour
{
    [SerializeField]
    private float amount = 1f;

    [SerializeField]
    private string axis = "x";

    public void StartSpikes()
    {        
        iTween.MoveBy(gameObject, iTween.Hash(axis, amount, "easeType", "easeInOutExpo", "loopType", "pingPong", "time", 0.5f));
    }
}