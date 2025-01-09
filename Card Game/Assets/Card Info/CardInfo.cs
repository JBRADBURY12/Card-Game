using UnityEngine;

[CreateAssetMenu(fileName = "CardInfo", menuName = "Scriptable Objects/CardInfo")]
public class CardInfo : ScriptableObject
{
    [Header("Card Info")]
    
    public string cardName;
    public string cardDescription;
    public string cardSpellDescription;
    public string cardAttackDescription;
    
    public CardType cardType;
    public Sprite cardArt;
    public int cardID;
    public int cardTier;



    [Header("Gameplay Info")]
    
    public int cardCost;
    public int cardSpellCost;
    public int cardKnockoutPoints;
    public int cardHealth;

    public int cardAttackDamage;
    public int cardSpellDamage;



    [Header("Rarity/Quality Info")]
    public Rarity rarity;
    public Quality quality;



    // List of rarities for cards
    public enum Rarity
    {
        Common,
        Holo,
        FullArt,
        SecretRare,
        SuperSecretRare,
        UltraSecretRare,
        HyperSecretRare,
        PixelRare,
        UltraFullArt,
        Promo
    };

    // Type of Card in play
    public enum CardType
    {
        Unit,
        Item,
        Spell
    };

    // Quality of the card
    public enum Quality
    {
        Authentic, //0
        FairToPoor, //1
        Good, //2
        VeryGood, //3
        VeryGoodToExcellent, //4
        Excellent, //5
        ExcellentToNearMint, //6
        ExcellentToNearMintPlus, //6.5 
        NearMint, //7
        NearMintPlus, //7.5
        NearMintToMint, //8
        NearMintToMintPlus, //8.5
        Mint, //9
        NearGemMint, //9.5
        GemMint //10
    };
}