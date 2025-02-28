using UnityEngine;

[CreateAssetMenu(fileName = "New Train Card", menuName = "Ticket to Ride/Train Card")]
public class Card : ScriptableObject
{
    public CardColor color;
    public Sprite cardSprite; // Sprite representing the card


    public Card(CardColor inCardColour, Sprite inCardSprite)
    {
        color = inCardColour;
        cardSprite = inCardSprite;

    }

    // Custom property to display the card name in the inspector
    public string CardName => color.ToString() + " Card";

    // Color property
    public string Color => color.ToString();

    // Add any additional fields or methods specific to train cards


    public CardColor getCardColor()
    {
        return color;
    }

    public Sprite getSprite()
    {

        return cardSprite;
    }
}
