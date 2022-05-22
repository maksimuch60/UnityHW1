using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MagicNumbers : MonoBehaviour
{
    [SerializeField] private int _min;
    [SerializeField] private int _max;

    [SerializeField] private TextMeshProUGUI InfoLabel;
    [SerializeField] private TextMeshProUGUI GuessLabel;
    [SerializeField] private Button MoreButton;
    [SerializeField] private Button LessButton;
    [SerializeField] private Button FinishButton;
    private int _guess;

    private void Start()
    {
        MoreButton.onClick.AddListener(MoreButtonClicked);
        LessButton.onClick.AddListener(LessButtonClicked);
        FinishButton.onClick.AddListener(FinishButtonClicked);

        SetInfoText($"задагай число от {_min} до {_max}");
        GuessNumber();
    }

    private void GuessNumber()
    {
        _guess = (_max + _min) / 2;
        SetGuessText($"Твое число {_guess}?");
    }

    private void SetInfoText(string text)
    {
        Debug.Log(text);

        InfoLabel.text = text;
    }

    private void SetGuessText(string text)
    {
        Debug.Log(text);

        GuessLabel.text = text;
    }

    private void MoreButtonClicked()
    {
        Debug.Log("Число больше");
        _min = _guess;
        GuessNumber();
    }

    private void FinishButtonClicked()
    {
        SetGuessText($"Победа! Твое число: {_guess}");
        MoreButton.onClick.RemoveListener(MoreButtonClicked);
        LessButton.onClick.RemoveListener(LessButtonClicked);
        FinishButton.onClick.RemoveListener(FinishButtonClicked);
    }

    private void LessButtonClicked()
    {
        Debug.Log("Число меньше");
        _max = _guess;
        GuessNumber();
    }
}