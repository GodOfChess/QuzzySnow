using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{
    public int line, floor;
    public bool isDone;

    public int GetCurrentLine()
    {
        return line;
    }
    public int GetCurrentFloor()
    {
        return floor;
    }

    public void ButtonDone()
    {
        isDone = true;
    }


    public bool GetDone()
    {
        return isDone;
    }
}
