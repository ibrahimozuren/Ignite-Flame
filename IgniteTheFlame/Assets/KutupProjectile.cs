using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KutupProjectile : MonoBehaviour
{
    // Start is called before the first frame update
    private float timer = 0f;
    private float delay = 3f;
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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
