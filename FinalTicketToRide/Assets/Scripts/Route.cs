using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

public class Route : MonoBehaviour
{
<<<<<<< HEAD
    public bool IsClaimed { get; private set; }
    public Player ClaimingPlayer { get; private set; }
    [SerializeField] private GameObject playerCardDeck;
    [SerializeField] private GameObject routeContainorObj;
    [SerializeField] private GameObject trainContainorObj;
    [SerializeField] private GameObject Error_Obj;
    [SerializeField] private TMP_Text Error_Text;



    private CardColor cardColour;
    private List<Card> cardsNeeded = new List<Card>();
=======
    public bool IsClaimed { get; set; }
    public Player ClaimingPlayer { get; set; }
    public string RequiredColor { get; set; }
    public int RequiredColorCount { get; set; }
    public GameObject routeBox;
    public Routes routeData; // Reference to the Routes ScriptableObject
    public DestinationTicket? destinationTicket;
    public Button claimButton;
>>>>>>> bcdbdd5e2f154b2a791e111c8432888a157ec867

    private void Start()
    {
        claimButton.onClick.AddListener(ClaimRoute);
    }

    public void Claim(Player claimingPlayer)
    {
        if (IsClaimed)
        {
            Debug.Log("Route is already claimed.");
            return;
        }

        claimingPlayer.ClaimRoute(this);
    }

    public void ClaimRoute()
    {
        if (IsClaimed)
        {
            Debug.Log("Route is already claimed.");
            return;
        }

        if (ClaimingPlayer != null && ClaimingPlayer.HasColorCards(RequiredColor, RequiredColorCount))
        {
            // Add your logic to handle claiming the route here
            Debug.Log("Claiming the route from " + routeData.startCity + " to " + routeData.endCity);
        }
        else
        {
            Debug.Log("Not enough color cards to claim the route.");
        }
    }

    public List<Card> GetCardsNeeded(Transform cardHolder)
    {       

        foreach (Transform card in cardHolder) {

           
            Sprite cardSprite = card.GetComponent<Sprite>();
            Color spriteCardColour = card.GetComponent<Color>();
            

            if (card != null)
            {
                cardsNeeded.Add(new Card(checkColour(spriteCardColour),cardSprite));


            }
        
        
        }



        // Implement the logic to determine the cards needed to claim the route

        return cardsNeeded;
    }

    public int countCardsSameColour(CardColor inCardColour,Color routeColour)
    {
        int correctColour = 0;

        for (int check = 0; check < ClaimingPlayer.cardPrefab.transform.childCount; check++)
        {

            if (inCardColour.Equals(routeColour))
            {

                correctColour++;


            }

        }

        return correctColour;

    }

    public void routeLength(int sameCards)
    {
        if (sameCards>= routeContainorObj.transform.childCount)
        {
            trainContainorObj.SetActive(true);


        }
        else
        {
            Error_Obj.SetActive(true);
            Error_Text.text = $"Insufficient Like Cards";


        }



    }


    public CardColor checkColour(Color chosenColour)
    {
       // CardColor cardcolours;
        if (CardColor.Black.Equals(chosenColour))
        {
            return CardColor.Black;

        }

        else if (CardColor.Blue.Equals(chosenColour))
        {

            return CardColor.Black;
        }
        else if (CardColor.Green.Equals(chosenColour))
        {
            return cardColour = CardColor.Blue;

        }
        else if (CardColor.Grey.Equals(chosenColour))
        {
            return CardColor.Grey;

        }
        else if (CardColor.Orange.Equals(chosenColour))
        {

            return CardColor.Orange;
        }
        else if (CardColor.Pink.Equals(chosenColour))
        {
            return CardColor .Pink;

        }
        else if (CardColor.Red.Equals(chosenColour))
         {
            return CardColor.Red;

        }
        else if (CardColor.Yellow.Equals(chosenColour))
        {
            return CardColor.Yellow;

        }
        else if (CardColor.White.Equals(chosenColour))
        {
            return CardColor.White;

        }else
        { return CardColor.Locomotive; }

       


    }

    public void UpdateUI()
    {
        // Implement the logic to update the UI for the claimed route
    }
<<<<<<< HEAD


    public void claimRoute()
    {
       int countedCards=0;
        
        GetCardsNeeded(playerCardDeck.transform);
        for(int compare=0; compare< cardsNeeded.Count; compare++)
        {
          countedCards+= countCardsSameColour(cardsNeeded[compare].getCardColor(),routeContainorObj.GetComponentInChildren<SpriteRenderer>().color); 
           
        }
        routeLength(countedCards);
       



    }



}
=======
}
>>>>>>> bcdbdd5e2f154b2a791e111c8432888a157ec867
