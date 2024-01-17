using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        if (collision.name == "SNAKE")
        {
            Debug.Log(collision.name);
            Destroy(gameObject, 0.2f);
                }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
