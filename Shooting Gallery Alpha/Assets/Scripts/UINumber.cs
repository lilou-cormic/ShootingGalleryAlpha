using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class UINumber : MonoBehaviour
{
    private Image image;

    public bool IsLarge = false;

    private void Start()
    {
        image = GetComponent<Image>();
    }

    public void SetNumber(int number)
    {
        if (image == null)
            image = GetComponent<Image>();

        image.sprite = (IsLarge ? UISprites.GetLargeNumberSprite(number) : UISprites.GetNumberSprite(number));
    }
}
