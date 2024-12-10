using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManager : MonoBehaviour
{
    public GameObject welcomeText;
    public GameObject welcomeText2;
    public GameObject welcomeText3;
    public float delay = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= delay) 
        {
            welcomeText.SetActive(false);
            welcomeText2.SetActive(true);
        }
        if (Time.time >= 2 * delay)
        {
            welcomeText.SetActive(false);
            welcomeText2.SetActive(false);
            welcomeText3.SetActive(true);
        }
    }
}
