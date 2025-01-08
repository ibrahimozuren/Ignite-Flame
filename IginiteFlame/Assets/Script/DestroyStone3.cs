using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyStoneYesil : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)


    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            PublicValues.yellowStone = true;
        }
            
    }
}
