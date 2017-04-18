using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveLoadManager : MonoBehaviour {

    public static void SavePlayer(Player player)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream stream = new FileStream(Application.dataPath + "/player.slt", FileMode.Create);
        Debug.Log(Application.persistentDataPath);
        PlayerData data = new PlayerData(player);

        bf.Serialize(stream, data);
        stream.Close();
    }

    public static int[] LoadPlayer()
    {
        if (File.Exists(Application.persistentDataPath + "/player.slt"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream stream = new FileStream(Application.dataPath + "/player.slt", FileMode.Open);

            PlayerData data = bf.Deserialize(stream) as PlayerData;

            stream.Close();
            return data.stats;
        }
        else
        {
            Debug.Log("No File Exists");
            return new int[4];
        }
    }
}

[Serializable]
public class PlayerData
{
    public int[] stats;

    public PlayerData(Player player)
    {
        stats = new int[4];
        stats[0] = player.level;
        stats[1] = player.attack;
        stats[2] = player.defense;
        stats[3] = player.speed;
    }
}
