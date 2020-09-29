using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnClcOk : MonoBehaviour
{
    public MagicNumbers magicNumbers;
    public void Click()
    {
        magicNumbers.Ok();
    }
}