using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorOnOff: MonoBehaviour
{
    public GameObject target;
    public int timeInSeconds = 5;

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        Animator animator = target.GetComponent<Animator>();
        animator.enabled = true;

        yield return new WaitForSeconds(timeInSeconds);

        animator.enabled = false;

    }

}