using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WPRLD : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject food;
    float x;
    float y;
    public GameObject go;
    void Start()
    {
        food = Resources.Load("FOOD") as GameObject;
        StartCoroutine("IE");
    }
    Text text;
    IEnumerator IE()
    {
        text = GameObject.Find("t1").GetComponent<Text>();
      yield return null;
       while(10>int.Parse(text.text))
        {
            x = Random.Range(-11.0f, 11.0f);
            y = Random.Range(-5.0f, 5.0f);
            go =Instantiate(food, new Vector3(x,y),Quaternion.identity);
            Destroy(go,5f);
            yield return new WaitForSeconds(3.0f);
        }
     
    }
    // Update is called once per frame
   
    
}
