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
    PLAYER PY;
    HP HPT;
    bool isDead = false;
    void Start()
    {
        CTransform = gameObject.transform;
        RB = gameObject.GetComponent<Rigidbody2D>();
        MAnimator = GetComponent<Animator>();
        PY = GetComponent<PLAYER>();
        HPT=GameObject.Find("HPFILL").GetComponent<HP>();


    }
    const float MAX = 8;
    const float MIN = -8;
    void FixedUpdate()
    {
        if (!isDead)
        {
            //float angle = Vector3.SignedAngle(transform.up, RB.velocity,new Vector3(0,0,1f));
        //transform.Rotate(new Vector3(0, 0, 0.1f), angle); 
         float inputX = Input.GetAxis("Horizontal");

            // Swap direction of sprite depending on walk direction
            if (inputX > 0)
                transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
            else if (inputX < 0)
                transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
       

        if (Input.GetKey(KeyCode.W))
            if (RB.velocity.y < MAX)
            {
                RB.AddForce(new Vector2(0f, 4f));
            }
        if (Input.GetKey(KeyCode.S))
            if (RB.velocity.y > MIN)
            {

                RB.AddForce(new Vector2(0f, -4f));
            }

        if (Input.GetKey(KeyCode.A))
            if (RB.velocity.x > MIN)
            {
                RB.AddForce(new Vector2(-4f, 0f));
            }
        if (Input.GetKey(KeyCode.D))
            if (RB.velocity.x < MAX)
            {
                RB.AddForce(new Vector2(4f, 0f));
            }
        if (RB.velocity.magnitude > 0.01F)
        {
            MAnimator.SetInteger("AnimState", 2);
        }
        else 
        {
            MAnimator.SetInteger("AnimState", 0);
        }
         if(Input.GetMouseButtonDown(0)&&PY.PY1.NES>0) 
        {
            MAnimator.SetTrigger("Attack");
        }
        }
        if(!(Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.D))||isDead)
        {
            RB.velocity = Vector2.zero;
        }
        if (HPT.healthmeter <= 0){
            MAnimator.SetTrigger("Death");
            isDead = true;
        }
    }
    /*private void FixedUpdate()
    {
        *//*float angle = Vector3.SignedAngle(transform.up, RB.velocity,new Vector3(0,0,1f));
        transform.Rotate(new Vector3(0, 0, 0.1f), angle);*//*
        float inputX = Input.GetAxis("Horizontal");

        // Swap direction of sprite depending on walk direction
        if (inputX > 0)
            transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        else if (inputX < 0)
            transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }*/
}
