using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Actor : MonoBehaviour
{
    private float currentHealth;
 

    public Image healtBar;




    void Start()
    {
        
    }

    void Awake()
    {
        currentHealth = PlayerHealth.playerHealt;
        UpdateHealthBar();
    }

    private void Update()
    {
        UpdateHealthBar();
    }

    private void UpdateHealthBar()
    {
        healtBar.fillAmount = currentHealth / 3;
    }


}
