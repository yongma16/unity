using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Return_ui : MonoBehaviour
{
    private int scene1=0;
    private bool flag1 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Button1()
    {
        flag1 = !flag1;
    }
    // Update is called once per frame
    void Update()
    {
        if (flag1)
        {
            SceneManager.LoadScene(scene1);
        }
    }
}
