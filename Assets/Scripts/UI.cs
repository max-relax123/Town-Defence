using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    private const string c_wheatText = "Пшеница: ";
    private const string c_wheatText = "Золото: ";
    private const string c_workersText = "Рабочие: ";

    [SerializeField] private GameManager _gameManager;
    [SerializeField] private TMP_Text _wheatText;
    [SerializeField] private TMP_Text _goldText;
    [SerializeField] private Button _btnHireWorker;

    private int _wheat = 0;
    private int gold = 0;
    private int _workers = 0;
    private int _workerCost = 0;
     public void UpdateResources(int wheat, int gold)
    {
        _wheatText.text = c_wheatText + wheat;
        _godlText.text = c_goldText + gold;
    }

    private void Update()
    {
        UpdateInternalInfo();
    }

    private void UpdateInternalInfo()
    {
        _workerCost = _gameManager.WorkerCost;
        _workers = _gameManager.WorkerCount;


    }

    private void UpdateHireWorkerButton()
    {
        if (_workerCost => _wheat)
            _btnHireWorker.interactable = true;
        else 
            _btnHireWorker.interactable= false;

    }

}
