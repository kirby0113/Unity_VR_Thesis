using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddBlock : MonoBehaviour
{
    [SerializeField] private Button actionbtn = default;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
                actionbtn.onClick.AddListener(() => {
                   GameObject instance = (GameObject)Instantiate(prefab);
                   instance.transform.position = gameObject.transform.position;
                   
                }
                );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
