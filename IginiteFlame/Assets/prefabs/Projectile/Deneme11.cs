using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deneme11 : MonoBehaviour
{
    void Update()
    {
        // N tu�una bas�ld���nda Canvas'� a�/kapat
        if (Input.GetKeyDown(KeyCode.Q))
        {
            gameObject.SetActive(true); // Mevcut durumu tersine �evirir
        }
    }
}

