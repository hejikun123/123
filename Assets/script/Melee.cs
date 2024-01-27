using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee :Weapon
{
    public override void Atk(GameObject target, Transform position)
    {
        Debug.Log("ww");
        Vector3 a = target.transform.position - position.position;
        if (a.magnitude < range / 2)
            StartCoroutine(Dash(target, position));
        //position.Translate(a);
        
    }
    /// <summary>
    /// 攻击冲刺
    /// </summary>
    /// <param 目标="target"></param>
    /// <param 自身transsform="position"></param>
    /// <returns></returns>
    IEnumerator Dash(GameObject target, Transform position)
    {
        Vector3 a = target.transform.position - position.position;
        while (a.magnitude > 0.5)
        {
            Debug.Log("gg");
            position.Translate(a * 0.1f);
            yield return new WaitForSeconds(0.01f);
            a = target.transform.position - position.position;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
