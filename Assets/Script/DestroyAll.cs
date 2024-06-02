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

            // �Q�[���N���A
            Debug.Log("aaa");
            Instantiate(_clearUI); // �Q�[���N���A��Text���o��
            //Instantiate(_clearButton);
            _SceneButton.gameObject.SetActive(true);
            _ExitButton.gameObject.SetActive(true);
            
            
            //Instantiate(_confettiRight);// �E�̃G�t�F�N�g�𐶐�
            //Instantiate(_confettiLeft);  // ���̃G�t�F�N�g�𐶐�
            //_confettiLeft.SetActive(true);
            //_confettiRight.SetActive(true);
        }
    }
    private bool DestroyAllBlocks()
    {
        foreach (ScreenTouch b in _touch)
        {
            if (b != null) // true�ł͂Ȃ��ꍇ
            {
                return false;
            }
        }
        return true;
    }
    

}
