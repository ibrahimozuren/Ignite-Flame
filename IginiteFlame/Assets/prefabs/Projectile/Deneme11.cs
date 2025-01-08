using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deneme11 : MonoBehaviour
{
    void Update()
    {
        // N tuþuna basýldýðýnda Canvas'ý aç/kapat
        if (Input.GetKeyDown(KeyCode.Q))
        {
            gameObject.SetActive(true); // Mevcut durumu tersine çevirir
        }
    }
}

