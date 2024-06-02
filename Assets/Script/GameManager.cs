using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _explanationCanvas;

    [SerializeField]
    private Text _scoreText;
    

    public TextMeshProUGUI ScoreText;

    
    private void Start()
    {
        ScoreText.DOFade(0.0f, 1).SetLoops(-1, LoopType.Yoyo);

       
    }

    const int min = 0;
    private  int _score = 5;

    public void AddScore(int val)
    {
        _score -= val;
        if(_score < min)
        {
            _score = min;
        }
        _scoreText.text = "" + _score;
    }

    void Update()
    {
        
    }

    public void OnButton()
    {
        _explanationCanvas.SetActive(false);
    }
    public void a()
    {
        SceneManager.LoadScene("Sample 7");
    }

    
}
