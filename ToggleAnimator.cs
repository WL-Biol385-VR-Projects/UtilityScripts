using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleAnimation: MonoBehaviour
{
    public GameObject target;

    void OnTriggerEnter(Collider other)
    {

        Animaotr animator = target.GetComponent<Animator>();
        animator.enabled = !animator.enabled;

    }

}