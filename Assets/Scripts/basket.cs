using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class basket : MonoBehaviour
{
    public int point = 0;
    [SerializeField] private TextMeshProUGUI debugText = default;
    // Start is called before the first frame update
    void Start()
    {
        point = 0;
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject != null){
        point += 1;
        Destroy(other.gameObject);
        debugText.text = $"point: {point}";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
