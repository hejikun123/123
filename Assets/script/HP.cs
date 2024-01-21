using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public Image hppt;
    public PLAYER health;
    public int healthmeter;
    public int hppts;
    // Start is called before the first frame update
    void Start()
    {
    // Update is called once per frame
        
    }
    public void HPPOINT() 
    {
        hppt.fillAmount = healthmeter/hppts ;
        Harm();
            
    }
    public void Harm()
    {
        healthmeter += -1;
        HPPOINT();
    }
    private void Update()
    {
        hppts = health.PY1.HP;
    }
}
