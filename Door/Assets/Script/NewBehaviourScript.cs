using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public int buildindex;
    public void Restart()
    {
        SceneManager.LoadScene(buildindex);
    }
}
