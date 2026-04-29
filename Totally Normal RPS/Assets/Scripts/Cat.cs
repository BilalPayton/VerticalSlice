using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Scenario
{

    [SerializeField] private Animator _anim;
    void Start()
    {
        
    }

    
    protected override void Update()
    {
        base.Update();
        if (Input.GetKeyDown(KeyCode.F))
        {
            this.gameObject.SetActive(false);
            _anim.SetBool("isSilly", false);
            _timer = 3.0f;
        }

        else { _anim.SetBool("isSilly", true); }
    }
}
