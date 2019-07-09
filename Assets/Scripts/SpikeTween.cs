using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTween : MonoBehaviour
{
    [SerializeField]
    private float amount = 0.01f, speed = 1f;

//    [SerializeField]
//    private string axis = "x";

    public void OnEnable()
    {        
        //Not the Tween was causing errors, the Coroutine was. I could jump back to iTween.MoveBy in a future update.
        //iTween.MoveBy(gameObject, iTween.Hash(axis, amount, "easeType", "easeInOutExpo", "loopType", "pingPong", "time", 0.5f));

        transform.localPosition = new Vector3(transform.localPosition.x, 0.02f, transform.localPosition.z);
        StartCoroutine( UpAndDownAnimation());

    }

    IEnumerator UpAndDownAnimation()
    {        
        yield return new WaitForSeconds(Random.Range(System.Math.Abs(1),System.Math.Abs(4)));
        while (true)
        {
            if (transform.localPosition.y >= 0.02f)
            {
                if(amount > 0f)
                amount *= -1;   

            }
            else
                if (transform.localPosition.y <= -0.08f)
                {
                    yield return new WaitForSeconds(1.0f);

                    if(amount < 0f)
                        amount *= -1;
                }

            yield return new WaitForSeconds(speed);
            transform.localPosition = transform.localPosition + new Vector3(0f, amount, 0f);
        }
    }
}