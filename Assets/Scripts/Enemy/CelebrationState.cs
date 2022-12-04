using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SpriteRenderer))]
public class CelebrationState : State
{
    private Animator _animator;
    private SpriteRenderer _sprite;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _sprite = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        _animator.Play("Celebration");
        _sprite.flipX = true;
    }

    private void OnDisable()
    {
        _animator.StopPlayback();
        _sprite.flipX = false;
    }
}