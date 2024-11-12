using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FailSFX : MonoBehaviour
{
    [SerializeField] private AudioSource SFX;
    // Start is called before the first frame update
    void Start()
    {
        SFX.Play();

        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
