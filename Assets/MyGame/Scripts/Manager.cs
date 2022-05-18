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

public class Manager : MonoBehaviour
{
    public TMP_InputField ipfKidsName;
    public TMP_Text displayKidsName;

    private SoRuntimeData runtimeData;

    private void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("KinderaddiererRuntimeData");


        if (SceneManager.GetActiveScene().buildIndex == (int)MyScenes.MathScene)
        {
            displayKidsName.text = runtimeData.nameKid;
        }
    }

    //generisch ueber Button 

    public void SwitchTheScene(int x)
    {
        Debug.Log("button pressed, get kidsname " + ipfKidsName.text);


        if (SceneManager.GetActiveScene().buildIndex == (int)MyScenes.WelcomeScene)
        {
            displayKidsName.text = runtimeData.nameKid;
        }

        runtimeData.nameKid = ipfKidsName.text;
        SceneManager.LoadScene(x);
    }


}
