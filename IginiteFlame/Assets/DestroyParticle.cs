using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticle : MonoBehaviour
{
    private float timer = 0f;
    private float delay = 1f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; // Zaman? art?r
        //Debug.Log("time = " + timer);
        if (timer >= delay)
        {
            Destroy(gameObject); // 3 saniye sonra patlat
        }
    }
}
