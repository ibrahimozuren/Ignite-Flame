using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DeactivateYesil : MonoBehaviour
{
    [SerializeField] string tagFilter;
    [SerializeField] UnityEvent OnTriggerEnter1;

    [SerializeField] UnityEvent OnTriggerExit1;
    public GameObject kazandin;

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("kirmiz gitdi");
        //Debug.Log("tag: " + tagFilter);
        //Debug.Log("redstone: " + PublicValues.greenStone);
        if (!String.IsNullOrEmpty(tagFilter) && other.gameObject.CompareTag(tagFilter) && PublicValues.greenStone == true)
        {
            OnTriggerEnter1.Invoke();
            PublicValues.finalCounter++;
            if (PublicValues.finalCounter >= 4)
            {
                kazandin.SetActive(true);
            }
        }
        Debug.Log("finalCounter: " + PublicValues.finalCounter);
    }

    void OnTriggerExit(Collider other)
    {
        if (!String.IsNullOrEmpty(tagFilter) && !other.gameObject.CompareTag(tagFilter)) return;
        OnTriggerExit1.Invoke();
    }


}
