using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultCollision : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject ParentObject;
    // Start is called before the first frame update
    void Start()
    {
        ParentObject = this.gameObject.transform.parent.transform.parent.gameObject;
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision){
        ParentObject.GetComponent<SingleCalc>().setResult(collision.gameObject);
        Debug.Log("Result");
    }
}
