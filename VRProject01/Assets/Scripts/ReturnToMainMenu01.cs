using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMainMenu01 : MonoBehaviour
{
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void PlayGameAgain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("RigidBodyPro_01");
    }
}
