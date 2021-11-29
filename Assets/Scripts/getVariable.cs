using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Variable;

public class getVariable : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI dataText = default;
    // Start is called before the first frame update
   void Start()
    {
        
    }

    void OnCollisionStay(Collision other){ //触れている間パネルに情報を表示
        GameObject obj = other.gameObject.transform.parent.gameObject;
        VariableBox box = obj.GetComponent<VariableBox>();
        dataText.text = box.getData().ToString();
    }

    void OnCollisionExit(Collision other){ //離れたときにパネルの情報をリセット
        dataText.text = "NULL";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
