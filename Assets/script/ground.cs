using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ground : MonoBehaviour
{
    // Start is called before the first frame update
    private List<Vector3> grass = new List<Vector3>();
    public Tilemap tilemap;
    int grasscount;
    public List<GameObject> SP=new List<GameObject>();
    int spcout;
    void Start()
    {
        tilemap = GetComponent<Tilemap>();
        Vector3 org = tilemap.origin;
        Vector3 SZ= tilemap.size;
        for(int x= (int)org.x; x<SZ.x;x++)
            for(int y = (int)org.y; y < SZ.y; y++)
            {
                if(tilemap.GetTile(new Vector3Int(x, y, 0)) != null)
                {
                    Vector3 cellofworld = tilemap.GetCellCenterWorld(new Vector3Int(x, y, 0));
                    grass.Add(cellofworld);

                }
            }
    grasscount=grass.Count;
        spcout = SP.Count;
        //InvokeRepeating("CIE", 0, 0.5F);
        for(int I=0;I<3000; I++)
        {
            CIE();
        }
    }

    // Update is called once per frame
    void Update()
    {
  }
void CIE()
    {
        int aRD = Random.Range(0, grasscount);
        Vector3 SPP = grass[aRD];
        int arr = Random.Range(0, spcout);
        GameObject SPW = SP[arr];
        GameObject GO = Instantiate(SPW, SPP, Quaternion.identity);
        GO.GetComponent<SpriteRenderer>().sortingOrder = Mathf.RoundToInt(-GO.transform.position.y*10.0F);
 
    }
}
