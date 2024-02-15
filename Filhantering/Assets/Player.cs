using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.Experimental.RestService;

public class Player : MonoBehaviour
{
    public string Name= "Abd";

    public int health= 50;

    public int age= 12;
    
    public TMP_Text tmp;
 
   
    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    
    public void LoadPlayer()
    {
        PlayerData data=SaveSystem.LoadPlayer();

        Name=data.Name;
        health=data.health;
        age=data.age;

        tmp.text=$"Name: {Name} \nHealth: {health} \nAge: {age}";
    }
}
