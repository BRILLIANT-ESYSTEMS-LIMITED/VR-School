
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToPlanet : MonoBehaviour
{
    public void LoadMercury()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadVenus()
    {
        SceneManager.LoadScene(3);
    }
    public void LoadEarth()
    {
        SceneManager.LoadScene(4);
    }
    public void LoadMars()
    {
        SceneManager.LoadScene(5);
    }
    public void LoadJupiter()
    {
        SceneManager.LoadScene(6);
    }
    public void LoadSaturn()
    {
        SceneManager.LoadScene(7);
    }
    public void LoadUranus()
    {
        SceneManager.LoadScene(8);
    }
    public void LoadNeptune()
    {
        SceneManager.LoadScene(9);
    }
    public void LoadPluto()
    {
        SceneManager.LoadScene(10);
    }
    public void Return()
    {
        SceneManager.LoadScene(1);
    }
    public void HomePage()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadSolarSystem()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadAtoms()
        {
        SceneManager.LoadScene(12);
    }
    public void LoadSun()
    {
        SceneManager.LoadScene(11);
    }
}
