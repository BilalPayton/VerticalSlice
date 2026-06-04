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
        if (Input.GetKeyDown(_requiredKey))
        {
            this.gameObject.SetActive(false);
            _anim.SetBool("isSilly", false);

            if (_gameController.GetRound() == GameController.Round.R2)
            {
                _timer = 2.5f;
            }

            else if (_gameController.GetRound() == GameController.Round.R3)
            {
                _timer = 2.0f;
            }

            else if (_gameController.GetRound() == GameController.Round.R4)
            {
                _timer = 1.7f;
            }

            else if (_gameController.GetRound() == GameController.Round.R5)
            {
                _timer = 1.4f;
            }
        }

        else { _anim.SetBool("isSilly", true); }

    }
}
