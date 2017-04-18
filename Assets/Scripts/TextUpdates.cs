using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdates : MonoBehaviour {

    public Text Level;
    public Text Attack;
    public Text Defense;
    public Text Speed;
    
    public void UpdateText(int lvl, int atk, int dfs, int spd)
    {
        Level.text = "" + lvl;
        Attack.text = "" + atk;
        Defense.text = "" + dfs;
        Speed.text = "" + spd;
    }
}
