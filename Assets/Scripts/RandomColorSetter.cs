using UnityEngine;

public class RandomColorSetter : MonoBehaviour
{
    private Renderer _renderer;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();

        SetColor();
    }

    private void SetColor()
    {
        float randomRed = Random.value;
        float randomGreen = Random.value;
        float randomBlue = Random.value;

        Color randomColor = new(randomRed, randomGreen, randomBlue);

        _renderer.material.color = randomColor;
    }
}
