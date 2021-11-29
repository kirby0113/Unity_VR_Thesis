using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class CreateSourceFile : MonoBehaviour
{
    [SerializeField] private Text fileNameText;
    String basicPass = @"C:\Test\";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click(){
        if(String.IsNullOrEmpty(fileNameText.text)){ //ファイル名が入力されてないときは何もしない
            return;
        }
            try
            {
                // テキストファイル出力（新規作成）basicPass = C:\Test\
                String fileName = fileNameText.text;
                String path = basicPass + fileName+".c";
                //fileインスタンスの生成
                FileInfo fileinfo = new FileInfo(path);
                // フォルダーが存在するかどうかを確認
                if (!fileinfo.Directory.Exists)
                {
                    // フォルダーが存在しない場合は作成
                    fileinfo.Directory.Create();
                }
                //ファイル作成
                FileStream fileStream = fileinfo.Create();
                StreamWriter sw = new StreamWriter(fileStream);

                GameObject[] Sources = GameObject.FindGameObjectsWithTag("SourceTile");

                //1行ずつコードを取得

                sw.WriteLine("#include <stdio.h>");
                sw.WriteLine("int main(void){");

                foreach(GameObject Source in Sources){
                    string code = Source.transform.GetComponent<SourceTile>().getDataString(); //各タイルのCreateSourceTile.csから取得
                    if(code == "") continue; //コンポーネントが設置されていないところはとりあえず何も出力しないってことで
                    sw.WriteLine(code);
                }
                sw.WriteLine("return 0;");
                sw.WriteLine("}");

                //ストリーム終了
                sw.Close();
                fileStream.Close();

            }
            // 例外処理
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        EditorApplication.Beep();
    }
}
