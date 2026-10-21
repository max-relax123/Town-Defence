using UnityEngine;

public class Wallet : MonoBehaviour
{
    private int _wheat;
    private int gold;

    private int Wheat => _wheat;
    private int Gold => _gold;
    private int WorkerCount => _workerCount; 
#region Gold
    public void AddGold(int gold)
    {
        _gold += gold;
    }

    public void RemoveGold(int gold)
    {

        _gold += gold;

    }
    #endregion
    public bool AddWheat(int wheat)
    {
        if (_wheat >= wheat)
        {

            _wheat -= wheat;
            return true;
        }

        return false;
      
    }

    public bool GetGold(int Gold)

    public bool EnoughWheat(int wheat) => _wheat >= wheat;
    public bool EnoughGold(int gold) => _gold >= gold;


}
