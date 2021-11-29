using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEditor;
using UnityEngine.UI;

public class CreateSourceTile : MonoBehaviour
{
    [SerializeField] private Text countText; //NowCountText

    public GameObject prefab; //SourceTile
    private int X = -6;
    private int BetweenX = 10;
    private float Y = 0.2f;
    private int Z = 18;

    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click(){
        count += 1;
        EditorApplication.Beep();
        GameObject instance = Instantiate(prefab,new Vector3(X,Y,Z),Quaternion.identity); //インスタンス生成
        instance.name = "SourceTile:"+count;
        Text OrderNumber = instance.transform.GetComponentInChildren<Canvas>().GetComponentInChildren<Text>();
        X += BetweenX;
        OrderNumber.text = count.ToString();
        countText.text = count.ToString();

    }
}
