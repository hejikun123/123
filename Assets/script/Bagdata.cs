
using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class Bagdata
{
    private static Bagdata _instance;
    private Bagdata(){
        spawn = new List<Bagspawn>();
    }
    public static  Bagdata instance
    {
        get{
            if(_instance==null)
            {
                _instance=new Bagdata();
                
            }
            return _instance;
        }

    }
   public List<Bagspawn> spawn;
   public void savedata(){
    string Bagjson=JsonUtility.ToJson(this);
    PlayerPrefs.SetString("Bagdata",Bagjson);
    PlayerPrefs.Save();
   }
    public List<Bagspawn> loaddata(){
        if(PlayerPrefs.HasKey("Bagdata")){
            string Bagjson=PlayerPrefs.GetString("Bagdata");
            Bagdata bagdata=JsonUtility.FromJson<Bagdata>(Bagjson);
            spawn=bagdata.spawn;
        }
        for(int i=0;i<spawn.Count;i++){
            Debug.Log(spawn[i]);
        }
        return spawn;

    }
}

[System.Serializable]
public class Bagspawn
{public string uid;
public string name;
public int id;
public int num;
public Bagspawn(string name){
    this.name = name;
}
    public override string ToString()
    {
        return String.Format("name : {0}",name);
    }
}
