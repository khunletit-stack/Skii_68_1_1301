using UnityEngine;

public class trees : MonoBehaviour
{
    private MeshRenderer rd;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rd = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        rd.material.color = Color.red;
        player player = collision.gameObject.GetComponent<player>(); 

        if (player == null )
        {
            return;
        }
        player.HP -= 15;

        UImaneger.Instance.ShowNotiText($"Hurt -15\nHP: {player.HP}");
    }

    private void OnCollisionExit(Collision collision)
    {
        rd.material.color = new Color32(210, 105, 30, 255);
    }
}
