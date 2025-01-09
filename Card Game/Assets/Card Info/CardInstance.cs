using UnityEngine;

[System.Serializable] // optional if you want to see this in the Inspector
public class CardInstance
{
    public CardInfo cardInfo;

    // Runtime stats that can change
    public int currentHealth;
    public int currentCost;
    public int currentSpellCost;
    public int currentAttackDamage;
    public int currentSpellDamage;

    // Status flags or states
    public bool isKnockedOut;
    public bool isInPlay;

    public CardInstance(CardInfo info)
    {
        cardInfo = info;
        ResetToBaseStats();
    }

    // Resets the card to its base stats from the ScriptableObject
    public void ResetToBaseStats()
    {
        currentHealth = cardInfo.cardHealth;
        currentCost = cardInfo.cardCost;
        currentSpellCost = cardInfo.cardSpellCost;
        currentAttackDamage = cardInfo.cardAttackDamage;
        currentSpellDamage = cardInfo.cardSpellDamage;
        isKnockedOut = false;
        isInPlay = false;
    }

    // Example method to apply damage
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            // Mark knocked out, or handle whatever your game logic requires
            isKnockedOut = true;
            currentHealth = 0;
        }
    }

    // Example method to reduce cost for a turn
    public void ApplyCostModifier(int costReduction)
    {
        currentCost = Mathf.Max(0, currentCost - costReduction);
    }
}

