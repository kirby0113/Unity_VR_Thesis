using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScanfConponent : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI typeText;
    private string name = "";
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

    public void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "Variable"){
            this.name = col.gameObject.transform.Find("Canvas/VariableName").GetComponent<Text>().text;
        }
    }


    public void getCode(){
        string code = "scanf(\"";

        switch(typeText.text){
                case "int":
                    code = code+"%d";
                    break;
                case "float":
                    code = code+"%f";
                   break;
                case "double":
                    code = code+"%lf";
                   break;
                case "char":
                     code = code+"%c";
                    break;
                default:
                    return;
            }
        
        code = code + "\",&" + this.name;

        code = code + ");";

        codeinterface.setCode(code);
    }
}
