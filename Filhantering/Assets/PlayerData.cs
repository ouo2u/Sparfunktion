using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayerData
{
  public string Name;

    public int health;

    public int age;
    
public PlayerData (Player player)
{

    health=player.health;
    Name=player.Name;
    age=player.age;  
}

}
