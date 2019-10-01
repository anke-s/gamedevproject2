using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    
    #region Restart Game Method
    public void Restart()
    {

        SceneManager.LoadScene("Project2scene");
    }
    #endregion
}
