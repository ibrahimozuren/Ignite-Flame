using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretUp : MonoBehaviour
{
    //[SerializeField] private Bullet _bulletPrefab;
    [SerializeField] private KutupProjectile _bulletPrefab;  //düz
    //[SerializeField] private ZigZagProjectile _bulletPrefab2;   //silindir
    //[SerializeField] private SplittingProjectile _bulletPrefab3;    //parca
    [SerializeField] private Transform launchPoint;
    //[SerializeField] private Transform _endPoint;
    public float launchspeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //void Update()
    //{

    //    if (Input.GetKeyDown("e"))
    //    {

    //        KutupProjectile _projectile = Instantiate(_bulletPrefab, launchPoint.position, launchPoint.rotation);
    //        _projectile.GetComponent<Rigidbody>().velocity = launchspeed * launchPoint.forward;
         
    //    }
    //}


    float timer = 0f;
    float interval = 8f; // ?ki saniyede bir ate? edecek.

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
        KutupProjectile _projectile = Instantiate(_bulletPrefab, launchPoint.position, launchPoint.rotation);
        _projectile.GetComponent<Rigidbody>().velocity = launchspeed * launchPoint.forward;
    }
}
