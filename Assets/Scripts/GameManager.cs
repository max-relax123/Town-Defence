using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Текстовые элементы UI")]
    public TextMeshProUGUI wheatText;
    public TextMeshProUGUI warriorsText;
    public TextMeshProUGUI peasantsText;

    [Header("Количество ресурсов и жителей")]
    public int wheat = 10;
    public int peasants = 5;
    public int warriors = 0;

    [Header("Стоимость найма")]
    public int peasantCost = 5;
    public int warriorCost = 10;

    public void UpdateVisualUI()
    {
        if (wheatText != null) wheatText.text = "Wheat: " + wheat;
        if (warriorsText != null) warriorsText.text = "Warriors: " + warriors;
        if (peasantsText != null) peasantsText.text = "Peasants: " + peasants;
    }

    private void Start()
    {
        UpdateVisualUI();
    }
}
