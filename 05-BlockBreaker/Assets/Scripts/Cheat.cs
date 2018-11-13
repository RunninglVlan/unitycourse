using System;
using UnityEngine;

public class Cheat
{
    private char[] code;
    private int index;

    public Cheat(string code)
    {
        this.code = code.ToCharArray();
    }

    public void ifEntered(Action action)
    {
        if (Input.anyKeyDown)
        {
            if (Input.GetKeyDown(code[index].ToString()))
            {
                index++;
            }
            else
            {
                index = 0;
            }
        }

        if (index == code.Length)
        {
            action();
            index = 0;
        }
    }
}