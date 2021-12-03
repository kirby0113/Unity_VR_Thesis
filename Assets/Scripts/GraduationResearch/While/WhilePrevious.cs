using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class WhilePrevious : MonoBehaviour
{
    private string require = "";
    // Start is called before the first frame update
    private CodeStringInterface codeinterface;
    void Start()
    {
        codeinterface = this.gameObject.GetComponent<CodeStringInterface>(); //インタフェースを取得（コード化で使用）
    }

    // Update is called once per frame
    void Update()
    {
        this.require = this.gameObject.transform.Find("RequireCanvas/RequirementText").GetComponent<TextMeshProUGUI>().text;
        this.getCode();
        
    }

    public void getCode(){
        string code = "while( ";
        
        code = code + this.require;

        code = code + " ){";

        codeinterface.setCode(code);
    }
}