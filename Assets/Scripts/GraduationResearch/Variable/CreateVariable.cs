using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CreateVariable : MonoBehaviour
{
    [SerializeField] private GameObject CharBox;
    [SerializeField] private GameObject IntegerBox;
    [SerializeField] private GameObject FloatBox;
    [SerializeField] private GameObject DoubleBox;
    // Start is called before the first frame update
    public void onCreate(){
        GameObject instance;
        string type = this.gameObject.transform.parent.gameObject.transform.parent.gameObject.transform.Find("VariableType").GetComponent<TextMeshPro>().text;
        string name = this.gameObject.transform.parent.gameObject.transform.parent.gameObject.transform.Find("VariableName").GetComponent<TextMeshPro>().text;
        Vector3 tmp = this.gameObject.transform.parent.gameObject.transform.parent.gameObject.transform.position;
        switch(type){
            case "int":
                instance = Instantiate(IntegerBox);
                instance.transform.position = new Vector3(tmp.x,tmp.y + 1,tmp.z);
                instance.transform.Find("Cube").transform.Find("Canvas").transform.Find("VariableType").GetComponent<Text>().text = type;
                instance.transform.Find("Cube").transform.Find("Canvas").transform.Find("VariableName").GetComponent<Text>().text = name;
                break;
            case "char":
                instance = Instantiate(CharBox);
                instance.transform.position = new Vector3(tmp.x,tmp.y + 1,tmp.z);
                instance.transform.Find("Cube").transform.Find("Canvas").transform.Find("VariableType").GetComponent<Text>().text = type;
                instance.transform.Find("Cube").transform.Find("Canvas").transform.Find("VariableName").GetComponent<Text>().text = name;
                break;
            case "double":
                instance = Instantiate(DoubleBox);
                instance.transform.position = new Vector3(tmp.x,tmp.y + 1,tmp.z);
                instance.transform.Find("Cube").transform.Find("Canvas").transform.Find("VariableType").GetComponent<Text>().text = type;
                instance.transform.Find("Cube").transform.Find("Canvas").transform.Find("VariableName").GetComponent<Text>().text = name;
                break;
            case "float":
                instance = Instantiate(FloatBox);
                instance.transform.position = new Vector3(tmp.x,tmp.y + 1,tmp.z);
                instance.transform.Find("Cube").transform.Find("Canvas").transform.Find("VariableType").GetComponent<Text>().text = type;
                instance.transform.Find("Cube").transform.Find("Canvas").transform.Find("VariableName").GetComponent<Text>().text = name;
                break;
        }
    }
}
