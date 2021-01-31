using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Randomize : MonoBehaviour
{
    static Random rand;
    public static void Initialize()
    {
        rand = new Random();
    }
    public static int Next(int minvalue, int maxvalue)
    {
        return Random.Range(minvalue, (maxvalue + 1));
    }
}

public class Randomizer : MonoBehaviour
{
    int randomresult;
    int minval;
    int maxval;
    [SerializeField] TMP_InputField datainput1;
    [SerializeField] TMP_InputField datainput2;

    public Randomizer(int minval, int maxval)
    {
        this.minval = minval;
        this.maxval = maxval;
    }

    public int Randomresult
    {
        get
        {
            return randomresult;
        }
    }
    public void Roll()
    {
        randomresult = Randomize.Next(minval, maxval);
    }
}
