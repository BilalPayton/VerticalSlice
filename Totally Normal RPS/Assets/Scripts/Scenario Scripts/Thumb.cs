using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Thumb : Scenario
{
    [SerializeField] private SpriteRenderer _sprite;
    [SerializeField] private SpriteRenderer _upSprite;
    [SerializeField] private SpriteRenderer _downSprite;

    [SerializeField] private AudioClip _upSound;
    [SerializeField] private AudioClip _downSound;

    private int randNum;

    // Start is called before the first frame update

    protected override void Update()
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
        }
    }

    void ChooseThumb()
    {
        randNum = Random.Range(0, 2);

        if (randNum == 0)
        {
            _sfx = _upSound;
            _sprite.sprite = _upSprite.sprite;
            _requiredKey = KeyCode.UpArrow;
            
        }

        else
        {
            _sfx = _downSound;
            _sprite.sprite = _downSprite.sprite;
            _requiredKey = KeyCode.DownArrow;
        }
    }

    protected override void OnEnable()
    {
        ChooseThumb();
        base.OnEnable();
    }

    
    
}
