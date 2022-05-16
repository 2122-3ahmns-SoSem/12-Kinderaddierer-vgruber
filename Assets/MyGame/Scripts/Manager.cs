using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum MyScenes

{

    WelcomeScene,

    MathScene,

    EndScene

}

public class Manager : MonoBehaviour
{
    //generisch ueber Button 

    public void SwitchTheScene(int x)

    {

        SceneManager.LoadScene(x);

    }


}
