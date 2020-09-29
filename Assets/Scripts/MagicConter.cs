using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicConter : MonoBehaviour
{
    int counter;
    int sum;
    int number;

    void Start()
    {
        counter = 0;
        sum = 0;
    }

    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.Keypad0) || Input.GetKeyDown(KeyCode.Alpha0))
        {
            number = 0;
            GetSum(number);
        }

        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
        {
            number = 1;
            GetSum(number);
        }

        if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))
        {
            number = 2;
            GetSum(number);
        }

        if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3))
        {
            number = 3;
            GetSum(number);
        }

        if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4))
        {
            number = 4;
            GetSum(number);
        }

        if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5))
        {
            number = 5;
            GetSum(number);
        }

        if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6))
        {
            number = 6;
            GetSum(number);
        }

        if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7))
        {
            number = 7;
            GetSum(number);
        }

        if (Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.Alpha8))
        {
            number = 8;
            GetSum(number);
        }

        if (Input.GetKeyDown(KeyCode.Keypad9) || Input.GetKeyDown(KeyCode.Alpha9))
        {
            number = 9;
            GetSum(number);
        }

        

    }

    void GetSum (int x)
    {
        sum += x;
        counter++;
        print($"нажата цифра {x}, сумма {sum}");

        if (sum >= 50)
        {
            print($"Игра окончена! Количество ходов: {counter}");
        }

    }
}
