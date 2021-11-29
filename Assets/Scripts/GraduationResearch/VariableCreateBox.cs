using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VariableCreateBox : MonoBehaviour
{

    // Start is called before the first frame update
    [SerializeField] private GameObject CharBox;
    [SerializeField] private GameObject IntegerBox;
    [SerializeField] private GameObject FloatBox;
    [SerializeField] private GameObject DoubleBox;

    private CodeStringInterface codeinterface;


    private string Type;
    private string Name;

    private string FirstData;
    void Start(){
        codeinterface = this.gameObject.GetComponent<CodeStringInterface>(); //インタフェースを取得（コード化で使用）
    }

    // Update is called once per frame
    void Update()
    {
        Type = this.transform.Find("VariableType").GetComponent<TextMeshPro>().text;
        Name = this.transform.Find("VariableName").GetComponent<TextMeshPro>().text;
        FirstData = this.transform.Find("FirstData").GetComponent<TextMeshPro>().text.Replace("First:","");
        this.getCode();
    }

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "variable"){
            Debug.Log("variable");
        }
    }
    

    public void getCode(){
        if(FirstData == "undefined"){
            codeinterface.setCode(Type + " " + Name + ";");
        }else{
            codeinterface.setCode(Type + " " + Name + " = " + FirstData + ";");
        }
    }
}
