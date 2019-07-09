using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float timerValue = 0f;

    [SerializeField]
    private float timerAmount = 0.1f;

    public void StartTimer()
    {
        StopCoroutine(TimerRator());
        timerValue = 0f;
        StartCoroutine(TimerRator());
    }

    IEnumerator TimerRator()
    {
        while (true)
        {
            yield return new WaitForSeconds(timerAmount);
            timerValue += timerAmount;
        }
    }

    float ReturnTime()
    {
        return timerValue;
    }
}
