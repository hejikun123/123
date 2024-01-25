using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // Start is called before the first frame update
    int HP=50;
    int ES = 10;
    int NES=10;
    float NEST = 2;

    void Start()
    {
        InvokeRepeating("IE", 0, NEST);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IE()
    {
        if(NES < ES)
        {
            NES++;
        }
    }
    public void EE()
    {
        if (NES>0) 
        NES--;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      
    }
}

