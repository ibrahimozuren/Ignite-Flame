using System;
using UnityEngine;
using UnityEngine.Events;

public class TriggerTurret : MonoBehaviour
{
    [SerializeField] string tagFilter;
    [SerializeField] UnityEvent OnTriggerEnter1;

    [SerializeField] UnityEvent OnTriggerExit1;

    void OnTriggerEnter(Collider other)
    {
        if (!String.IsNullOrEmpty(tagFilter) && !other.gameObject.CompareTag(tagFilter)) return;
        OnTriggerEnter1.Invoke();
    }

    void OnTriggerExit(Collider other)
    {
        if (!String.IsNullOrEmpty(tagFilter) && !other.gameObject.CompareTag(tagFilter)) return;
        OnTriggerExit1.Invoke();
    }


}
