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

    // Use this for initialization
    public void StartWinTimer()
    {
        StartCoroutine(Win());		
    }
	
    IEnumerator Win()
    {
        yield return new WaitForSeconds(4.0f);   
        textObject.text = "3";
        yield return new WaitForSeconds(1.0f);   
        textObject.text = "2";
        yield return new WaitForSeconds(1.0f);   
        textObject.text = "1";
        yield return new WaitForSeconds(1.0f);   
        textObject.text = "";


        timerEvent.Invoke();      
    }
}