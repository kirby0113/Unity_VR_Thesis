using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SourceTile : MonoBehaviour
{
    // Start is called before the first frame update


    private GameObject CollisionObject = null;
    private bool isCollision = false;

 

    void Start(){

    }

    public string getDataString(){ //1行出力用データを取得 設置しているオブジェクトのVariableCreateBox.csから取得
        if(CollisionObject != null){
            string code = CollisionObject.GetComponent<CodeStringInterface>().getCode();
            Debug.Log("code:"+code);
            return code;
        }else{
            return "";
        }
    }

    public void OnCollisionEnter(Collision Collision){
        if(Collision.gameObject.tag == "CodeComponent"){
            this.isCollision = true;
        CollisionObject = Collision.gameObject; //オブジェクトを設置した際に参照を保持しておく
        }
    }

    public void OnCollisionExit(Collision Collision){
        if(Collision.gameObject.tag == "CodeComponent"){
            this.isCollision = false;
        CollisionObject = null; //オブジェクトが離れた際に参照を消す
        }
    }

    public bool getIsCollision(){
        return this.isCollision;
    }

    public GameObject getCollisionObject(){
        return this.CollisionObject;
    }
}
