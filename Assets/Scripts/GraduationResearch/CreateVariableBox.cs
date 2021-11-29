using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CreateVariableBox : MonoBehaviour
{
    
    //生成位置（CreateSourceTile内に定義しているものと同様　変更する際は一緒に変更して）
    private int X = -6;
    private int BetweenX = 10;
    private int Y = 1;
    private int Z = 18;
    
    //Prefab
    [SerializeField] private GameObject VariableBox;
    [SerializeField] private Text LineNumber;

    [SerializeField] private Text VariableName;
    
    [SerializeField] private Text FirstData;

    [SerializeField] private Dropdown TypeDropdown;

    [SerializeField] private Text NowLineCount;
    // Start is called before the first frame update
    

    public void pushed(){ //Createボタンが押されたときに実行
        //初期宣言
        int line;
        int maxline = int.Parse(NowLineCount.text);
        string name;
        int typenum = TypeDropdown.value;
        string first = "undefined";

        //必要な情報が打ち込まれてるか
        if(int.TryParse(LineNumber.text,out line) && !string.IsNullOrEmpty(VariableName.text)){
            name = VariableName.text;
            if(!string.IsNullOrEmpty(FirstData.text)){
                first = FirstData.text;
            }

            if(SourceTileChecker.hasObject(line)){ //オブジェクトがすでにおかれている場合は置けないようにしています
                return;
            }
            //Debug.Log("est");
            // Debug.Log(line);
            // Debug.Log(typenum);
            // Debug.Log(maxline);
            // Debug.Log(first);

            if(line <= 0 || typenum == 0 || line > maxline) return;

            GameObject instance = (GameObject)Instantiate(VariableBox,new Vector3(X + (BetweenX*(line - 1)),Y,Z),Quaternion.identity); //作成
            //Debug.Log(instance.transform.Find("VariableName"));
            instance.name="VariableBox:"+line;
            instance.transform.Find("VariableName").GetComponent<TextMeshPro>().text = name;
            instance.transform.Find("FirstData").GetComponent<TextMeshPro>().text = "First:"+first;

            switch(typenum){
                case 1:
                    instance.transform.Find("VariableType").GetComponent<TextMeshPro>().text = "int";
                    break;
                case 2:
                    instance.transform.Find("VariableType").GetComponent<TextMeshPro>().text = "char";
                    break;
                case 3:
                    instance.transform.Find("VariableType").GetComponent<TextMeshPro>().text = "float";
                    break;
                case 4:
                    instance.transform.Find("VariableType").GetComponent<TextMeshPro>().text = "double";
                    break;
            }
        }else{
            return;
        }
    }
}
