using UnityEngine;

public class ResourcesFabric : MonoBehaviour
{
    [SerializeField] private float _timeForIncome = 3f;
    [SerializeField] private int _baseWheatIncome = 5;
    [SerializeField] private int _baseGoldIncome = 0;
    private Wallet _wallet;
    private float _timer = 0;
    private bool isInit = false;
    public void Init(Wallet wallet)
    {
        if (!_isInit)
        {
            _wallet = wallet;
            _isInit = true;

        }

    }

    private void Update()
    {
        _timer += Time.deltaTime;
        if ( _timer > _timeForIncome)
        {
            int wheatIncome = _baseWheatIncome + wheatIncomePerWorker;

            _wallet.AddGold(_baseGoldIncome);
            _wallet.AddWheat(_baseWheatIncome);
            _timer = 0;
        }
    }

}
