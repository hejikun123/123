using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circle : MonoBehaviour
{
    // Start is called before the first frame update
    Transform CTransform;
    Rigidbody2D RB;
    Quaternion a;
    Animator MAnimator;
    void Start()
    {
        CTransform = gameObject.transform;
        RB = gameObject.GetComponent<Rigidbody2D>();
        MAnimator = GetComponent<Animator>();
    }
    const float MAX = 8;
    const float MIN = -8;
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
            if (RB.velocity.y < MAX)
            {
                RB.AddForce(new Vector2(0f, 1f));
            }
        if (Input.GetKey(KeyCode.S))
            if (RB.velocity.y > MIN)
            {

                RB.AddForce(new Vector2(0f, -1f));
            }

        if (Input.GetKey(KeyCode.A))
            if (RB.velocity.x > MIN)
            {
                RB.AddForce(new Vector2(-1f, 0f));
            }
        if (Input.GetKey(KeyCode.D))
            if (RB.velocity.x < MAX)
            {
                RB.AddForce(new Vector2(1f, 0f));
            }
        if (RB.velocity.magnitude > 0.01F)
        {
            MAnimator.SetInteger("AnimState", 2);
        }
        else 
        {
            MAnimator.SetInteger("AnimState", 0);
        }
        if(!(Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.D)))
        {
            RB.velocity = Vector2.zero;
        }
      if(Input.GetMouseButtonDown(0)) 
        {
            MAnimator.SetTrigger("Attack");
        }
    }
    private void FixedUpdate()
    {
        /*float angle = Vector3.SignedAngle(transform.up, RB.velocity,new Vector3(0,0,1f));
        transform.Rotate(new Vector3(0, 0, 0.1f), angle);*/
        float inputX = Input.GetAxis("Horizontal");

        // Swap direction of sprite depending on walk direction
        if (inputX > 0)
            transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        else if (inputX < 0)
            transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }
}
