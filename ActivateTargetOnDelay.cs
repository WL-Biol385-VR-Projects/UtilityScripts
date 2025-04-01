using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTargetOnDelay: MonoBehaviour
{
    public GameObject target;
    public bool activate = true;
    public int delay = 3;

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(StartDelay());
    }

    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(delay);
        Debug.Log("fire delayed activation: " + GameObject);
        target.SetActive(activate);
    }


}
