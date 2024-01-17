using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WPRLD : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject food;
    float x;
    float y;
    void Start()
    {
        food = Resources.Load("FOOD") as GameObject;
        StartCoroutine("IE");
    }
    IEnumerator IE()
    {
      yield return null;
        for (int i = 0; i < 10; i++) 
        {
            x = Random.Range(-11.0f, 11.0f);
            y = Random.Range(-5.0f, 5.0f);
            Instantiate(food, new Vector3(x,y),Quaternion.identity);
            yield return new WaitForSeconds(5.0f);
        }
     
    }
    // Update is called once per frame
   
    
}
