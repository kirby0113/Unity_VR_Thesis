using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeStringInterface : MonoBehaviour
{
    // Start is called before the first frame update
    private string codeString;
    
    public void setCode(string code){
        this.codeString = code;
    }

    public string getCode(){
        return this.codeString;
    }
}
