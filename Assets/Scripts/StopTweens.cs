using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTweens : MonoBehaviour 
{
    public void StopTweensInScene()
    {
        iTween.Stop();
    }
}