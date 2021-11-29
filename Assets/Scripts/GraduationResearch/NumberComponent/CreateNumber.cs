using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CreateNumber : MonoBehaviour
{
    [SerializeField] private GameObject NumberComponent;
    [SerializeField] private GameObject NumberSpawner;

    private GameObject NumberText;
    // Start is called before the first frame update    private GameObject NumberText;
    void Start()
    {
        this.NumberText = this.transform.parent.transform.Find("NumberText").gameObject;
    }

    // Update is called once per frame

    public void OnPush(){
        string NumberData = NumberText.GetComponent<TextMeshProUGUI>().text;
        GameObject instance = Instantiate(NumberComponent,new Vector3(NumberSpawner.transform.position.x,NumberSpawner.transform.position.y + 1,NumberSpawner.transform.position.z),Quaternion.identity);
        instance.transform.Find("Cube").transform.Find("Canvas").transform.Find("NumberData").GetComponent<TextMeshPro>().text = NumberData;
    }
}