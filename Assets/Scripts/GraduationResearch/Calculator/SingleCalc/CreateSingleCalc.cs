using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class CreateSingleCalc : MonoBehaviour
{
    [SerializeField] private Dropdown OperatorDropdown;
    [SerializeField] private GameObject SingleCalcComponent;
    [SerializeField] private Text NowLineCount;
    [SerializeField] private Text LineNumber;


    //生成位置（CreateSourceTile内に定義しているものと同様　変更する際は一緒に変更して）
    private int X = -6;
    private int BetweenX = 10;
    private int Y = 1;
    private int Z = 18;
    // Start is called before the first frame update
    public void onCreate(){
        int line;
        int maxline = int.Parse(NowLineCount.text);
        int operatornum = OperatorDropdown.value;
        if(int.TryParse(LineNumber.text,out line)){
        if(line <= 0 || operatornum == 0 || line > maxline) return;

        GameObject instance = (GameObject)Instantiate(SingleCalcComponent,new Vector3(X + (BetweenX*(line - 1)),Y,Z),Quaternion.identity); //作成
        instance.name="SingleCalc:"+line;
        switch(operatornum){
                case 1:
                    instance.transform.Find("Canvas/CalcMark").GetComponent<TextMeshProUGUI>().text = "+";
                    break;
                case 2:
                    instance.transform.Find("Canvas/CalcMark").GetComponent<TextMeshProUGUI>().text= "-";
                    break;
                case 3:
                    instance.transform.Find("Canvas/CalcMark").GetComponent<TextMeshProUGUI>().text = "×";
                    break;
                case 4:
                    instance.transform.Find("Canvas/CalcMark").GetComponent<TextMeshProUGUI>().text = "÷";
                    break;
            }

        }

    }
}
