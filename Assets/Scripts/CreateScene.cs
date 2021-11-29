using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class CreateScene : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scenename;
    private Button addbtn;

    void Awake(){
    addbtn = this.gameObject.GetComponent<Button>();
    }
    void Start()
    {
        addbtn.onClick.AddListener(() => {
            if(scenename.text != ""){
                File.Copy(@"./Assets/Scenes/SampleScene.unity",@"./Assets/Scenes/"+scenename.text+".unity");
                File.Copy(@"./Assets/Scenes/SampleScene.unity.meta",@"./Assets/Scenes/"+scenename.text+".unity.meta");
            }
        });
    }

    // Update is called once per frame
    void Update()
    {

    }
}
