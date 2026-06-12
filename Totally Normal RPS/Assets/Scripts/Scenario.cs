using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scenario : MonoBehaviour
{

    protected KeyCode _requiredKey;
    protected float _timer;
    [SerializeField] protected AudioSource _soundController;
    [SerializeField] protected AudioClip _sfx;
    [SerializeField] protected TextMeshPro _timerText;
    [SerializeField] protected GameObject _gameOverUI;
    [SerializeField] protected GameController _gameController;
    [SerializeField] protected SpriteRenderer _renderer;

    [SerializeField] protected Material _default;
    [SerializeField] protected Material _rainbowEffect;

    protected bool _giveRainbow;
    protected int _count;


    protected virtual void Update()
    {
        _timer -= Time.deltaTime;
        _timerText.text = "" + _timer;

        if (_timer <= 0.0f || (Input.GetKeyDown(_requiredKey) != true && Input.anyKeyDown))
        {
            this.gameObject.SetActive(false);
            _gameOverUI.SetActive(true);
        }

        if (_giveRainbow == false)
        {
            if (Input.GetKeyDown(_requiredKey))
            {

                this.gameObject.SetActive(false);

                if (_gameController.GetRound() == GameController.Round.R1)
                {
                    _timer = 3.0f;
                }

                else if (_gameController.GetRound() == GameController.Round.R2)
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

                else if (_gameController.GetRound() == GameController.Round.R6)
                {
                        SetRainbow();
                        _timer = 2.0f;
                }
                


            }
        }

        else
        {
            if (Input.GetKeyDown(_requiredKey))
            {
                _count++;
            }

            if (_count == 2)
            {
                this.gameObject.SetActive(false);
                DisableRainbow();

                if (_gameController.GetRound() == GameController.Round.R6)
                {
                    SetRainbow();
                    _timer = 1.4f;
                }
            }
        }

        
    }

    protected virtual void OnEnable()
    {
        _soundController.clip = _sfx;
        _soundController.Play();
    }

    protected void SetRainbow()
    {
        int randomNum = Random.Range(0, 3);

        if (randomNum == 0)
        {
            _giveRainbow = true;
            _renderer.material = _rainbowEffect;
        }

        else
        {
            DisableRainbow();
        }
    }

    protected void DisableRainbow()
    {
        _giveRainbow = false;
        _renderer.material = _default;
        _count = 0;
    }

    void OnDisable()
    {
        _soundController.Stop();
    }

}
