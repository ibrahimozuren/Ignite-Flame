using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZigZagProjectile : MonoBehaviour
{
    public float speed = 5f; // Projectile h?z?
    private Vector3 targetPosition; // Hedef pozisyon
    private Vector3 direction; // Hareket yönü

    public float zAmplitude = 0.5f; // Z ekseni sal?n?m genli?i
    public float xAmplitude = 0.5f; // X ekseni sal?n?m genli?i
    public float frequency = 0.5f; // Sal?n?m frekans?
    private float startTime; // Ba?lang?ç zaman?

    void Start()
    {
        startTime = Time.time;
    }

    // Projectile'?n hedef pozisyonunu ayarlayan fonksiyon
    public void SetTargetPosition(Vector3 target)
    {
        targetPosition = target;
        direction = (targetPosition - transform.position).normalized;
    }

    void Update()
    {
        // Hedefe do?ru hareket et
        transform.position += direction * speed * Time.deltaTime;

        // Sal?n?ml? hareket için yeni yönü hesapla
        float t = Time.time - startTime;
        float zOffset = zAmplitude * Mathf.Sin(2 * Mathf.PI * frequency * t);
        float xOffset = xAmplitude * Mathf.Sin(2 * Mathf.PI * frequency * t);
        Vector3 newDirection = new Vector3(xOffset, 0f, zOffset).normalized;

        // Yeni yönlendirmeyi ayarla
        direction = newDirection;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
