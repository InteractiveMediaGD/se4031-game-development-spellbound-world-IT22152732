using UnityEngine;
using TMPro;

public class SpellBookInteract : MonoBehaviour
{
    public Transform player;
    public float interactDistance = 2f;
    public TextMeshProUGUI spellText;

    private bool spellLearned = false;

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance < interactDistance)
        {
            if (!spellLearned)
            {
                spellText.text = "Press F to learn spell";

                if (Input.GetKeyDown(KeyCode.F))
                {
                    ActivateSpell();
                }
            }
        }
        else
        {
            if (!spellLearned)
                spellText.text = "";
        }
    }

    void ActivateSpell()
    {
        spellLearned = true;
        spellText.text = "? Fire Spell Unlocked!";
    }
}