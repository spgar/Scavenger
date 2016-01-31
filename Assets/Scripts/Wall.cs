using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour
{
    public Sprite damageSprite;
    public int hitPoints = 4;

    private SpriteRenderer spriteRenderer;

    public AudioClip chopSound1;
    public AudioClip chopSound2;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void DamageWall(int damage)
    {
        spriteRenderer.sprite = damageSprite;
        hitPoints -= damage;
        SoundManager.instance.RandomizeFX(chopSound1, chopSound2);

        if (hitPoints <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
