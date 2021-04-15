// LOWMAN
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    public InputField usernameInput;
    public static string username;

    void Start()
    {
        username = "Lowman";
    }

    public void SaveUsername(string newName)
    {
        username = newName;
    }
}
