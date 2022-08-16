using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AtomsScript : MonoBehaviour
{
    public void LoadQuiz()
    {
        SceneManager.LoadScene(16);
    }
    public void HomePage()
    {
        SceneManager.LoadScene(0);
    }
}
