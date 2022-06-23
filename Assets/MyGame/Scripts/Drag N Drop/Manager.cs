using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public Numbers refNumberPoints;
    public GameObject dropZone;
    public GameObject parentSigns;
    public Numbers[] nbrsPlain;
    public int correct, incorrect;
    public TMP_Text textCorrect, textIncorrect;
    public TMP_Text displayKid;

    private SoRuntimeData runtimeData;


    // Start is called before the first frame update
    void Start()
    {
        GenerateNewTask();
        correct = incorrect = 0;
        textCorrect.text = correct.ToString();
        textIncorrect.text = incorrect.ToString();
        runtimeData = Resources.Load<SoRuntimeData>("KinderaddiererRuntimeData");

        displayKid.text = runtimeData.nameKid;
    }

    public void AddToAndShowCorrectTasks()
    {
        correct++;
        textCorrect.text = correct.ToString();
    }
    public void AddToAndShowIncorrectTasks()
    {
        incorrect++;
        textIncorrect.text = incorrect.ToString();
    }

    private void GenerateNewTask()
    {
        refNumberPoints.representingNumber = Random.Range(1, 10);
        refNumberPoints.SetupNumberRepresentation();
    }

    public void ResetTask()
    {
        GenerateNewTask();
        SetAllNumbersDragable(true);

        for(int i = 0; i < nbrsPlain.Length; i++)
        {
            nbrsPlain[i].Reset(parentSigns);
        }

     
    }

    public void SetAllNumbersDragable(bool dragOk)
    {
        for(int i = 0; i< nbrsPlain.Length; i++)
        {
            nbrsPlain[i].dragable = dragOk;
        }
    }

    public void SwitchTheScene(int x)
    {
        if (correct == 4 || correct+incorrect==4 || incorrect == 4)
        {
            runtimeData.scoreKid = correct.ToString(); 
            SceneManager.LoadScene(x);
        }
    }
}
