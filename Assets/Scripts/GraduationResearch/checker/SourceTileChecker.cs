using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SourceTileChecker : MonoBehaviour
{
    // Start is called before the first frame update

    public static bool hasObject(int line){
        string word = "SourceTile:" + line;
        GameObject tile = GameObject.Find(word);
        bool isCollision = tile.GetComponent<SourceTile>().getIsCollision();
        return isCollision;
    }
}
