using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnEndOk : MonoBehaviour
{
    public MagicNumbers magicNumbers;
    public void Click()
    {
        magicNumbers.Start();
    }
}
