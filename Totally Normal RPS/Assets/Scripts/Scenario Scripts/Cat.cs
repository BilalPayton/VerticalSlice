using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Scenario
{
    [SerializeField] private Animator _anim;
    void Start()
    {
        _requiredKey = KeyCode.F;
        _timer = 2.5f;
    }

    
    protected override void Update()
    {
        base.Update();
        _anim.SetBool("isSilly", true);
    }
}
