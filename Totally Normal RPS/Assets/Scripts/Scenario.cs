using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scenario : MonoBehaviour
{

    protected KeyCode _requiredKey;
    protected float _timer = 3.0f;
    [SerializeField] protected AudioSource _soundController;
    [SerializeField] protected AudioClip _sfx;
    [SerializeField] protected TextMeshPro _timerText;
    [SerializeField] protected GameObject _gameOverUI;
    [SerializeField] protected GameController _gameController;


    protected virtual void Update()
    {
        _timer -= Time.deltaTime;
        _timerText.text = "" + _timer;

        if (_timer <= 0.0f || (Input.GetKeyDown(_requiredKey) != true && Input.anyKeyDown))
        {
            this.gameObject.SetActive(false);
            _gameOverUI.SetActive(true);
        }

        if (Input.GetKeyDown(_requiredKey))
        {
            this.gameObject.SetActive(false);
            _timer = 3.0f;
            /*if (_gameController.GetRound() == GameController.Round.R1)
            {
                _timer = 3.0f;
                Debug.Log("Hi 1");
            }

            else if (_gameController.GetRound() == GameController.Round.R2)
            {
                _timer = 2.5f;
                Debug.Log("Hi 2");
            }

            else if (_gameController.GetRound() == GameController.Round.R3)
            {
                _timer = 2.0f;
                Debug.Log("Hi 3");
            }

            else if (_gameController.GetRound() == GameController.Round.R4)
            {
                _timer = 1.7f;
                Debug.Log("Hi 4");
            }*/


        }
    }

    protected virtual void OnEnable()
    {
        _soundController.clip = _sfx;
        _soundController.Play();
    }

    void OnDisable()
    {
        _soundController.Stop();
    }

}
