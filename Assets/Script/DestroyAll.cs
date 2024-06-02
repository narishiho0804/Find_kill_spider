using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DestroyAll : MonoBehaviour
{
    [SerializeField]
    private ScreenTouch[] _touch;

    [SerializeField]
    private GameObject _cube;

    [SerializeField]
    private Canvas _clearUI;

    

    [SerializeField]
    private GameObject _SceneButton;

    [SerializeField]
    private GameObject _ExitButton;

    [SerializeField]
    private TextMeshProUGUI _ScenText;

    [SerializeField]
    private TextMeshProUGUI _ExitText;

   

    void Start()
    {
        
        _ScenText.DOFade(0.0f, 1).SetLoops(-1, LoopType.Yoyo);
        _ExitText.DOFade(0.0f, 1).SetLoops(-1, LoopType.Yoyo);

       

    }

    void Update()
    {
        if (DestroyAllBlocks())
        {

            // ゲームクリア
            Debug.Log("aaa");
            Instantiate(_clearUI); // ゲームクリアのTextを出す
            //Instantiate(_clearButton);
            _SceneButton.gameObject.SetActive(true);
            _ExitButton.gameObject.SetActive(true);
            
            
            //Instantiate(_confettiRight);// 右のエフェクトを生成
            //Instantiate(_confettiLeft);  // 左のエフェクトを生成
            //_confettiLeft.SetActive(true);
            //_confettiRight.SetActive(true);
        }
    }
    private bool DestroyAllBlocks()
    {
        foreach (ScreenTouch b in _touch)
        {
            if (b != null) // trueではない場合
            {
                return false;
            }
        }
        return true;
    }
    

}
