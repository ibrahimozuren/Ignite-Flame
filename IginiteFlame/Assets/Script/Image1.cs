using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHealth.playerHealt == 2) { GameObject.Destroy(gameObject); }
    }
}
