using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMANAGER : MonoBehaviour
{
    // Start is called before the first frame update
    Text nText;
    void Start()
    {
        nText = GameObject.Find("t1").GetComponent<Text>();
        int[] nums = new int[10];
        for (int i = 0; i < 10; ++i)
        {
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void F() {
        string ntxt = nText.text;
        int num = int.Parse(ntxt);
        num = num + 1;
        nText.text = num.ToString();

    }
}
