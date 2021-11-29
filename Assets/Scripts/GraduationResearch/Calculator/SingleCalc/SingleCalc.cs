using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SingleCalc : MonoBehaviour
{
   [SerializeField] private TextMeshProUGUI Operator;

   [SerializeField] private GameObject SensorLeft;
   [SerializeField] private GameObject SensorRight;

   [SerializeField] private GameObject SensorResult;

   private GameObject LeftObject = null;
   private GameObject RightObject = null;

   private GameObject ResultObject = null;
    // Start is called before the first frame update
    private CodeStringInterface codeinterface;
    void Start()
    {
        codeinterface = this.gameObject.GetComponent<CodeStringInterface>(); //インタフェースを取得（コード化で使用）
    }

    // Update is called once per frame
    void Update()
    {
        this.getCode();
    }


    public void getCode(){
        string code = "";
        if(LeftObject != null && RightObject != null && ResultObject != null){ //オブジェクトがセットされていればコードを書く
            GameObject[] setObjects = new GameObject[]{ResultObject,LeftObject,RightObject};
            string[] codeunits = new string[3]; //単純な計算に使うやつなので、３つでおK
            //ResultObjectに数字コンポーネントが入れられているときとかにエラー表示したいね
            Debug.Log(setObjects[0]);
            for(int i = 0;i < 3;i++){
                GameObject codeObject = setObjects[i];
                if(codeObject.tag == "NumberComponent"){
                    codeunits[i] = codeObject.transform.Find("Canvas/NumberData").GetComponent<TextMeshPro>().text;
                }else if(codeObject.tag == "Variable"){
                    codeunits[i] = codeObject.transform.Find("Canvas/VariableName").GetComponent<Text>().text;
                }else{
                    return;
                }
            }

            string operatorCode = Operator.GetComponent<TextMeshProUGUI>().text;

            code = codeunits[0] + " = " + codeunits[1] + " " + operatorCode + " " + codeunits[2] + ";";
        }
        Debug.Log(code);
        codeinterface.setCode(code);
    }

//オブジェクトが衝突判定を得た際にセンサーからオブジェクトをゲットしてくる
    public void setLeft(GameObject LeftObject){
        this.LeftObject = LeftObject;
    }

    public void setRight(GameObject RightObject){
        this.RightObject = RightObject;
    }

    public void setResult(GameObject ResultObject){
        this.ResultObject = ResultObject;
    }
}
