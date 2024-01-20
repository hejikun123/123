using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class body : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        btransform = GameObject.Find("SNAKE").transform;
    }
    Transform btransform;
    // Update is called once per frame
    void Update()
    {
       
    }
    public void createbody() 
    {
        Debug.Log("hhhh");
            //Instantiate(gameObject, btransform.position, Quaternion.identity);
    }

}
