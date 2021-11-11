using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTargetOnTag: MonoBehaviour
{
    public GameObject target;
    public bool activate = true;
    public string collidingTag;

    void OnTriggerEnter(Collider other)
    {
	if (other.gameObject.CompareTag(collidingTag))
        {
            target.SetActive(activate);
        }
    }

}
