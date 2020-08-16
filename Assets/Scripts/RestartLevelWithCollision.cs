using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelWithCollision : MonoBehaviour
{

    private void OnCollisionEnter(Collision colision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
