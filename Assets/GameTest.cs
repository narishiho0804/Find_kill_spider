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
            //myList�̒����烉���_����1��I��
            randomObj = myList[Random.Range(0, myList.Count)];
            //�I�񂾃I�u�W�F�N�g��useList�ɒǉ�
            useList.Add(randomObj);
            //�I�񂾃I�u�W�F�N�g�̃��X�g�ԍ����擾
            choiceNum = myList.IndexOf(randomObj);
            //�������X�g�ԍ���myList����폜
            myList.RemoveAt(choiceNum);
        }
    }
}
