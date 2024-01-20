using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    // Start is called before the first frame update

    WPRLD wd;
    circle CL;
    UIMANAGER UM;
    void Start()
    {
        wd = GameObject.Find("WORLD").GetComponent<WPRLD>();
        CL=GameObject.Find("HeavyBandit").GetComponent<circle>();
        UM = GameObject.Find("Canvas").GetComponent<UIMANAGER>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name== "HeavyBandit")
        Destroy(gameObject);
        UM.F();
    }
}
