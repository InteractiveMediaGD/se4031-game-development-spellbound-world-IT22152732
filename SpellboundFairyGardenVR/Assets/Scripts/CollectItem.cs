using UnityEngine;

public class CollectItem : MonoBehaviour
{
    public Transform player;
    public float collectDistance = 2f;
    public ParticleSystem collectEffect;
    public AudioSource collectSound;

    private bool collected = false;

    void Update()
    {
        if (collected || player == null) return;

        float distance = Vector3.Distance(transform.position, player.position);

        if (distance < collectDistance)
        {
            collected = true;

            if (collectEffect != null)
            {
                collectEffect.transform.position = transform.position;
                collectEffect.Play();
            }

            if (collectSound != null)
            {
                collectSound.Play();
            }

            GameManager.instance.AddScore();
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;
            Destroy(gameObject, 2f);
        }
    }
}