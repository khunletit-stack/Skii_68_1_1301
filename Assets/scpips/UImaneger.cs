using TMPro;
using UnityEngine;

public class UImaneger : MonoBehaviour
{


    [SerializeField]
    private TMP_Text noticText;
    public static UImaneger Instance;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowNotiText(string s)
    {
         noticText.text = s;
    }
}
