using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleBox : MonoBehaviour
{
    // Start is called before the first frame update
    private double Data;

    public void setVariableData(double Data){
        this.Data = Data;
    }

    public double getVariableData(){
        return this.Data;
    }
}
