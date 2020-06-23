using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CharacterSelector : MonoBehaviour
{
    public float Speed;
    public float JumpHeight;
    public float ClimbSpeed;
    public void LoadLevel()
    {
        SceneManager.LoadScene(1);
    }
    public void SetJumper()
    {
        // Speed = .5f;
        // JumpHeight = 1.0f;
        // ClimbSpeed = .5f;
        PlayerPrefs.SetFloat("Speed", 0.5f);
        PlayerPrefs.SetFloat("JumpHeight", 1.0f);
        PlayerPrefs.SetFloat("ClimbSpeed", 0.5f);
        PlayerPrefs.SetString("Color","Red");
        LoadLevel();
    }
    public void SetRunner()
    {
        PlayerPrefs.SetFloat("Speed", 1.0f);
        PlayerPrefs.SetFloat("JumpHeight", 0.5f);
        PlayerPrefs.SetFloat("ClimbSpeed", 0.5f);
        PlayerPrefs.SetString("Color","Blue");
        LoadLevel();
    }
    public void SetClimber()
    {
        PlayerPrefs.SetFloat("Speed", 0.5f);
        PlayerPrefs.SetFloat("JumpHeight", 0.5f);
        PlayerPrefs.SetFloat("ClimbSpeed", 1.0f);
        PlayerPrefs.SetString("Color","Yellow");
        LoadLevel();
    }
}
