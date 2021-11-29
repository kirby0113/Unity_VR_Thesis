using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharBox : MonoBehaviour
{
    // Start is called before the first frame update
    private char Data;

    public void setVariableData(char Data){
        this.Data = Data;
    }

    public char getVariableData(){
        return this.Data;
    }
}
