using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameController : MonoBehaviour
{

    [SerializeField] private List<GameObject> _scenarioList;
    [SerializeField] private List<GameObject> _scenariosToBeAdded;
    [SerializeField] private GameObject _timerText;
    private float _timeTillNextScenario;

    private int scenarioIndex;

    private int _scenarioListSize;
    private int _scenariosToBeAddedSize;
    private int _points;

    void Start()
    {
        _timeTillNextScenario = 0.0f;
        _scenarioListSize = _scenarioList.Count;
        _scenariosToBeAddedSize = _scenariosToBeAdded.Count;
    }


    void Update()
    {
        _scenarioListSize = _scenarioList.Count;
        _scenariosToBeAddedSize = _scenariosToBeAdded.Count;

        if (_timeTillNextScenario <= 0.0f)
        {
            scenarioIndex = Random.Range(0, _scenarioListSize);

            _scenarioList.ElementAt(scenarioIndex).gameObject.SetActive(true);
            _timerText.SetActive(true);

            _timeTillNextScenario = 2.0f;


        }

        if (_scenarioList.ElementAt(scenarioIndex).gameObject.activeSelf == false)
        {
            _timerText.SetActive(false);
            _timeTillNextScenario -= Time.deltaTime;
        }

        if (_points == 8 && _scenariosToBeAddedSize != 0)
        {
            _scenarioList.Add(_scenariosToBeAdded.ElementAt(0));
            _scenariosToBeAdded.RemoveAt(0);
        }
    }

}
