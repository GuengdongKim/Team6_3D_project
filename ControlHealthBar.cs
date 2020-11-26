using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControlHealthBar : MonoBehaviour
{
    public Slider HealthBar;
    public float damageHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) //체력 감소 
        {
            HealthBar.value -= damageHealth;
        }
        
    }
}
