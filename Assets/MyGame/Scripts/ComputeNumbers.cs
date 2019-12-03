using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ComputeNumbers : MonoBehaviour
{
    public TextMeshProUGUI result;
    public TMP_InputField inputA;
    public TMP_InputField inputB;
    public Button btnReset;
    public Button btnSubNumbers;

    public void SetResult()
    {
        result.text = SubNumbers().ToString();
        //set gui-elements active/inactive 
        inputA.interactable = false;
        inputB.interactable = false;
        btnSubNumbers.interactable = false;
        btnReset.interactable = true;
    }

    public void Reset()
    {
        inputA.text = "0";
        inputB.text = "0";
        result.text = "Result";
        inputA.interactable = true;
        inputB.interactable = true;
        btnSubNumbers.interactable = true;
        btnReset.interactable = false;
    }

    private int SubNumbers()
    {
        int tempResult = int.Parse(inputA.text) - int.Parse(inputB.text);
        return tempResult;
    }

}