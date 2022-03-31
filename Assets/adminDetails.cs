using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class adminDetails : MonoBehaviour
{

    public InputField username;
    public InputField password;
    public Button Button;

    void Start()
    {
        //Subscribe to onClick event
        Button.onClick.AddListener(AdminDetails);
    }

    Dictionary<int, string> staffDetails = new Dictionary<int, string>
    {
        {101,"femi1998" },
        {102,"kwaks1999" },
        {103,"eman1999" }
    };


    public void AdminDetails()
    {
        //Get Username from Input then convert it to int
        int userName = Convert.ToInt32(username.text);
        //Get Password from Input
        string Password = password.text;

        string foundPassword;
        if (staffDetails.TryGetValue(userName, out foundPassword) && (foundPassword == Password))
        {
            Debug.Log("User authenticated");
        }
        else
        {
            Debug.Log("Invalid password");
        }
    }
}
