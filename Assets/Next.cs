using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour {
    public string nextScene;

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.layer == LayerMask.NameToLayer("saveworld"))
        {

            SceneManager.LoadScene(nextScene);

        }

    }
}
