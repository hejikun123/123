using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseEnter()
    {
     
            GetComponent<Renderer>().material.SetFloat("_lineWidth", 1.0f);
            
    }
    private void OnMouseExit()
    {
        GetComponent<Renderer>().material.SetFloat("_lineWidth",0f);
    }
}
