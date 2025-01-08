using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicValues : MonoBehaviour
{
    [SerializeField] public static bool redStone;
    [SerializeField] public static bool greenStone;
    [SerializeField] public static bool blueStone;
    [SerializeField] public static bool yellowStone;
    [SerializeField] public static int finalCounter ;
    

    void Start()
    {
        redStone = false;
        greenStone = false; 
        blueStone = false;
        yellowStone = false;
        finalCounter = 0;
        
    }
}
