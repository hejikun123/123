using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class  Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    public float range = 5;
    public int demage = 0;
    GameObject wp;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject Create(string NAME, Transform transform)
    {
       
        wp = (GameObject)Resources.Load("sword");
        GameObject go=Instantiate(wp, transform.position,Quaternion.identity);
        return go;
    }
    public void Destroy()
    {
        Destroy(wp);
    }
}
