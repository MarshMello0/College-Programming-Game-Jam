using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PAnimator : MonoBehaviour
{
    public GameManager manager;
    [SerializeField] private Animator _animator;
    [SerializeField] private float _timer;
    [SerializeField] private float _timerIncrease;

    private void Start()
    {
        _animator.SetFloat("Speed",0);
    }

    private void Update()
    {
        if (manager.inGame)
        {
            if (_timer <= 7)
            {
                _animator.SetFloat("Speed",_timer);
                _timer += _timerIncrease;
            }
        }
        if (Input.GetKey(KeyCode.Space) && manager.inGame)
        {
            _animator.Play("Jump");
        }
    }
}
