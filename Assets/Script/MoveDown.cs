using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    void Start()
    {
        transform.DOLocalMoveY(-0.01f, 5f).SetLoops(-1, LoopType.Yoyo);
    }
}
