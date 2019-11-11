using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UI : MonoBehaviour
{
    public int scene1, scene2, scene3, scene4, scene6, scene7,scene8, sceneUI;//场景编号对应
    private bool flag1=false, flag2=false, flag3=false, flag4=false, flag5=false,flag6=false,flag7=false,flag8=false,flag00=false;
    void Start()
    {

    }
    public void Button00()
    {
        flag00 = !flag00;
    }
    public void Button1()
    {
        flag1 = !flag1;
    }
    public void Button2()
    {
        flag2 = !flag2;
    }
    public void Button3()
    {
        flag3 = !flag3;
    }
    public void Button4()
    {
        flag4 = !flag4;
    }
    public void Button5()
    {
        flag5 = !flag5;
    }
    public void Button6()
    {
        flag6 = !flag6;
    }
    public void Button7()
    {
        flag7 = !flag7;
    }
    public void Button8()
    {
        flag8 = !flag8;
    }
    // Update is called once per frame
    void Update()
    {
        if (flag1)
        {
            SceneManager.LoadScene(scene1);
        }
        if (flag2)
        {
            SceneManager.LoadScene(scene2);
        }
        if (flag3)
        {
            SceneManager.LoadScene(scene3);
        }
        if (flag4)
        {
            SceneManager.LoadScene(scene4);
        }
        if (flag5)
        {
            Application.OpenURL("https://github.com/yongma16/yma");
        }
        if (flag6)
        {
            SceneManager.LoadScene(scene6);
        }
        if (flag7)
        {
            SceneManager.LoadScene(scene7);
        }
        if (flag8)
        {
            SceneManager.LoadScene(scene8);
        }
        if (flag00)
        {
            SceneManager.LoadScene(sceneUI);
        }
    }
}
