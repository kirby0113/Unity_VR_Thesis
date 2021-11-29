using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDownFunction : MonoBehaviour
{
    private GameObject[] components;
    public void Start(){
        components = GameObject.FindGameObjectsWithTag("CreateComponent");
        foreach(GameObject component in this.components){
            component.SetActive(false);
        }
    }
    public void OnValueChanged(int result){
        // Debug.Log(result);
        // Debug.Log(components.Length);
        foreach(GameObject component in this.components){
            component.SetActive(false);
        }
        if(result != 0){
        this.components[result - 1].SetActive(true);
        }
    }
}
