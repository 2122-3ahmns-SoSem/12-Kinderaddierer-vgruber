using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public enum MyScenes

{

    WelcomeScene,

    MathScene,

    EndScene

}

public class ManagerWelcome : MonoBehaviour
{
    public TMP_InputField ipfKidsName;

    public TMP_Text ipfKid;

    private SoRuntimeData runtimeData;

    private SoRuntimeChar runtimeChar;



    private void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("KinderaddiererRuntimeData");
        runtimeChar = Resources.Load<SoRuntimeChar>("CharSet");

    }

    //generisch ueber Button 

    public void SwitchTheScene(int x)
    {

        runtimeData.nameKid = ipfKid.text;
        SceneManager.LoadScene(x);
    }

    public void SetCreeper(Sprite x)
    {
        runtimeChar.kidsChar = x;
    }

    public void SetEnder(Sprite x)
    {
        runtimeChar.kidsChar = x;
    }

    public void SetZombie(Sprite x)
    {
        runtimeChar.kidsChar = x;
    }


}
