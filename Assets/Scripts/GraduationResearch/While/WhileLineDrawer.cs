using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLineDrawer : MonoBehaviour
{
    private float[] start = new float[3];
   private int centerX = 15;

    private int BetweenX = 10;
   private LineRenderer lineRenderer;

    private void Start()
    {
        // LineRendererコンポーネントをゲームオブジェクトにアタッチする
        lineRenderer = this.gameObject.transform.Find("RangeLine").GetComponent<LineRenderer>();
        lineRenderer.startWidth = 0.2f;
        lineRenderer.endWidth = 0.2f;
        lineRenderer.numCornerVertices = 10;
        this.start[0] = this.gameObject.transform.Find("RangeLine").position.x;
        this.start[1] = this.gameObject.transform.Find("RangeLine").position.y;
        this.start[2] = this.gameObject.transform.Find("RangeLine").position.z;
    }
    public void DrawLine(int betweenLine){
        var positions = new Vector3[]{
            new Vector3(0,0,0),               // 開始点
            new Vector3(betweenLine*this.BetweenX / 2,5,0), //中間点
            new Vector3(betweenLine*this.BetweenX, 0, 0),               // 終了点
        };
        // 線を引く場所を指定する
        lineRenderer.SetPositions(positions);
    }
}
