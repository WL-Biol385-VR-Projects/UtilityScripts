using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateRenderer: MonoBehaviour
{
    public GameObject target;
    public bool activate = true;

    private Renderer rend;

    void OnTriggerEnter(Collider other)
    {
        rend = target.GetComponent<Renderer>();
        rend.enabled = activate;
    }

}
