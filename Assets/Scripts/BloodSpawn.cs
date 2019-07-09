using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject blood;

    public GameObject[] bloods;

    [SerializeField]
    private int bloodCount = 10;

    [SerializeField]
    private Sprite[] BloodSprites;

    void Awake()
    {
        bloods = new GameObject[bloodCount];

//        Debug.Log("L: " + bloods.Length);
        for (int i = 0; i < bloods.Length; i++)
        {
            GameObject tempBlood = Instantiate(blood, blood.transform.position, blood.transform.rotation);
            tempBlood.transform.parent = transform.parent;
            tempBlood.GetComponent<SpriteRenderer>().sprite = BloodSprites[i];
            bloods[i] = tempBlood;
        }
    }

    void OnEnable()
    {
        StartCoroutine(BloodSpawnTimer());
    }

    void OnDisable()
    {
        StopCoroutine(BloodSpawnTimer());
    }

    IEnumerator BloodSpawnTimer()
    {
        /*
        while (true)
        {
            GameObject tempBlood = Instantiate(blood, transform.position,  blood.transform.rotation = Quaternion.Euler(90f,Random.Range(0f,359f),0f));
            tempBlood.GetComponent<SpriteRenderer>().sprite = BloodSprites[Random.Range(0, BloodSprites.Length)];
            yield return new WaitForSeconds(0.2f);
        }
        */
        int i = 0;
        while (true)
        {
            bloods[i].transform.position = transform.position;
            bloods[i].transform.rotation = Quaternion.Euler(90f, Random.Range(0f, 359f), 0f);
            i++;
            if (i == 9)
                i = 0;
            yield return new WaitForSeconds(0.2f);
        }
    }
}