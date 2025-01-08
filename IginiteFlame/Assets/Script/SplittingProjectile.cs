using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplittingProjectile : MonoBehaviour
{
    private Vector3 targetPosition; // Hedef pozisyon
    private Vector3 direction; // Hareket y�n�

    public float launchspeed = 10f; // Projectile h?z?
    public GameObject[] projectile; // B�l�nen par�alar?n prefablar?
    public Transform[] launchPoint;
    [SerializeField] GameObject particle;

    private float timer = 0f;
    private float delay = 1f;

    private bool splitted = false; // Projectile'?n b�l�n�p b�l�nmedi?ini belirten bayrak

    void Update()
    {
        transform.position += direction * launchspeed * Time.deltaTime;

        if (!splitted)
        {
            timer += Time.deltaTime; // Zaman? art?r
            //Debug.Log("time = " + timer);
            if (timer >= delay)
            {
                Split(); // Projectile'? b�l
                splitted = true; // B�l�nd�?�n� i?aretle
                Instantiate(particle, transform.position, transform.rotation);
                Destroy(gameObject); // 3 saniye sonra patlat
            }
            
        }

        // Projectile hedef pozisyonuna do?ru hareket eder

    }

    void Split()
    {
        // Her bir split prefab? i�in
        int index = 0;
        foreach (GameObject splitPrefab in projectile)
        {
            GameObject _projectile = Instantiate(splitPrefab, launchPoint[index].position, launchPoint[index].rotation);
            _projectile.GetComponent<Rigidbody>().velocity = launchspeed * launchPoint[index].forward;
            index++;
        }
    }

    public void SetTargetPosition(Vector3 target)
    {
        targetPosition = target;
        direction = (targetPosition - transform.position).normalized;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
