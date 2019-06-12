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
            int r = Random.Range(0, mazeAssets.Length);

            Vector3 temp1 = mazeAssets[i].transform.localPosition;
            Vector3 temp2 = mazeAssets[r].transform.localPosition;  

            // Localpositions have to be resetted, otherwise object spawn higher or lower
            temp1.y = 0.02f;            
            temp2.y = 0.02f; 

            mazeAssets[i].transform.localPosition = temp2;
            mazeAssets[r].transform.localPosition = temp1;
        }
    }
}