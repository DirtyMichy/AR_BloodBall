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
    private UnityEvent hitEvent;

    public void ResetExit()
    {
        gameObject.transform.position = new Vector3
            (
                gameObject.transform.position.x,
                0.01f,
                gameObject.transform.position.z
            );
    }

    public void ResetBall()
    {
        gameObject.transform.position = new Vector3
            (
            gameObject.transform.position.x,
            0.05f,
            gameObject.transform.position.z
            );
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            if (isTrapNotExit)
                c.gameObject.SetActive(false);
            else
                SceneManager.LoadScene(0);   
            
            hitEvent.Invoke();
        }
    }
}