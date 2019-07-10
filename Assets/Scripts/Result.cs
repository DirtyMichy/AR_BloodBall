using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    [SerializeField]
    private UnityEvent timerEvent;

    [SerializeField]
    private Text textObject;

    private bool stopTimer = false; //Now that we stop Coroutines via the DetectionLostEvent, this could be unnessarry

    // Use this for initialization
    public void StartStartTimer()
    {
        stopTimer = false;
        StartCoroutine(RdyTimer());		
    }

    public void StopTimer()
    {
        stopTimer = true;
    }

    IEnumerator RdyTimer()
    {
        yield return new WaitForSeconds(4.0f);

        for (int i = 3; i > 0 && !stopTimer; i--)
        {
            textObject.text = "" + i;
            yield return new WaitForSeconds(1.0f);
        } 
        textObject.text = "";

        if (!stopTimer)
            timerEvent.Invoke();      
    }
}