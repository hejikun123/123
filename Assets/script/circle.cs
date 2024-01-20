using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circle : MonoBehaviour
{
    // Start is called before the first frame update
    Transform CTransform;
    Rigidbody2D RB;
    Quaternion a;

    void Start()
    {
        CTransform = gameObject.transform;
        RB = gameObject.GetComponent<Rigidbody2D>();
    }
    const float MAX = 8;
    const float MIN = -8;
    void Update()
    {
       
        if (Input.GetKey(KeyCode.W))
            if (RB.velocity.y<MAX)
        {
            RB.AddForce(new Vector2(0f,1f));
        }
        if (Input.GetKey(KeyCode.S))
            if (RB.velocity.y >MIN)
            {
            
                RB.AddForce(new Vector2(0f, -1f));
            }
        
        if (Input.GetKey(KeyCode.A))
            if (RB.velocity.x >MIN)
            {
            RB.AddForce(new Vector2(-1f, 0f));
        }
        if (Input.GetKey(KeyCode.D))
            if (RB.velocity.x < MAX)
            {
            RB.AddForce(new Vector2(1f, 0f));
        }
      
    }
    private void FixedUpdate()
    {
        float angle = Vector3.SignedAngle(transform.up, RB.velocity,new Vector3(0,0,1f));
        transform.Rotate(new Vector3(0, 0, 0.1f), angle);
    }
}
