using System.Collections;
using System.Collections.Generic;
using Tarodev;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
    public Transform launchPoint;
    public GameObject projectile;
    public float launchspeed = 10f;

    [SerializeField] Rigidbody target;

    float timer = 0f;
    float interval = 3f; // ?ki saniyede bir ate? edecek.

    void Update()
    {
        timer += Time.deltaTime; // Her frame'de geçen zaman? sayaç de?i?kenine ekleyin.

        if (timer >= interval) // Zaman aral???na ula??ld???nda...
        {
            //if (Input.GetKeyDown("e")) // E tu?u bas?ld???nda...
            //{
            //    FireBullet(); // Mermi ate?leme fonksiyonunu ça??r?n.
            //    timer = 0f; // Sayaç? s?f?rlay?n.
            //}
            FireBullet(); // Mermi ate?leme fonksiyonunu ça??r?n.
            timer = 0f; // Sayaç? s?f?rlay?n.
        }
    }

    void FireBullet()
    {
        var _projectile = Instantiate(projectile, launchPoint.position, launchPoint.rotation);
        _projectile.GetComponent<Target>().setTarget(target);
        _projectile.GetComponent<Rigidbody>().velocity = launchspeed * launchPoint.up;

        Vector3 m_newForce = new Vector3(0, 500, 0);
        _projectile.GetComponent<Rigidbody>().AddForce(m_newForce, ForceMode.Impulse);
    }
    // Start is called before the first frame update

    // Update is called once per frame
    //void Update()
    //{
    //    if(Input.GetKeyDown("w"))
    //    {
            
    //    }
        
    //}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }


}
