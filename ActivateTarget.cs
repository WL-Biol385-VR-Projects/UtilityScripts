using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTarget: MonoBehaviour
{
    public GameObject target;
    public bool activate = true;

    void OnTriggerEnter(Collider other)
    {
        target.SetActive(activate);
    }

}
