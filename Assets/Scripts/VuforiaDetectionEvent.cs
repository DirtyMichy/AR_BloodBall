using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class VuforiaDetectionEvent : DefaultTrackableEventHandler
{
    [SerializeField]
    private UnityEvent detectionEvent;

    [SerializeField]
    private UnityEvent detectionLostEvent;

    protected override void OnTrackingFound()
    {
        Debug.Log("OnTrackingFound");
        base.OnTrackingFound();
        detectionEvent.Invoke();
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        Debug.Log("OnTrackingLost");
        detectionLostEvent.Invoke();
    }
}