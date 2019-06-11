using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject blood;

    [SerializeField]
    private Sprite[] BloodSprites;

    void OnEnable()
    {
        StartCoroutine(BloodSpawnTimer());
    }

    void OnDisable()
    {
        StopCoroutine(BloodSpawnTimer());
    }

    // Update is called once per frame
    IEnumerator BloodSpawnTimer()
    {
        while (true)
        {
            GameObject tempBlood = Instantiate(blood, transform.position,  blood.transform.rotation = Quaternion.Euler(90f,Random.Range(0f,359f),0f));
            tempBlood.GetComponent<SpriteRenderer>().sprite = BloodSprites[Random.Range(0, BloodSprites.Length)];
            yield return new WaitForSeconds(0.2f);
        }
    }
}