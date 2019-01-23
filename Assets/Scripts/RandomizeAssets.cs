using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeAssets : MonoBehaviour 
{
    [SerializeField]
    private GameObject[] mazeAssets;

    public void StartRandomization()
    {
        Debug.Log ("StartRandomization");
        for (int i = 0; i < mazeAssets.Length; i++)
        {
            Vector3 temp = mazeAssets[i].transform.localPosition;
            int r = Random.Range(0, mazeAssets.Length);
            mazeAssets[i].transform.localPosition = mazeAssets[r].transform.localPosition;
            mazeAssets[r].transform.localPosition = temp;
        }
    }
}