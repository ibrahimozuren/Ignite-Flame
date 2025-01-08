using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 5f; // Projectile h?z?
    [SerializeField]private Vector3 targetPosition; // Hedef pozisyon
    private Vector3 direction; // Hareket yönü
    private float timer = 0f;
    private float delay = 3f;

    // Projectile'?n hedef pozisyonunu ayarlayan fonksiyon
    public void SetTargetPosition(Vector3 target)
    {
        targetPosition = target;
        direction = (targetPosition - transform.position).normalized;
    }

    void Update()
    {
        //// Projectile hedef pozisyonuna do?ru hareket eder
        //transform.position += direction * speed * Time.deltaTime;

        //// Hedefe ula??ld???nda projectile yok edilir
        //if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        //{
        //    Destroy(gameObject);
        //}

        timer += Time.deltaTime; // Zaman? art?r
        //Debug.Log("time = " + timer);
        if (timer >= delay)
        {
            Destroy(gameObject); // 3 saniye sonra patlat
        }

    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("sag mermi degdi" + PlayerHealth.playerHealt);

    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        PlayerHealth.playerHealt -= 1;
    //        Debug.Log("sag mermi degdi"+PlayerHealth.playerHealt);
    //        Destroy(gameObject);
    //    }
    //}
}
