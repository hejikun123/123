using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;

public class PLAYER : Character
{
    // Start is called before the first frame update
   //public CHARACTER PY1=new CHARACTER();
    List<GameObject> ESCONTINNERS = new List<GameObject>();
    Text p;
    GameObject es;
    GameObject A;
    GameObject Weap;
    public Transform PTransform;
    public Image HPF;
    GameObject rge;

    public override void IE()
    {
            
        {
            if (NES < ES)
            {
              
               GameObject GO = Instantiate(A, es.transform.position + new Vector3(25f * (ESCONTINNERS.Count - 1), 0f, 0f), Quaternion.identity, es.transform);
 
                ESCONTINNERS.Add(GO);
                NES++;
                D();
            }
        }
    }
    void Start()
    {
        HP = 50;
        ES = 10;
        NES = 10;
        A = (GameObject)Resources.Load("ESP");
        es = GameObject.Find("ES");
        p = GameObject.Find("point").GetComponent<Text>();
        p.text = ES.ToString();
        for (int i = 0; i < ES; i++)
        {
            GameObject GO = Instantiate(A, es.transform.position + new Vector3(25f * i, 0f, 0f), Quaternion.identity, es.transform);
            ESCONTINNERS.Add(GO);
        }
        InvokeRepeating("IE", 0F, 2F);
        Weap = Weapon.Create("sword", transform);
        Weap.AddComponent<Melee>();
        wp = Weap.GetComponent<Melee>();
        GameObject rg = (GameObject)Resources.Load("range");
        rge = Instantiate(rg, transform);
        rge.transform.position = rge.transform.position+new Vector3(0,(transform.localScale.y)/2,0);
      }
    // Update is called once per frame
    void Update()
    {
        Weap.GetComponent<SortingGroup>().sortingOrder = GetComponent<SortingGroup>().sortingOrder+1;
        rge.transform.localScale = new Vector3(wp.range, wp.range);

        
    }
    public void H()
    {
        string TE = p.text;
        int num = int.Parse(TE);
        num--;
    p.text = num.ToString();
    }
    public void D()
    {
        string TE = p.text;
        int num = int.Parse(TE);
        num++;
        p.text = num.ToString();
    }
    public override void ESC() 
    {
        if (ESCONTINNERS.Count != 0)
        {
            GameObject LAST = ESCONTINNERS[ESCONTINNERS.Count - 1];

            ESCONTINNERS.RemoveAt(ESCONTINNERS.Count - 1);
            Destroy(LAST);
            H();
            NES--;
        }
    }

}