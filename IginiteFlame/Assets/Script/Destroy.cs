using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    [SerializeField] GameObject particle;
    //public GameObject[] can;
    //public int i = 3;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            Instantiate(particle, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
        else if(other.gameObject.CompareTag("Player"))
        {
            //can azalt
            Debug.Log("degdi");
            PlayerHealth.playerHealt -= 1;

            //can[i].SetActive(false);
            //i--;
            Debug.Log(PlayerHealth.playerHealt);
            Instantiate(particle, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }

}