using System.Collections;
using UnityEngine;

public class Deneme111 : MonoBehaviour
{
    public GameObject objectToOpen; // Açýlacak obje
    private bool isOpen = false; // Objenin açýk olup olmadýðýný kontrol etmek için

    void Update()
    {
        // "Q" tuþuna basýldýðýnda
        if (Input.GetKeyDown(KeyCode.N))
        {
            ToggleObject(); // Objenin durumunu deðiþtir
        }
    }

    void ToggleObject()
    {
        if (objectToOpen != null)
        {
            isOpen = !isOpen; // Açýk/Kapalý durumu deðiþtir
            objectToOpen.SetActive(isOpen); // Objenin aktiflik durumunu deðiþtir
        }
        else
        {
            Debug.LogWarning("objectToOpen atanmadý!"); // Eðer obje atanmadýysa uyarý ver
        }
    }
}

