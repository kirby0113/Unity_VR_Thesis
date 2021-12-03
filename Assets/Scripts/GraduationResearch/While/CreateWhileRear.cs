using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CreateWhileRear : MonoBehaviour
{
    [SerializeField] private GameObject WhileRearComponent;
    [SerializeField] private Text NowLineCount;
    [SerializeField] private Text LineNumber;

    [SerializeField] private Text PreviousLine;


    //生成位置（CreateSourceTile内に定義しているものと同様　変更する際は一緒に変更して）
    private int X = -6;
    private int BetweenX = 10;
    private int Y = 1;
    private int Z = 18;

    private string match = "While(Prev)";
    private GameObject matchObj = null;

    // Start is called before the first frame update
    public void onCreate(){
        int line;
        int prev;
        int maxline = int.Parse(NowLineCount.text);
        if(int.TryParse(LineNumber.text,out line) && int.TryParse(PreviousLine.text,out prev)){
        if(line <= 0 || line > maxline) return;
        matchObj = GameObject.Find("SourceTile:" + prev).GetComponent<SourceTile>().getCollisionObject();
        if(matchObj == null) return; //前カッコとして指定した場所にオブジェクトが設置されてなければ生成しない
        if(!matchObj.name.Contains(match)) return; //設置されているオブジェクトが前カッコでない場合は生成しない
        matchObj.GetComponent<WhileLineDrawer>().DrawLine(line - prev); //線を描画
        GameObject instance = (GameObject)Instantiate(WhileRearComponent,new Vector3(X + (BetweenX*(line - 1)),Y,Z),Quaternion.identity); //作成
        instance.name="While(Rear):"+line;

        }

    }
}
