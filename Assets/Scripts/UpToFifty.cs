using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpToFifty : MonoBehaviour
{
    [SerializeField] private Button NumberZeroButton;
    [SerializeField] private Button NumberOneButton;
    [SerializeField] private Button NumberTwoButton;
    [SerializeField] private Button NumberThreeButton;
    [SerializeField] private Button NumberFourButton;
    [SerializeField] private Button NumberFifeButton;
    [SerializeField] private Button NumberSixButton;
    [SerializeField] private Button NumberSevenButton;
    [SerializeField] private Button NumberEightButton;
    [SerializeField] private Button NumberNineButton;
    [SerializeField] private TextMeshProUGUI InfoLabel;
    [SerializeField] private TextMeshProUGUI EnterNumberLabel;
    [SerializeField] private TextMeshProUGUI SummaLabel;
    [SerializeField] private TextMeshProUGUI EndGameLabel;
    [SerializeField] private int Sum;
    private int _countSum;
    private int _countStep;

    private void Start()
    {
        EndGameLabel.gameObject.SetActive(false);
        SetInfoText();
        NumberZeroButton.onClick.AddListener(NumberZeroButtonClicked);
        NumberOneButton.onClick.AddListener(NumberOneButtonClicked);
        NumberTwoButton.onClick.AddListener(NumberTwoButtonClicked);
        NumberThreeButton.onClick.AddListener(NumberThreeButtonClicked);
        NumberFourButton.onClick.AddListener(NumberFourButtonClicked);
        NumberFifeButton.onClick.AddListener(NumberFifeButtonClicked);
        NumberSixButton.onClick.AddListener(NumberSixButtonClicked);
        NumberSevenButton.onClick.AddListener(NumberSevenButtonClicked);
        NumberEightButton.onClick.AddListener(NumberEightButtonClicked);
        NumberNineButton.onClick.AddListener(NumberNineButtonClicked);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InteractableButtons(true);
            EndGameLabel.gameObject.SetActive(false);
            _countSum = 0;
            _countStep++;
            SetSummaText();
            SetEnterNumberText("Обнуление");
        }
    }

    private void InteractableButtons(bool condition)
    {
        NumberZeroButton.interactable = condition;
        NumberOneButton.interactable = condition;
        NumberTwoButton.interactable = condition;
        NumberThreeButton.interactable = condition;
        NumberFourButton.interactable = condition;
        NumberFifeButton.interactable = condition;
        NumberSixButton.interactable = condition;
        NumberSevenButton.interactable = condition;
        NumberEightButton.interactable = condition;
        NumberNineButton.interactable = condition;
    }
    

    #region Listeners

    private void NumberNineButtonClicked()
    {
        SetEnterNumberText("9");
        _countSum += 9;
        _countStep++;
        SetSummaText();
        CheckForSum();
    }

    private void NumberEightButtonClicked()
    {
        SetEnterNumberText("8");
        _countSum += 8;
        _countStep++;
        SetSummaText();
        CheckForSum();
    }

    private void NumberSevenButtonClicked()
    {
        SetEnterNumberText("7");
        _countSum += 7;
        _countStep++;
        SetSummaText();
        CheckForSum();
    }

    private void NumberSixButtonClicked()
    {
        SetEnterNumberText("6");
        _countSum += 6;
        _countStep++;
        SetSummaText();
        CheckForSum();
    }

    private void NumberFifeButtonClicked()
    {
        SetEnterNumberText("5");
        _countSum += 5;
        _countStep++;
        SetSummaText();
        CheckForSum();
    }

    private void NumberFourButtonClicked()
    {
        SetEnterNumberText("4");
        _countSum += 4;
        _countStep++;
        SetSummaText();
        CheckForSum();
    }

    private void NumberThreeButtonClicked()
    {
        SetEnterNumberText("3");
        _countSum += 3;
        _countStep++;
        SetSummaText();
        CheckForSum();
    }

    private void NumberTwoButtonClicked()
    {
        SetEnterNumberText("2");
        _countSum += 2;
        _countStep++;
        SetSummaText();
        CheckForSum();
    }

    private void NumberOneButtonClicked()
    {
        SetEnterNumberText("1");
        _countSum += 1;
        _countStep++;
        SetSummaText();
        CheckForSum();
    }

    private void NumberZeroButtonClicked()
    {
        SetEnterNumberText("0");
        _countSum += 0;
        _countStep++;
        SetSummaText();
        CheckForSum();
    }

    #endregion


    private void CheckForSum()
    {
        if (_countSum >= Sum)
        {
            InteractableButtons(false);
            EndGameLabel.gameObject.SetActive(true);
            SetEndGameText();
            _countSum = 0;
            _countStep = 0;
        }
    }


    #region SetTexts

    private void SetEnterNumberText(String text)
    {
        EnterNumberLabel.text = "Нажмите цифру: " + text;
    }
    
    private void SetInfoText()
    {
        InfoLabel.text = $"Наберите в сумме {Sum} очков!";
    }
    
    private void SetSummaText()
    {
        SummaLabel.text = $"Сумма: {_countSum}";
    }
    
    private void SetEndGameText()
    {
        EndGameLabel.text = $"Конец игры!\nКоличество шагов: {_countStep}";
    }

    #endregion
    
}