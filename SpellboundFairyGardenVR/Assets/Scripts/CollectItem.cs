using UnityEngine;

public class CollectItem : MonoBehaviour
{
    public Transform player;
    public float collectDistance = 2f;

    void Update()
    {
        if (player == null) return;

        float distance = Vector3.Distance(transform.position, player.position);

        if (distance < collectDistance)
        {
            GameManager.instance.AddScore();
            gameObject.SetActive(false);
        }
    }
}