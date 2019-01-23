using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class Hit : MonoBehaviour
{
    [SerializeField]
    private bool isTrapNotExit = true;

    [SerializeField]
    private UnityEvent winEvent;

    [SerializeField]
    private UnityEvent loseEvent;

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            if (isTrapNotExit)
            {
                loseEvent.Invoke();
            }
            else
            {
                winEvent.Invoke();  
            }
        }
    }
}