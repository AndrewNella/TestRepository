using UnityEngine;
using DG;
using DG.Tweening;
using UnityEngine.UI;

public class MoveToTheRight : MonoBehaviour
{

    [SerializeField] private float MoveTweenSpeed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.DOLocalMoveX(5f, MoveTweenSpeed).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
