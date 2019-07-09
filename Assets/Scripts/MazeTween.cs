using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeTween : MonoBehaviour
{
    [SerializeField]
    private float amount = 1f;

    [SerializeField]
    private string axis = "y";

    public void StartTween()
    {
        iTween.MoveBy(gameObject, iTween.Hash(axis, amount, "easeType", "easeInOutExpo", "delay", 0.25f, "time", 1f));
    }

    public void ResetTween()
    {
        transform.position = new Vector3(0f, -0.1f, 0f);
    }
}