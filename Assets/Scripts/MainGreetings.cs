using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainGreetings : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TextMeshProUGUI playeName = GetComponent<TextMeshProUGUI>();
        playeName.text = $"Hi, {MainManager.playerName}";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
