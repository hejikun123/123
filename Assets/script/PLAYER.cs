using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PLAYER : MonoBehaviour
{
    // Start is called before the first frame update
   public CHARACTER PY1=new CHARACTER();
    List<GameObject> ESCONTINNERS = new List<GameObject>();
    Text p;
    GameObject es;
    GameObject A;
    public Transform PTransform;
    void IE()
    {
            
        {
            if (PY1.NES < PY1.ES)
            {
              
               GameObject GO = Instantiate(A, es.transform.position + new Vector3(25f * (ESCONTINNERS.Count - 1), 0f, 0f), Quaternion.identity, es.transform);
 
                ESCONTINNERS.Add(GO);
                PY1.NES++;
                D();
            }
        }
    }
    void Start()
    {
        PY1.HP = 50;
        PY1.ES = 10;
        PY1.NES = 10;
        A=(GameObject)Resources.Load("ESP");
        es=GameObject.Find("ES");
        p = GameObject.Find("point").GetComponent<Text>();
        p.text = PY1.ES.ToString();
        for(int i=0;i<PY1.ES;i++)
        {
        GameObject GO=Instantiate(A, es.transform.position+ new Vector3(25f*i,0f,0f),Quaternion.identity, es.transform);
            ESCONTINNERS.Add(GO);
        }
        InvokeRepeating("IE", 0F, 2F);
        
      }
    // Update is called once per frame
    void Update()
    {
        if (ESCONTINNERS.Count!=0&&Input.GetMouseButtonDown(0))
        {
            GameObject LAST = ESCONTINNERS[ESCONTINNERS.Count - 1];
            
;            ESCONTINNERS.RemoveAt(ESCONTINNERS.Count - 1);
            Destroy(LAST);
            H();
            PY1.NES--;
        }
        
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
    
}
public class CHARACTER 
{
    public int HP;
    public int ES;
    public int EX;
    public int ST;
    public int IG;
    public int RC;
    public int LV;
    public int NHP;
    public int NES;
    public int NEX;
}