using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class GameTest : MonoBehaviour
{

    public List<GameObject> myList;
    public List<GameObject> useList = new List<GameObject>();
    public Vector3[] point;

   
    private GameObject randomObj;
    private int choiceNum;

    [SerializeField]
    private GameObject[] ball;
    [SerializeField] GameObject[] spawnPoint;

    private float spawnTimer;

    void Start()
    {
        for (int i = 0; i < 1; i++)
        {
            //myListの中からランダムで1つを選ぶ
            randomObj = myList[Random.Range(0, myList.Count)];
            //選んだオブジェクトをuseListに追加
            useList.Add(randomObj);
            //選んだオブジェクトのリスト番号を取得
            choiceNum = myList.IndexOf(randomObj);
            //同じリスト番号をmyListから削除
            myList.RemoveAt(choiceNum);
        }
    }
}
