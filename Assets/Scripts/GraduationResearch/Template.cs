using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Template : MonoBehaviour //スクリプト名に置き換え
{

    [SerializeField] private GameObject ScanfComponent;
    [SerializeField] private Text NowLineCount;
    [SerializeField] private Text LineNumber;


    //生成位置（CreateSourceTile内に定義しているものと同様　変更する際は一緒に変更して）
    private int X = -6;
    private int BetweenX = 10;
    private int Y = 1;
    private int Z = 18;

    // Start is called before the first frame update
    public void onCreate(){
        int line; //何行目に出力する
        int maxline = int.Parse(NowLineCount.text); //現在生成してるパネルの数
        if(int.TryParse(LineNumber.text,out line)){
        if(line <= 0　|| line > maxline) return;

        GameObject instance = (GameObject)Instantiate(ScanfComponent,new Vector3(X + (BetweenX*(line - 1)),Y,Z),Quaternion.identity); //作成
        instance.name="ComponentName"+line;

        }

    }
}