using UnityEngine;
using UnityEngine.UI;

public class StarManager : MonoBehaviour
{
    public static StarManager Instance;

    private int starAmount;

    public Image starIcon;

    public Sprite starIconSprite;

    public Text starText;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // Initialize the currency amount, e.g., from a saved value or default value
        starAmount = PlayerPrefs.GetInt("Stars", 500);
        UpdateStarUI();
    }

    // Method to add currency
    public void AddStar(int amount)
    {
        starAmount += amount;
        UpdateStarUI();
        SaveStar();
    }

    // Method to subtract currency
    public bool SpendStar(int amount)
    {
        if (starAmount >= amount)
        {
            starAmount -= amount;
            UpdateStarUI();
            SaveStar();
            return true;
        }
        return false;
    }

    // Update the UI Text element to display the current currency amount
    private void UpdateStarUI()
    {
        if (starText != null)
        {
            starText.text = "Stars: " + starAmount.ToString();
        }
        else
        {
            Debug.LogError("starText is not assigned!");
        }
    }

    // Save the currency amount
    private void SaveStar()
    {
        PlayerPrefs.SetInt("Star", starAmount);
    }

    public void OnAddStarButtonPressed()
    {
        AddStar(10); 
    }

    public void OnSpendStarButtonPressed()
    {
        
        SpendStar(10); 
    }
}
