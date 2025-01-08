using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretRight : MonoBehaviour
{
    //[SerializeField] private Bullet _bulletPrefab;
    [SerializeField] private Projectile _bulletPrefab;  //d�z
    //[SerializeField] private ZigZagProjectile _bulletPrefab2;   //silindir
    //[SerializeField] private SplittingProjectile _bulletPrefab3;    //parca
    [SerializeField] private Transform launchPoint;
    [SerializeField] private Transform target;
    public float launchspeed = 5f; // Projectile h?z?

    float timer = 0f;
    float interval = 2f; // ?ki saniyede bir ate? edecek.

    void Update()
    {
        timer += Time.deltaTime; // Her frame'de ge�en zaman? saya� de?i?kenine ekleyin.

        if (timer >= interval) // Zaman aral???na ula??ld???nda...
        {
            //if (Input.GetKeyDown("e")) // E tu?u bas?ld???nda...
            //{
            //    FireBullet(); // Mermi ate?leme fonksiyonunu �a??r?n.
            //    timer = 0f; // Saya�? s?f?rlay?n.
            //}
            FireBullet(); // Mermi ate?leme fonksiyonunu �a??r?n.
            timer = 0f; // Saya�? s?f?rlay?n.
        }
    }

    void FireBullet()
    {
        var _projectile = Instantiate(_bulletPrefab, launchPoint.position, launchPoint.rotation);
        _projectile.GetComponent<Rigidbody>().velocity = launchspeed * launchPoint.forward;
    }
}
