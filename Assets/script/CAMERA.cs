using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMERA : MonoBehaviour
{
    Transform Ctransform;
    PLAYER PLAYER1;
    Transform Ptransform;
    Vector3 LINE; 

    // Start is called before the first frame update
    void Start()
    {
        Ctransform= GameObject.Find("Main Camera").transform;
        Ptransform= GameObject.Find("HeavyBandit").transform;
        Debug.Log(Ptransform.transform.position);
        LINE = Ctransform.position - Ptransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Ptransform)
        {
            Ctransform.position = Ptransform.position + LINE;
        }
    }
}

