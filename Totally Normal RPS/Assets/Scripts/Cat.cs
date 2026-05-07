using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Scenario
{
    [SerializeField] private Animator _anim;
    void Start()
    {
        _requiredKey = KeyCode.F;
    }

    
    protected override void Update()
    {
        base.Update();
        if (Input.GetKeyDown(_requiredKey))
        {
            this.gameObject.SetActive(false);
            _anim.SetBool("isSilly", false);
            _timer = 3.0f;
        }

        else { _anim.SetBool("isSilly", true); }

    }
}
