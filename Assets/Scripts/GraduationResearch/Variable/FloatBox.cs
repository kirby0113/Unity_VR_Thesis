using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatBox : MonoBehaviour
{
    // Start is called before the first frame update
    private float Data;

    public void setVariableData(float Data){
        this.Data = Data;
    }

    public float getVariableData(){
        return this.Data;
    }
}
