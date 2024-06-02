using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScreenTouch : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem _FX;

    //[SerializeField]
    //private Text _scoretext;

    //private int _score = 5;


    private GameManager _gameManger;

    void Start()
    {
        // Find��Hierarchy�uGameManager�v�̃Q�[��Script���Ăяo���B
        _gameManger = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    

    public void OnClick()
    {

        //while (_score <= 5)
        //{
        //    _score = _score -= 1;

        //    _scoretext.text = "�N����|���� �F" + _score;


        //    return;
        //}
        _gameManger.AddScore(1); // �Q�[���}�l�[�W���[�̊֐���val���P�ɂ���
        Instantiate(_FX, transform.position, transform.rotation);
        Destroy(gameObject);
    }

   
}
