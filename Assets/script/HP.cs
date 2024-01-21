using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    PLAYER PLAYER = new PLAYER();
    food food = new food();
    public Image hppt;
    int hpm;
    int hpmax;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
       hpm = PLAYER.PY1.HP;
        hpmax = 50;
    }
    public void HPPOINT() 
    {
        hppt.fillAmount = hpm / hpmax;
    }
    public void Harm()
    {
        hpm += -5;
        HPPOINT();
    }
}
