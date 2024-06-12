using UnityEngine.SceneManagement;
using UnityEngine;

public class ManageSceneAll: MonoBehaviour
{
    public void LoadLevel1ToLevel2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void LoadPreviousScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void TreeScene()
    {
        SceneManager.LoadScene("A1");
    }
    public void LoadMenuToQuiz()
    {
        SceneManager.LoadScene("GameQuiz");
    }

    public void LoadQuizToLevel2()
    {
        SceneManager.LoadScene("Level 2");

    }
    public void LoadMenuToLevel2()
    {
        SceneManager.LoadScene("Level 2");

    }
    public void LoadScene1ToMenuQuiz()
    {
        SceneManager.LoadScene("MenuQuiz");

    }
    public void LoadMainMenuToLvl1()
    {
        SceneManager.LoadScene("Level 1");

    }
    public void ExitGame()
    {
        Application.Quit();

    }
}
