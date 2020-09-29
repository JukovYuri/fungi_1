using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnClcDown : MonoBehaviour
{

    public MagicNumbers magicNumbers;

    public void Click()
    {
        magicNumbers.Down();
    }
}