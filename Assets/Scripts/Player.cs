using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public int level = 1;
    public int attack = 100;
    public int defense = 50;
    public int speed = 5;

    //Save statistics for this player
    public void Save()
    {
        SaveLoadManager.SavePlayer(this);
    }

    //Load Statistics for this player
    public void Load()
    {
        int[] loadedStats = SaveLoadManager.LoadPlayer();

        level = loadedStats[0];
        attack = loadedStats[1];
        defense = loadedStats[2];
        speed = loadedStats[3];
    }

    void Update()
    {
        GetComponent<TextUpdates>().UpdateText(level, attack, defense, speed);
    }

    public void AlterLevelUp()
    {
        ++level;
    }

    public void AlterAttackUp()
    {
        attack += 10;
    }

    public void AlterDefenseUp()
    {
        defense += 10;
    }

    public void AlterSpeedUp()
    {
        ++speed; 
    }

    public void AlterLevelDown()
    {
        --level;
    }

    public void AlterAttackDown()
    {
        attack -= 10;
    }

    public void AlterDefenseDown()
    {
        defense -= 10;
    }

    public void AlterSpeedDown()
    {
        --speed;
    }
}
