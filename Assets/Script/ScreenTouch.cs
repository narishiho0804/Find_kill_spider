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
        // FindでHierarchy「GameManager」のゲームScriptを呼び出す。
        _gameManger = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    

    public void OnClick()
    {

        //while (_score <= 5)
        //{
        //    _score = _score -= 1;

        //    _scoretext.text = "クモを倒す数 ：" + _score;


        //    return;
        //}
        _gameManger.AddScore(1); // ゲームマネージャーの関数のvalを１にする
        Instantiate(_FX, transform.position, transform.rotation);
        Destroy(gameObject);
    }

   
}
