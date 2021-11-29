using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using Variable;

public class AddVariable : MonoBehaviour
{
    [SerializeField] private Button actionbtn = default; //AddVariableボタン
    public GameObject prefab; //基本的にはVariableBoxのPrefabを設置
    public Text addName;
    public Text addData;
    // Start is called before the first frame update
    void Start()
    {
                actionbtn.onClick.AddListener(() => {
                   GameObject instance = (GameObject)Instantiate(prefab);
                   VariableBox box = instance.GetComponent<VariableBox>();
                   box.setData(Convert.ToInt32(addData.text),addName.text);
                    Debug.Log(instance);
                   instance.transform.position = gameObject.transform.position;
                   
                }
                );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
