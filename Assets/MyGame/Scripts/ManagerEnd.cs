using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;



public class ManagerEnd : MonoBehaviour
{
    public TMP_Text displayKid;
    public TMP_Text displayCorrect;
    public SpriteRenderer winSprite;

    private SoRuntimeData runtimeData;
    private SoRuntimeChar runtimeChar;

    private void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("KinderaddiererRuntimeData");
        runtimeChar = Resources.Load<SoRuntimeChar>("CharSet");

        displayKid.text = runtimeData.nameKid;
        displayCorrect.text = runtimeData.scoreKid;
        winSprite.sprite = runtimeChar.kidsChar;



    }

    //generisch ueber Button 

    public void SwitchTheScene(int x)
    {
        
        SceneManager.LoadScene(x);
    }


}
