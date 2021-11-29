using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PushNumber : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject NumberText;
    void Start()
    {
        NumberText = this.gameObject.transform.parent.transform.parent.transform.Find("NumberText").gameObject;
    }

    // Update is called once per frame
    public void OnPush(){
        TextMeshProUGUI nownum = NumberText.GetComponent<TextMeshProUGUI>();
        string number = this.gameObject.name;
        if(nownum.text == "0"){
            nownum.text = number;
        }else{
            nownum.text += number;
        }
    }
}
