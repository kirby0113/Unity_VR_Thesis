using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCollision : MonoBehaviour
{
    private GameObject ParentObject;
    // Start is called before the first frame update
    void Start()
    {
        this.ParentObject = this.gameObject.transform.parent.transform.parent.gameObject;
        Debug.Log(this.ParentObject);
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision){
        ParentObject.GetComponent<SingleCalc>().setRight(collision.gameObject);
        Debug.Log("Right");
    }
}
