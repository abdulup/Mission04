using TMPro;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    MainManager Instance;

    public TextMeshProUGUI nameText;

    public static string playerName;

    void Start()
    {

    }


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(Instance);
            return;
        }
    }

    private void Update()
    {
        playerName = nameText.text;
    }
}
