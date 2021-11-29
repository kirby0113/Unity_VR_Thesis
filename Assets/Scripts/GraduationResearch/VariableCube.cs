using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class VariableCube : MonoBehaviour
{
    private string Name;

    private string Type;

    [SerializeField] private Text NameText;
    [SerializeField] private Text TypeText;

    public void setVariableData(string Name,string Type){
        this.Name = Name;
        this.Type = Type;
        this.NameText.text = Name;
        this.TypeText.text = Type;
    }

    public string getVariableName(){
        return Name;
    }

    public string getVariableType(){
        return Type;
    }
}
