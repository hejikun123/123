using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public Image hppt;
    public PLAYER health;
    public float healthmeter;
    public float hppts;
    public int[] vs = { 1, 2, 4, 6, 9, 3 };
    // Start is called before the first frame update
    void Start()
    {
        // Update is called once per frame
    
    }
    public void HPPOINT() 
    {
        hppt.fillAmount = healthmeter/hppts ;
            
    }
    public void Harm()
    {
        healthmeter +=-25.0f;
        HPPOINT();
    }
    private void Update()
    {
        hppts = health.HP;
    }
}
