using UnityEngine.SceneManagement;
using UnityEngine;

public class gameManager : MonoBehaviour
{

    public static gameManager instance;

    public Movement movement;
    private void Awake()
    {
        instance = this;
    }

    
    public void LoadMenuToQuiz()
    {

    }

    public void LoadPreviousScene()
    {

    }
}
