using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretLeft : MonoBehaviour
{
    //[SerializeField] private Bullet _bulletPrefab;
    [SerializeField] private Projectile _bulletPrefab;  //d�z
    //[SerializeField] private ZigZagProjectile _bulletPrefab2;   //silindir
    //[SerializeField] private SplittingProjectile _bulletPrefab3;    //parca
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Transform _endPoint;
    float timer = 0f;
    float interval = 2f; // ?ki saniyede bir ate? edecek.
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("q"))
        {
            //Instantiate(_bulletPrefab, _spawnPoint.position, Quaternion.identity).Init(_endPoint.position);
            //Instantiate(_bulletPrefab, _spawnPoint.position, Quaternion.Euler(0f, 45f, 90f)).SetTargetPosition(_endPoint.position);


            // Player ile turret aras?ndaki y�n� bul
            Vector3 directionToPlayer = _endPoint.position - transform.position;
            // Yatay d�zlemdeki y�n� bul
            directionToPlayer.y = 0;
            // Y�n vekt�r�n� normalle?tir
            directionToPlayer.Normalize();
            // Player ile turret aras?ndaki a�?y? bul (radyan cinsinden)
            float angle = Mathf.Atan2(directionToPlayer.z, directionToPlayer.x);
            // A�?y? dereceye �evir ve Quaternion.Euler ile d�n�? olu?tur
            Quaternion rotation = Quaternion.Euler(0f, Mathf.Rad2Deg * angle, 90f);

            // Projectile olu?tur ve hedef pozisyonunu ayarla
            Instantiate(_bulletPrefab, _spawnPoint.position, rotation).SetTargetPosition(_endPoint.position); // k�t�k i�in

        }

        //if (Input.GetKeyDown("a"))
        //{
        //    Instantiate(_bulletPrefab2, _spawnPoint.position, Quaternion.Euler(0f, 90f, 0f)).SetTargetPosition(_endPoint.position);
        //}

        //if (Input.GetKeyDown("w"))
        //{
        //    Instantiate(_bulletPrefab3, _spawnPoint.position, Quaternion.identity).SetTargetPosition(_endPoint.position);
        //}

        if (Input.GetKeyDown("e"))
        {
            Instantiate(_bulletPrefab, _spawnPoint.position, Quaternion.identity).SetTargetPosition(_endPoint.position);
        }
    }

}
