using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    // Start is called before the first frame update
    public int HP=50;
    public int ES = 10;
    public int NES =10;
    public float NEST = 2;
    public Weapon wp;
    private Ray ray;
    RaycastHit2D rd;
    public int speed=1;
    void Start()
    {
        InvokeRepeating("IE", 0, NEST);
     
    }

    // Update is called once per frame
    void Update()
    {
    }
    public virtual void IE()
    {
        if(NES < ES)
        {
            NES++;
        }
    }
    public virtual void ESC()
    {
        if (NES>0) 
        NES--;
    }
    public void MLATK()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        rd = Physics2D.Raycast(ray.origin, ray.direction);
        if (rd.collider != null && rd.collider.tag == "enemy")
        {
            Debug.Log("hhh");
            wp.Atk(rd.collider.gameObject,transform);
        }
    }
    public IEnumerator DASH()
    {
        Vector3 a= Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 dl = new Vector3(a.x, a.y, 0)-transform.position ;
        float s = 5;
        while (s>0)
        {
            Debug.Log("hhhh");
            GetComponent<Rigidbody2D>().MovePosition((Vector2)transform.position+ dl.normalized);
            yield return new WaitForSeconds(0.01f);
            s--;

        }
    }
    public void stdash()
    {
        StartCoroutine("DASH");
    }
}

