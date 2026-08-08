using UnityEngine;

public class flag : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        player player = other.gameObject.GetComponent<player>();

        if (player == null)
            return;

        player.Point += 10;
        UImaneger.Instance.ShowNotiText($"+10 points\nPoints: {player.Point}");
        Destroy(gameObject);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
