using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SoNameData")]

public class SoRuntimeData : ScriptableObject
{
    public string nameKid;

    private void OnEnable()
    {
        //nameKid = "";
    }
}