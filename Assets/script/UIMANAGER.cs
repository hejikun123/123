
using UnityEngine;
using UnityEngine.UI;

public class UIMANAGER : MonoBehaviour
{
    // Start is called before the first frame update
    Text nText;
    GameObject button;
    GameObject spawn;
    void Start()
    {
        nText = GameObject.Find("t1").GetComponent<Text>();
        int[] nums = new int[10];
        button = GameObject.Find("Bagbutton");
        spawn = GameObject.Find("Bag");
        spawn.SetActive(false);
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
    public void Openbag()
    {
        spawn.SetActive(true);
        Debug.Log("load");
        Bagdata.instance.loaddata();
    }
    public void Closebag()
    {
        spawn.SetActive(false);
    }
}
