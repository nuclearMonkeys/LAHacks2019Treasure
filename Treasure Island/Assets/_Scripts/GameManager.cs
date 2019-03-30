using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager gm;
    public Canvas canvas;
    public bool playerIsDead = false;

    private void Awake()
    {
        
        if (gm == null) {
            DontDestroyOnLoad(gameObject);
            gm = this;
        }
        else if (gm != this) {
            Destroy(gameObject);
        }
        
    }

    void Update()
    {
        canvas = Object.FindObjectOfType<Canvas>();
        if (playerIsDead) {
            canvas.transform.GetChild(1).gameObject.SetActive(true);
            print("Press 'R' to Restart");
        }
    }
}
