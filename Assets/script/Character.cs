using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    // Start is called before the first frame update
    public int HP=50;
    public int ES = 10;
    public int NES =10;
    public float NEST = 2;
    public Weapon wp;

    void Start()
    {
        InvokeRepeating("IE", 0, NEST);
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void IE()
    {
        if(NES < ES)
        {
            NES++;
        }
    }
    public virtual void ESC()
    {
        if (NES>0) 
        NES--;
    }
    
}

