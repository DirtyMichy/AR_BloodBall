using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTween : MonoBehaviour 
{
    [SerializeField]
    private float amount = 1f;

    [SerializeField]
    private string axis = "x";

    void Start(){
        iTween.MoveBy(gameObject, iTween.Hash(axis, amount, "easeType", "easeInOutExpo", "loopType", "pingPong", "time", Random.Range(0.25f, 0.5f)));
    }
}
