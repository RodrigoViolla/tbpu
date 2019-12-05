using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VidaPlaneta : MonoBehaviour
{
    public float vida = 100;
    public float danoPorFrame;
    public RectTransform vidaTransform;

    private float vidaMaxima;

    void Start()
    {
        vidaMaxima = vida;
    }

    private void Update()
    {
        vidaTransform.anchorMax = new Vector2(1, vida / vidaMaxima);

        if (vida <= 0)
            SceneManager.LoadScene("GameOver");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Planeta") {
            vida -= danoPorFrame;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Planeta")
        {
            vida -= danoPorFrame*10;
        }
    }
}
