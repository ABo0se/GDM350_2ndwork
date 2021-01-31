using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class MainProgram : MonoBehaviour
{
    List<object> Randomlist = new List<object>();
    //public TextMeshProUGUI TextInputresult;
    [SerializeField] TextMeshProUGUI TextOutputresult;
    [SerializeField] Button RandomScript;
    [SerializeField] TMP_InputField numberofinput1;
    [SerializeField] TMP_InputField input1;
    [SerializeField] TMP_InputField input2;
    double mininput, maxinput, numberofinput;
    int numberofinputb;
    int checkerror;
    string actualresult;
    // Start is called before the first frame update
    void Start()
    {
        Reset2();
    }

    public void GetInputOnClickHandler()
    {
        ResetOnlyAnswer();
        checkerror = 0;
        numberofinput = double.Parse(numberofinput1.text);
        mininput = double.Parse(input1.text);
        maxinput = double.Parse(input2.text);

        if (mininput % 1 == 0 && maxinput % 1 == 0 && numberofinput % 1 == 0)
        {
            Randomwork();
            Result();
        }
        else
        {
            checkerror = 1;
            Result();
        }
    }
    public void Result()
    {
        if (checkerror == 0)
        {
            actualresult = String.Join(", ", Randomlist);
        }
        else
        {
            actualresult = "Error! Please Try again.";
        }
        TextOutputresult.text = actualresult;
    }
    public void Reset2()
    {
        Randomlist.Clear();
        TextOutputresult.text = "-";
        numberofinput1.text = "Enter Number...";
        input1.text = "Enter Number...";
        input2.text = "Enter Number...";
    }
    public void ResetOnlyAnswer()
    {
        TextOutputresult.text = "-";
        Randomlist.Clear();
    }
    public void Randomwork()
    {
        numberofinputb = 1;
        while (numberofinputb <= numberofinput)
        {
            Randomizer Random1 = new Randomizer((int)mininput, (int)maxinput);
            Random1.Roll();
            Randomlist.Add(Random1.Randomresult);
            numberofinputb++;
        }
    }
}