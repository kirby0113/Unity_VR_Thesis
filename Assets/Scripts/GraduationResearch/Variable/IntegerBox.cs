using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntegerBox : MonoBehaviour
{
    // Start is called before the first frame update
    private int Data;

    public void setVariableData(int Data){
        this.Data = Data;
    }

    public int getVariableData(){
        return this.Data;
    }
}
