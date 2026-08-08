using TMPro;
using UnityEngine;

public class UImaneger : MonoBehaviour
{


    [SerializeField]
    private TMP_Text noticText;
    [SerializeField]
    private GameObject restartButton;

    [SerializeField]
    private player player;
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


    public void restartgame()
    {
        player.transform.position = new Vector3(0f, 86.81f, -84.99f);
        player.HP = 100;
        ShowNotiText("Restart");
        Time.timeScale = 1f;
        ShowHideRestartbutton(false);
    }

    public void ShowHideRestartbutton(bool flag)
    {
        restartButton.SetActive(flag);
    }

}
