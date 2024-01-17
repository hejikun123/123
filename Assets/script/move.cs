using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circle : MonoBehaviour
{
    // Start is called before the first frame update
    Transform CTransform;
    Rigidbody2D RB;
 

    void Start()
    {
        CTransform = gameObject.transform;
        RB = gameObject.GetComponent<Rigidbody2D>();
     }
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            RB.MovePosition(CTransform.position + new Vector3(0, 0.2F, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            RB.MovePosition(CTransform.position + new Vector3(0, -0.1F, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            RB.MovePosition(CTransform.position + new Vector3(-0.1f, 0, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            RB.MovePosition(CTransform.position + new Vector3(0.1f, 0, 0));
        }
    }
}
