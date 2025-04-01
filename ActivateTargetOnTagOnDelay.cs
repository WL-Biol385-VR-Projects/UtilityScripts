using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTargetOnTagOnDelay: MonoBehaviour
{
    public GameObject target;
    public bool activate = true;
    public int delay = 3;
    public string collidingTag;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(collidingTag))
        {
          StartCoroutine(StartDelay());
        }
        
    }

    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(delay);
        Debug.Log("fire delayed activation: " + GameObject);
        target.SetActive(activate);
    }


}
