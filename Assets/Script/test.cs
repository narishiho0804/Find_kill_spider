using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    [SerializeField, Header("�����̈ʒu")]
    private GameObject[] _transform;

    [SerializeField,Header("�N��Prefab")]
    private GameObject[] _gameObject;

    [SerializeField]
    private int _number = 5;

    private void Start()
    {
        
        
        for (int i = 0; i < _number; i++)
        {
            GameObject a = _transform[Random.Range(0, _transform.Length)];
            GameObject b = _gameObject[Random.Range(0, _gameObject.Length)];
            Instantiate(b, a.transform.position, transform.rotation);

        }
        
    }
}
