using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class WhileRear : MonoBehaviour
{

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
        string code = "}";

        codeinterface.setCode(code);
    }
}