using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PushUndo : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject NumberText;
    void Start()
    {
        NumberText = this.gameObject.transform.parent.transform.Find("NumberText").gameObject;
    }

    // Update is called once per frame
    public void OnPush(){
        TextMeshProUGUI nownum = NumberText.GetComponent<TextMeshProUGUI>();
        string number = this.gameObject.name;
        if(nownum.text == "0"){
            return;
        }else if(nownum.text.Length == 1){
            nownum.text = "0";
        }else{
            nownum.text = nownum.text.Substring(0,nownum.text.Length - 1);
        }
    }
}
