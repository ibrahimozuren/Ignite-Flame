using System.Collections;
using UnityEngine;

public class Deneme111 : MonoBehaviour
{
    public GameObject objectToOpen; // A��lacak obje
    private bool isOpen = false; // Objenin a��k olup olmad���n� kontrol etmek i�in

    void Update()
    {
        // "Q" tu�una bas�ld���nda
        if (Input.GetKeyDown(KeyCode.N))
        {
            ToggleObject(); // Objenin durumunu de�i�tir
        }
    }

    void ToggleObject()
    {
        if (objectToOpen != null)
        {
            isOpen = !isOpen; // A��k/Kapal� durumu de�i�tir
            objectToOpen.SetActive(isOpen); // Objenin aktiflik durumunu de�i�tir
        }
        else
        {
            Debug.LogWarning("objectToOpen atanmad�!"); // E�er obje atanmad�ysa uyar� ver
        }
    }
}

