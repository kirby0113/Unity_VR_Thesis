using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Variable{
public class VariableBox : MonoBehaviour
{
    // Start is called before the first frame update
    public string variableName;
    public int variableData;
    [SerializeField] private TextMeshPro textName = default; //変数名

    public void setData(int data,string name){
        this.variableName = name;
        this.variableData = data;
        this.textName.text = this.variableName;
    }

    public int getData(){
        return this.variableData;
    }
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
}

}