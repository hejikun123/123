using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class  Weapon : MonoBehaviour,IATK
{
    // Start is called before the first frame update
    public float range = 5;
    public int demage = 0;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static GameObject Create(string NAME, Transform transform)
    {

        GameObject wp = (GameObject)Resources.Load("sword");
        GameObject go=Instantiate(wp, transform);
        return go;
    }

    public abstract void Atk(GameObject target, Transform position);
}
public interface IATK
{
    public abstract void Atk(GameObject target,Transform position);
}
